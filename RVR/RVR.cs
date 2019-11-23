using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.IO;
using System.IO.Ports;

namespace RVR
{
    public partial class RVR : Form
    {
        private byte seqno = 1;
        private byte[] Buffer = new byte[256];
        private int msg = 0;
        private Responses response = new Responses();
        private string Ver;

        public RVR()
        {
            string[] RVRLeds = { "All LEDS", "Indication Left", "Indication Right", "Indication Right", "Headlight Left", "Headlight Right", "Battery Door Front",
                                "Battery Door Rear", "Power Button Front", "Power Button Rear", "Brake Light Left", "Brake Light Right"};
            string[] RVRColors = { "Red", "Green", "Blue", "White", "Yellow", "Purple", "Orange", "Pink", "Off" };

            string[] RVRStreaming = {"Quaternion", "IMU", "Accelerometer", "Color", "Gyroscope", "Locator", "Velocity", "Speed", "Core Time", "Ambient Light"};

            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                ComPort.Items.AddRange(ports);
                ComPort.SelectedIndex = 0;
            }
            LEDS.Items.AddRange(RVRLeds);
            LEDColor.Items.AddRange(RVRColors);
            Streaming.Items.AddRange(RVRStreaming);
        }

        public void Send(Message m)
        {
            m.seq(Sequence());
            m.is_activity(true);

            byte[] b = m.serialize();
            
            Serial.Write(b, 0, b.Length);
        }

        private byte Sequence()
        {
            return seqno++;
        }

        private void InBound(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int ptr;
            int r = Serial.BytesToRead;

            if (r == 0)
                return;

            byte[] b = new byte[r];

            Serial.Read(b, 0, r);
            ptr = 0;

            for (; ptr < b.Length; ptr++)
            {
                if (b[ptr] == 0x8d)
                {
                    msg = 0;
                    Buffer[msg++] = b[ptr];
                    continue;
                }

                if (msg > 0)
                    Buffer[msg++] = b[ptr];

                if (b[ptr] == 0xd8)
                {
                    response.doResponses(Buffer, msg);
                    msg = 0;
                    continue;
                }
            }

        }

        private void DoWake(object sender, EventArgs e)
        {
            Commands c = new Commands();

            Message x = c.wake();
            Send(x);
        }

        private void DoSleep(object sender, EventArgs e)
        {
            Commands c = new Commands();

            Message x = c.sleep();

            Send(x);
        }

        private void DoInfo(object sender, EventArgs e)
        {
            Commands c = new Commands();

            Message x = c.get_battery_percentage();
            Send(x);

            x = c.get_battery_voltage_state();
            Send(x);

            x = c.get_battery_voltage_in_volts(1);
            Send(x);

            x = c.get_bluetooth_advertising_name();
            Send(x);

            x = c.get_main_application_version();
            Send(x);

            x = c.get_main_application_version();
            Send(x);

            x = c.get_board_revision();
            Send(x);

            x = c.get_bootloader_version();
            Send(x);

            x = c.get_mac_address();
            Send(x);

            x = c.get_processor_name();
            Send(x);

            x = c.get_stats_id();
            Send(x);

            x = c.get_sku();
            Send(x);

            x = c.get_core_up_time_in_milliseconds();
            Send(x);
        }

