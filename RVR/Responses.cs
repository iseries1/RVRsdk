using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVR
{
    public class Responses
    {
        private Message m;

        public byte Error;
        public int BPct = 0;
        public float BVolts = 0;
        public bool sleeping = true;
        public byte BatteryState = 0;
        public bool BatteryChanged = false;
        public float Current = 0;
        public float BatteryCritical = 0;
        public float BatteryLow = 0;
        public float BatteryNormal = 0;
        public string BlueTooth;
        public int Major;
        public int Minor;
        public int Revision;
        public int BMajor;
        public int BMinor;
        public int BRevision;
        public byte BoardRevision;
        public string MAC;
        public int StatusID;
        public string Processor;
        public string SKU;
        public UInt64 UpTime;
        public byte MotorIndex;
        public bool MotorStall = false;
        public bool MotorFault = false;
        public bool GyroMax = false;
        public int InfaredReading = 0;
        public int RedChannel;
        public int BlueChannel;
        public int GreenChannel;
        public int ClearChannel;
        public byte InfaredCode;
        public float Ambient_light;
        public byte Red;
        public byte Green;
        public byte Blue;
        public byte Confidence;
        public byte ColorClassification;
        public byte Token;
        public byte[] SensorData;
        public float CoalTemperature;
        public float CaseTemperature;
        public float RightTemperature;
        public float LeftTemperature;
        public byte RightStatus;
        public byte LeftStatus;

        public void doResponses(byte[] data, int size)
        {

            byte[] b = new byte[size];
            for (int i = 0; i < b.Length; i++)
                b[i] = data[i];

            m = new Message(b);

            Error = m.err();

            if (m.did() == DevicesEnum.connection)
                DoConnection();
            if (m.did() == DevicesEnum.power)
                DoPower();
            if (m.did() == DevicesEnum.system_info)
                DoSystem();
            if (m.did() == DevicesEnum.drive)
                DoDrive();
            if (m.did() == DevicesEnum.sensor)
                DoSensors();
            if (m.did() == DevicesEnum.io)
                DoIO();

            if (RVR.ActiveForm != null)
                RVR.ActiveForm.Invalidate();
        }

        private void DoConnection()
        {
            switch (m.cid())
            {
                case CommandsEnum.get_bluetooth_advertising_name:
                    BlueTooth = m.unpack_string();
                    break;
            }
        }

        private void DoPower()
        {
            switch (m.cid())
            {
                case CommandsEnum.get_battery_percentage:
                    BPct = (int)m.unpack_byte();
                    break;
                case CommandsEnum.will_sleep_notify:
                    break;
                case CommandsEnum.did_sleep_notify:
                    sleeping = true;
                    break;
                case CommandsEnum.battery_voltage_state_change_notify:
                    BatteryChanged = m.unpack_bool();
                    break;
                case CommandsEnum.did_awake_notify:
                    sleeping = false;
                    break;
                case CommandsEnum.get_battery_voltage_state:
                    BatteryState = m.unpack_byte();
                    break;
                case CommandsEnum.get_battery_voltage_in_volts:
                    BVolts = m.unpack_float();
                    break;
                case CommandsEnum.get_battery_voltage_state_thresholds:
                    BatteryCritical = m.unpack_float();
                    BatteryLow = m.unpack_float();
                    BatteryNormal = m.unpack_float();
                    break;
                case CommandsEnum.get_current_sense_amplifier_current:
                    Current = m.unpack_float();
                    break;
            }
        }

        private void DoSystem()
        {
            switch (m.cid())
            {
                case CommandsEnum.get_main_application_version:
                    Major = m.unpack_int16();
                    Minor = m.unpack_int16();
                    Revision = m.unpack_int16();
                    break;
                case CommandsEnum.get_bootloader_version:
                    BMajor = m.unpack_int16();
                    BMinor = m.unpack_int16();
                    BRevision = m.unpack_int16();
                    break;
                case CommandsEnum.get_board_revision:
                    BoardRevision = m.unpack_byte();
                    break;
                case CommandsEnum.get_mac_address:
                    MAC = m.unpack_string();
                    break;
                case CommandsEnum.get_stats_id:
                    StatusID = m.unpack_int16();
                    break;
                case CommandsEnum.get_processor_name:
                    Processor = m.unpack_string();
                    break;
                case CommandsEnum.get_sku:
                    SKU = m.unpack_string();
                    break;
                case CommandsEnum.get_core_up_time_in_milliseconds:
                    UpTime = m.unpack_uint64();
                    break;
            }
        }

        private void DoDrive()
        {
            switch (m.cid())
            {
                case CommandsEnum.motor_stall_notify:
                    MotorIndex = m.unpack_byte();
                    MotorStall = m.unpack_bool();
                    break;
                case CommandsEnum.motor_fault_notify:
                    MotorFault = m.unpack_bool();
                    break;
                case CommandsEnum.get_motor_fault_state:
                    MotorFault = m.unpack_bool();
                    break;
            }
        }

        private void DoIO()
        {
            switch (m.cid())
            {
                case CommandsEnum.get_color_identification_report:
                    Confidence = m.unpack_byte();
                    break;
            }
        }

        private void DoSensors()
        {
            switch (m.cid())
            {
                case CommandsEnum.gyro_max_notify:
                    GyroMax = m.unpack_bool();
                    break;
                case CommandsEnum.get_bot_to_bot_infrared_readings:
                    InfaredReading = m.unpack_int32();
                    break;
                case CommandsEnum.get_rgbc_sensor_values:
                    RedChannel = m.unpack_int16();
                    GreenChannel = m.unpack_int16();
                    BlueChannel = m.unpack_int16();
                    ClearChannel = m.unpack_int16();
                    break;
                case CommandsEnum.robot_to_robot_infrared_message_received_notify:
                    InfaredCode = m.unpack_byte();
                    break;
                case CommandsEnum.get_ambient_light_sensor_value:
                    Ambient_light = m.unpack_float();
                    break;
                case CommandsEnum.color_detection_notify:
                    Red = m.unpack_byte();
                    Green = m.unpack_byte();
                    Blue = m.unpack_byte();
                    Confidence = m.unpack_byte();
                    ColorClassification = m.unpack_byte();
                    break;
                case CommandsEnum.streaming_service_data_notify:
                    Token = m.unpack_byte();
                    SensorData = m.unpack_bytes();
                    break;
                case CommandsEnum.get_motor_temperature:
                    CoalTemperature = m.unpack_float();
                    CaseTemperature = m.unpack_float();
                    break;
                case CommandsEnum.get_motor_thermal_protection_status:
                    LeftTemperature = m.unpack_float();
                    LeftStatus = m.unpack_byte();
                    RightTemperature = m.unpack_float();
                    RightStatus = m.unpack_byte();
                    break;
                case CommandsEnum.motor_thermal_protection_status_notify:
                    LeftTemperature = m.unpack_float();
                    LeftStatus = m.unpack_byte();
                    RightTemperature = m.unpack_float();
                    RightStatus = m.unpack_byte();
                    break;
                default:
                    break;
            }
        }
    }
}