        private void DoPaint(object sender, PaintEventArgs e)
        {
            float f;

            if (response.sleeping)
                State.Text = "Sleeping";
            else
                State.Text = "Awake";
            if (response.Error > 0)
            {
                switch (response.Error)
                {
                    case ErrorCode.bad_cid:
                        Error.Text = "Bad Command ID";
                        break;
                    case ErrorCode.bad_data_length:
                        Error.Text = "Bad Data Length";
                        break;
                    case ErrorCode.bad_data_value:
                        Error.Text = "Bad Data Value";
                        break;
                    case ErrorCode.bad_did:
                        Error.Text = "Bad Device ID";
                        break;
                    case ErrorCode.bad_tid:
                        Error.Text = "Bad Transaction ID";
                        break;
                    case ErrorCode.busy:
                        Error.Text = "Device Busy";
                        break;
                    case ErrorCode.failed:
                        Error.Text = "Command Failed";
                        break;
                    case ErrorCode.not_yet_implemented:
                        Error.Text = "Not Yet Implemented";
                        break;
                    case ErrorCode.restricted:
                        Error.Text = "Restricted";
                        break;
                    case ErrorCode.target_unavailable:
                        Error.Text = "Target Unavailable";
                        break;
                }
            }
            else
                Error.Text = "";

            if (response.BatteryState == BatteryVoltageStatesEnum.unknown)
                BatteryState.Text = "unknown";
            if (response.BatteryState == BatteryVoltageStatesEnum.ok)
                BatteryState.Text = "ok";
            if (response.BatteryState == BatteryVoltageStatesEnum.low)
                BatteryState.Text = "low";
            if (response.BatteryState == BatteryVoltageStatesEnum.critical)
                BatteryState.Text = "critical";

            BatteryPct.Text = string.Format("{0:F2}", response.BVolts);

            f = (float)response.BPct / 100;

            Pct.Text = string.Format("{0:P0}", f);

            BluetoothName.Text = response.BlueTooth;

            MainVersion.Text = string.Format("{0}.{1}.{2}", response.Major, response.Minor, response.Revision);

            BootLoader.Text = string.Format("{0}.{1}.{2}", response.BMajor, response.BMinor, response.BRevision);

            BoardVer.Text = string.Format("{0}", response.BoardRevision);

            MAC.Text = response.MAC;

            Processor.Text = response.Processor;

            StatusID.Text = string.Format("{0}", response.StatusID);

            SKU.Text = response.SKU;

            UpTime.Text = string.Format("{0} milliseconds", response.UpTime);

            if (response.MotorFault == true)
                MotorFault.Text = "Fault";
            else
                MotorFault.Text = "No";

            if (Ver != null)
                Version.Text = Ver;

            if (response.MotorStall == true)
            {
                MotorStall.Text = string.Format("index: {0} stall", response.MotorIndex);
            }

            if (response.Ambient_light > 0)
                AmbientLight.Text = string.Format("{0:f2}", response.Ambient_light);

            if (response.LeftTemperature > 0)
                LeftMotor.Text = string.Format("{0:f2}", response.LeftTemperature);

            if (response.RightTemperature > 0)
                RightMotor.Text = string.Format("{0:f2}", response.RightTemperature);

            if (response.Confidence > 0)
            {
                BGetColors.BackColor = System.Drawing.Color.FromArgb(response.Red, response.Green, response.Blue);
                XColor.Text = string.Format("[{0}, {1}, {2}]", response.Red, response.Green, response.Blue);
                response.Confidence = 0;
            }

            AccX.Text = string.Format("{0:f2}", response.SensorX);
            AccY.Text = string.Format("{0:f2}", response.SensorY);
            AccZ.Text = string.Format("{0:f2}", response.SensorZ);
        }

        private void SetAllLEDs(object sender, EventArgs e)
        {
            Commands c = new Commands();
            UInt32[] colors;
            UInt32 ledcolor = 0;
            UInt32 L = 0;

            switch (LEDS.SelectedIndex)
            {
                case 0:
                    L = RvrLedGroups.all_lights;
                    break;
                case 1:
                    L = RvrLedGroups.status_indication_left;
                    break;
                case 2:
                    L = RvrLedGroups.status_indication_right;
                    break;
                case 3:
                    L = RvrLedGroups.headlight_left;
                    break;
                case 4:
                    L = RvrLedGroups.headlight_right;
                    break;
                case 5:
                    L = RvrLedGroups.battery_door_front;
                    break;
                case 6:
                    L = RvrLedGroups.battery_door_rear;
                    break;
                case 7:
                    L = RvrLedGroups.power_button_front;
                    break;
                case 8:
                    L = RvrLedGroups.power_button_rear;
                    break;
                case 9:
                    L = RvrLedGroups.brakelight_left;
                    break;
                case 10:
                    L = RvrLedGroups.brakelight_right;
                    break;
            }

            switch (LEDColor.SelectedIndex)
            {
                case 0:
                    ledcolor = Colors.red;
                    break;
                case 1:
                    ledcolor = Colors.green;
                    break;
                case 2:
                    ledcolor = Colors.blue;
                    break;
                case 3:
                    ledcolor = Colors.white;
                    break;
                case 4:
                    ledcolor = Colors.yellow;
                    break;
                case 5:
                    ledcolor = Colors.purple;
                    break;
                case 6:
                    ledcolor = Colors.orange;
                    break;
                case 7:
                    ledcolor = Colors.pink;
                    break;
                case 8:
                    ledcolor = Colors.off;
                    break;
            }

            if (L == RvrLedGroups.all_lights)
                colors = new UInt32[10];
            else
                colors = new UInt32[1];

            for (int i = 0; i < colors.Length; i++)
                colors[i] = ledcolor;

            Message x = c.set_all_leds(L, colors);

            Send(x);
        }

        private async void DoVersion(object sender, EventArgs e)
        {
            HttpClient c = new HttpClient();
            Sphero Sp;

            byte[] m = await c.GetByteArrayAsync("https://cms-api-production.platform.sphero.com/api/v1/products/rvr/content_packs/nordic_mainapp_ota/versions/published");

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Sphero));
            MemoryStream S = new MemoryStream(m);
            Sp = (Sphero)js.ReadObject(S);
            Ver = Sp.versions[0];
            if (RVR.ActiveForm != null)
                RVR.ActiveForm.Invalidate();
        }

        private void DoResetYaw(object sender, EventArgs e)
        {
            Commands c = new Commands();

            Message x = c.reset_yaw();

            Send(x);
        }

        private void DoRawMotors(object sender, EventArgs e)
        {
            Commands c = new Commands();

            Message x = c.raw_motors(RawMotorModesEnum.forward, 64, RawMotorModesEnum.forward, 64);

            Send(x);

            Thread.Sleep(1000);

            x = c.raw_motors(RawMotorModesEnum.forward, 0, RawMotorModesEnum.forward, 0);
            Send(x);

            Thread.Sleep(1000);

            x = c.raw_motors(RawMotorModesEnum.reverse, 64, RawMotorModesEnum.reverse, 64);
            Send(x);

            x = c.raw_motors(RawMotorModesEnum.forward, 0, RawMotorModesEnum.forward, 0);
            Send(x);
        }

        private void DoDrive(object sender, EventArgs e)
        {
            Commands c = new Commands();

            short h = short.Parse(Heading.Text);

            Message x = c.drive_with_heading(64, h, DriveFlagsBitmask.none);

            Send(x);

            System.Threading.Thread.Sleep(1000);

            x = c.drive_with_heading(0, 0, DriveFlagsBitmask.none);

            Send(x);
        }

        private void DoMotorStall(object sender, EventArgs e)
        {
            Commands c = new Commands();

            Message x = c.enable_motor_stall_notify(true);

            Send(x);
        }

        private void DoMotorFaultN(object sender, EventArgs e)
        {
            Commands c = new Commands();

            Message x = c.enable_motor_fault_notify(true);

            Send(x);
        }

        private void DoMotorFault(object sender, EventArgs e)
        {
            Commands c = new Commands();

            Message x = c.get_motor_fault_state();
            Send(x);
        }

        private void DoAmbient(object sender, EventArgs e)
        {
            Commands c = new Commands();

            Message x = c.get_ambient_light_sensor_value();

            Send(x);
        }

        private void DoMotorTemp(object sender, EventArgs e)
        {
            Commands c = new Commands();

            Message x = c.get_motor_temperature(MotorIndexesEnum.left_motor_index+3);
            Send(x);

            x = c.get_motor_temperature(MotorIndexesEnum.right_motor_index+3);

            Send(x);
        }

        private void DoColors(object sender, EventArgs e)
        {
            Commands c = new Commands();

            Message x = c.enable_color_detection(true);
            Send(x);

            x = c.enable_color_detection_notify(true, 5000, 0);
            Send(x);

            System.Threading.Thread.Sleep(1000);

            x = c.get_current_detected_color_reading();
            Send(x);

            System.Threading.Thread.Sleep(500);

            x = c.enable_color_detection_notify(false, 0, 0);
            Send(x);

            x = c.enable_color_detection(false);
            Send(x);
        }

        private void DoStreaming(object sender, EventArgs e)
        {
            Commands c = new Commands();
            RvrStreamingServices s = new RvrStreamingServices();
            Message x;

            response.Sensor = Streaming.SelectedIndex;

            switch (Streaming.SelectedIndex)
            {

                case 0:
                    x = c.configure_streaming_service(s.quaternion.Token, s.quaternion.Packet(), s.quaternion.Processor);
                    SensorLabel.Text = "Quaternion";
                    break;
                case 1:
                    x = c.configure_streaming_service(s.imu.Token, s.imu.Packet(), s.imu.Processor);
                    SensorLabel.Text = "IMU";
                    break;
                case 2:
                    x = c.configure_streaming_service(s.accelerometer.Token, s.accelerometer.Packet(), s.accelerometer.Processor);
                    SensorLabel.Text = "Accelerometer";
                    break;
                case 3:
                    x = c.configure_streaming_service(s.color_detection.Token, s.color_detection.Packet(), s.color_detection.Processor);
                    SensorLabel.Text = "Color";
                    break;
                case 4:
                    x = c.configure_streaming_service(s.gyroscope.Token, s.gyroscope.Packet(), s.gyroscope.Processor);
                    SensorLabel.Text = "Gyroscope";
                    break;
                case 5:
                    x = c.configure_streaming_service(s.locator.Token, s.locator.Packet(), s.locator.Processor);
                    SensorLabel.Text = "Locator";
                    break;
                case 6:
                    x = c.configure_streaming_service(s.velocity.Token, s.velocity.Packet(), s.velocity.Processor);
                    SensorLabel.Text = "Velocity";
                    break;
                case 7:
                    x = c.configure_streaming_service(s.speed.Token, s.speed.Packet(), s.speed.Processor);
                    SensorLabel.Text = "Speed";
                    break;
                case 8:
                    x = c.configure_streaming_service(s.core_time_1.Token, s.core_time_1.Packet(), s.core_time_1.Processor);
                    SensorLabel.Text = "Core Time";
                    break;
                case 9:
                    x = c.configure_streaming_service(s.ambient_light.Token, s.ambient_light.Packet(), s.ambient_light.Processor);
                    SensorLabel.Text = "Ambient Light";
                    break;
                default:
                    x = null;
                    SensorLabel.Text = "N/A";
                    break;
            }

            Send(x);

            x = c.enable_color_detection(true);
            Send(x);

            x = c.start_streaming_service(900, SpheroRvrTargets.primary);
            Send(x);
            x = c.start_streaming_service(900, SpheroRvrTargets.secondary);
            Send(x);

            System.Threading.Thread.Sleep(1000);

            x = c.clear_streaming_service(SpheroRvrTargets.secondary);
            Send(x);
            x = c.clear_streaming_service(SpheroRvrTargets.primary);
            Send(x);

            x = c.enable_color_detection(false);
            Send(x);
        }

        private void DoComPort(object sender, EventArgs e)
        {
            if (Serial.IsOpen)
                Serial.Close();
            Serial.PortName = ComPort.Text;
            Serial.Open();
        }

        private void UpdatePorts(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            ComPort.Items.Clear();

            if (ports.Length > 0)
                ComPort.Items.AddRange(ports);
        }
    }

    public class Sphero
    {
        public string[] versions;
    }
}
