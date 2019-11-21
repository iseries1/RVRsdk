namespace RVR
{
    partial class RVR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.bWake = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.plabel = new System.Windows.Forms.Label();
            this.BatteryPct = new System.Windows.Forms.Label();
            this.LPct = new System.Windows.Forms.Label();
            this.Pct = new System.Windows.Forms.Label();
            this.LState = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.BAllLEDs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BluetoothName = new System.Windows.Forms.Label();
            this.LEDColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MainVersion = new System.Windows.Forms.Label();
            this.BMotorF = new System.Windows.Forms.Button();
            this.LBoardVer = new System.Windows.Forms.Label();
            this.BoardVer = new System.Windows.Forms.Label();
            this.LBootLoader = new System.Windows.Forms.Label();
            this.BootLoader = new System.Windows.Forms.Label();
            this.LMAC = new System.Windows.Forms.Label();
            this.MAC = new System.Windows.Forms.Label();
            this.LProcessor = new System.Windows.Forms.Label();
            this.Processor = new System.Windows.Forms.Label();
            this.LStatus = new System.Windows.Forms.Label();
            this.StatusID = new System.Windows.Forms.Label();
            this.BatteryState = new System.Windows.Forms.Label();
            this.SKU = new System.Windows.Forms.Label();
            this.LSKU = new System.Windows.Forms.Label();
            this.UpTime = new System.Windows.Forms.Label();
            this.LUpTime = new System.Windows.Forms.Label();
            this.LMotorFault = new System.Windows.Forms.Label();
            this.MotorFault = new System.Windows.Forms.Label();
            this.BVersion = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Label();
            this.BResetYaw = new System.Windows.Forms.Button();
            this.BRawMotors = new System.Windows.Forms.Button();
            this.BDrive = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.TextBox();
            this.BMotorStall = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MotorStall = new System.Windows.Forms.Label();
            this.BMotorFault = new System.Windows.Forms.Button();
            this.LEDS = new System.Windows.Forms.ComboBox();
            this.BAmbientLight = new System.Windows.Forms.Button();
            this.AmbientLight = new System.Windows.Forms.Label();
            this.BMotorTemp = new System.Windows.Forms.Button();
            this.LeftMotor = new System.Windows.Forms.Label();
            this.RightMotor = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.BGetColors = new System.Windows.Forms.Button();
            this.XColor = new System.Windows.Forms.Label();
            this.BStreaming = new System.Windows.Forms.Button();
            this.Streaming = new System.Windows.Forms.ComboBox();
            this.AccZ = new System.Windows.Forms.Label();
            this.SensorLabel = new System.Windows.Forms.Label();
            this.AccX = new System.Windows.Forms.Label();
            this.AccY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Serial
            // 
            this.Serial.BaudRate = 115200;
            this.Serial.PortName = "COM3";
            this.Serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.InBound);
            // 
            // bWake
            // 
            this.bWake.Location = new System.Drawing.Point(213, 32);
            this.bWake.Name = "bWake";
            this.bWake.Size = new System.Drawing.Size(75, 23);
            this.bWake.TabIndex = 0;
            this.bWake.Text = "Wake";
            this.bWake.UseVisualStyleBackColor = true;
            this.bWake.Click += new System.EventHandler(this.DoWake);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sleep";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DoSleep);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "RVR Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DoInfo);
            // 
            // plabel
            // 
            this.plabel.AutoSize = true;
            this.plabel.Location = new System.Drawing.Point(25, 101);
            this.plabel.Name = "plabel";
            this.plabel.Size = new System.Drawing.Size(46, 13);
            this.plabel.TabIndex = 3;
            this.plabel.Text = "Voltage:";
            // 
            // BatteryPct
            // 
            this.BatteryPct.AutoSize = true;
            this.BatteryPct.Location = new System.Drawing.Point(96, 101);
            this.BatteryPct.Name = "BatteryPct";
            this.BatteryPct.Size = new System.Drawing.Size(27, 13);
            this.BatteryPct.TabIndex = 4;
            this.BatteryPct.Text = "N/A";
            // 
            // LPct
            // 
            this.LPct.AutoSize = true;
            this.LPct.Location = new System.Drawing.Point(25, 130);
            this.LPct.Name = "LPct";
            this.LPct.Size = new System.Drawing.Size(65, 13);
            this.LPct.TabIndex = 6;
            this.LPct.Text = "Percentage:";
            // 
            // Pct
            // 
            this.Pct.AutoSize = true;
            this.Pct.Location = new System.Drawing.Point(96, 130);
            this.Pct.Name = "Pct";
            this.Pct.Size = new System.Drawing.Size(27, 13);
            this.Pct.TabIndex = 7;
            this.Pct.Text = "N/A";
            // 
            // LState
            // 
            this.LState.AutoSize = true;
            this.LState.Location = new System.Drawing.Point(25, 75);
            this.LState.Name = "LState";
            this.LState.Size = new System.Drawing.Size(55, 13);
            this.LState.TabIndex = 8;
            this.LState.Text = "Rvr State:";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(96, 75);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(27, 13);
            this.State.TabIndex = 9;
            this.State.Text = "N/A";
            // 
            // BAllLEDs
            // 
            this.BAllLEDs.Location = new System.Drawing.Point(163, 125);
            this.BAllLEDs.Name = "BAllLEDs";
            this.BAllLEDs.Size = new System.Drawing.Size(75, 23);
            this.BAllLEDs.TabIndex = 10;
            this.BAllLEDs.Text = "Set LEDs";
            this.BAllLEDs.UseVisualStyleBackColor = true;
            this.BAllLEDs.Click += new System.EventHandler(this.SetAllLEDs);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // BluetoothName
            // 
            this.BluetoothName.AutoSize = true;
            this.BluetoothName.Location = new System.Drawing.Point(96, 159);
            this.BluetoothName.Name = "BluetoothName";
            this.BluetoothName.Size = new System.Drawing.Size(27, 13);
            this.BluetoothName.TabIndex = 13;
            this.BluetoothName.Text = "N/A";
            // 
            // LEDColor
            // 
            this.LEDColor.FormattingEnabled = true;
            this.LEDColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "White",
            "Yellow",
            "Purple",
            "Orange",
            "Pink",
            "Off"});
            this.LEDColor.Location = new System.Drawing.Point(354, 127);
            this.LEDColor.Name = "LEDColor";
            this.LEDColor.Size = new System.Drawing.Size(70, 21);
            this.LEDColor.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Main Version:";
            // 
            // MainVersion
            // 
            this.MainVersion.AutoSize = true;
            this.MainVersion.Location = new System.Drawing.Point(96, 188);
            this.MainVersion.Name = "MainVersion";
            this.MainVersion.Size = new System.Drawing.Size(27, 13);
            this.MainVersion.TabIndex = 17;
            this.MainVersion.Text = "N/A";
            // 
            // BMotorF
            // 
            this.BMotorF.Location = new System.Drawing.Point(441, 70);
            this.BMotorF.Name = "BMotorF";
            this.BMotorF.Size = new System.Drawing.Size(75, 23);
            this.BMotorF.TabIndex = 18;
            this.BMotorF.Text = "Motor Fault";
            this.BMotorF.UseVisualStyleBackColor = true;
            this.BMotorF.Click += new System.EventHandler(this.DoMotorFault);
            // 
            // LBoardVer
            // 
            this.LBoardVer.AutoSize = true;
            this.LBoardVer.Location = new System.Drawing.Point(25, 220);
            this.LBoardVer.Name = "LBoardVer";
            this.LBoardVer.Size = new System.Drawing.Size(57, 13);
            this.LBoardVer.TabIndex = 20;
            this.LBoardVer.Text = "Board Ver:";
            // 
            // BoardVer
            // 
            this.BoardVer.AutoSize = true;
            this.BoardVer.Location = new System.Drawing.Point(96, 220);
            this.BoardVer.Name = "BoardVer";
            this.BoardVer.Size = new System.Drawing.Size(27, 13);
            this.BoardVer.TabIndex = 21;
            this.BoardVer.Text = "N/A";
            // 
            // LBootLoader
            // 
            this.LBootLoader.AutoSize = true;
            this.LBootLoader.Location = new System.Drawing.Point(25, 249);
            this.LBootLoader.Name = "LBootLoader";
            this.LBootLoader.Size = new System.Drawing.Size(68, 13);
            this.LBootLoader.TabIndex = 22;
            this.LBootLoader.Text = "Boot Loader:";
            // 
            // BootLoader
            // 
            this.BootLoader.AutoSize = true;
            this.BootLoader.Location = new System.Drawing.Point(96, 249);
            this.BootLoader.Name = "BootLoader";
            this.BootLoader.Size = new System.Drawing.Size(27, 13);
            this.BootLoader.TabIndex = 23;
            this.BootLoader.Text = "N/A";
            // 
            // LMAC
            // 
            this.LMAC.AutoSize = true;
            this.LMAC.Location = new System.Drawing.Point(25, 278);
            this.LMAC.Name = "LMAC";
            this.LMAC.Size = new System.Drawing.Size(33, 13);
            this.LMAC.TabIndex = 25;
            this.LMAC.Text = "MAC:";
            // 
            // MAC
            // 
            this.MAC.AutoSize = true;
            this.MAC.Location = new System.Drawing.Point(96, 278);
            this.MAC.Name = "MAC";
            this.MAC.Size = new System.Drawing.Size(27, 13);
            this.MAC.TabIndex = 26;
            this.MAC.Text = "N/A";
            // 
            // LProcessor
            // 
            this.LProcessor.AutoSize = true;
            this.LProcessor.Location = new System.Drawing.Point(25, 307);
            this.LProcessor.Name = "LProcessor";
            this.LProcessor.Size = new System.Drawing.Size(57, 13);
            this.LProcessor.TabIndex = 27;
            this.LProcessor.Text = "Processor:";
            // 
            // Processor
            // 
            this.Processor.AutoSize = true;
            this.Processor.Location = new System.Drawing.Point(96, 307);
            this.Processor.Name = "Processor";
            this.Processor.Size = new System.Drawing.Size(27, 13);
            this.Processor.TabIndex = 28;
            this.Processor.Text = "N/A";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Location = new System.Drawing.Point(25, 336);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(51, 13);
            this.LStatus.TabIndex = 29;
            this.LStatus.Text = "StatusID:";
            // 
            // StatusID
            // 
            this.StatusID.AutoSize = true;
            this.StatusID.Location = new System.Drawing.Point(96, 336);
            this.StatusID.Name = "StatusID";
            this.StatusID.Size = new System.Drawing.Size(27, 13);
            this.StatusID.TabIndex = 30;
            this.StatusID.Text = "N/A";
            // 
            // BatteryState
            // 
            this.BatteryState.AutoSize = true;
            this.BatteryState.Location = new System.Drawing.Point(129, 101);
            this.BatteryState.Name = "BatteryState";
            this.BatteryState.Size = new System.Drawing.Size(27, 13);
            this.BatteryState.TabIndex = 31;
            this.BatteryState.Text = "N/A";
            // 
            // SKU
            // 
            this.SKU.AutoSize = true;
            this.SKU.Location = new System.Drawing.Point(96, 362);
            this.SKU.Name = "SKU";
            this.SKU.Size = new System.Drawing.Size(27, 13);
            this.SKU.TabIndex = 33;
            this.SKU.Text = "N/A";
            // 
            // LSKU
            // 
            this.LSKU.AutoSize = true;
            this.LSKU.Location = new System.Drawing.Point(25, 362);
            this.LSKU.Name = "LSKU";
            this.LSKU.Size = new System.Drawing.Size(32, 13);
            this.LSKU.TabIndex = 32;
            this.LSKU.Text = "SKU:";
            // 
            // UpTime
            // 
            this.UpTime.AutoSize = true;
            this.UpTime.Location = new System.Drawing.Point(96, 387);
            this.UpTime.Name = "UpTime";
            this.UpTime.Size = new System.Drawing.Size(27, 13);
            this.UpTime.TabIndex = 35;
            this.UpTime.Text = "N/A";
            // 
            // LUpTime
            // 
            this.LUpTime.AutoSize = true;
            this.LUpTime.Location = new System.Drawing.Point(25, 387);
            this.LUpTime.Name = "LUpTime";
            this.LUpTime.Size = new System.Drawing.Size(50, 13);
            this.LUpTime.TabIndex = 34;
            this.LUpTime.Text = "Up Time:";
            // 
            // LMotorFault
            // 
            this.LMotorFault.AutoSize = true;
            this.LMotorFault.Location = new System.Drawing.Point(535, 77);
            this.LMotorFault.Name = "LMotorFault";
            this.LMotorFault.Size = new System.Drawing.Size(63, 13);
            this.LMotorFault.TabIndex = 41;
            this.LMotorFault.Text = "Motor Fault:";
            // 
            // MotorFault
            // 
            this.MotorFault.AutoSize = true;
            this.MotorFault.Location = new System.Drawing.Point(616, 77);
            this.MotorFault.Name = "MotorFault";
            this.MotorFault.Size = new System.Drawing.Size(27, 13);
            this.MotorFault.TabIndex = 42;
            this.MotorFault.Text = "N/A";
            // 
            // BVersion
            // 
            this.BVersion.Location = new System.Drawing.Point(422, 32);
            this.BVersion.Name = "BVersion";
            this.BVersion.Size = new System.Drawing.Size(104, 23);
            this.BVersion.TabIndex = 43;
            this.BVersion.Text = "Current Version";
            this.BVersion.UseVisualStyleBackColor = true;
            this.BVersion.Click += new System.EventHandler(this.DoVersion);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(571, 37);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(27, 13);
            this.Version.TabIndex = 44;
            this.Version.Text = "N/A";
            // 
            // BResetYaw
            // 
            this.BResetYaw.Location = new System.Drawing.Point(441, 101);
            this.BResetYaw.Name = "BResetYaw";
            this.BResetYaw.Size = new System.Drawing.Size(75, 23);
            this.BResetYaw.TabIndex = 45;
            this.BResetYaw.Text = "Reset Yaw";
            this.BResetYaw.UseVisualStyleBackColor = true;
            this.BResetYaw.Click += new System.EventHandler(this.DoResetYaw);
            // 
            // BRawMotors
            // 
            this.BRawMotors.Location = new System.Drawing.Point(441, 130);
            this.BRawMotors.Name = "BRawMotors";
            this.BRawMotors.Size = new System.Drawing.Size(75, 23);
            this.BRawMotors.TabIndex = 46;
            this.BRawMotors.Text = "Raw Motors";
            this.BRawMotors.UseVisualStyleBackColor = true;
            this.BRawMotors.Click += new System.EventHandler(this.DoRawMotors);
            // 
            // BDrive
            // 
            this.BDrive.Location = new System.Drawing.Point(441, 159);
            this.BDrive.Name = "BDrive";
            this.BDrive.Size = new System.Drawing.Size(75, 23);
            this.BDrive.TabIndex = 47;
            this.BDrive.Text = "Drive";
            this.BDrive.UseVisualStyleBackColor = true;
            this.BDrive.Click += new System.EventHandler(this.DoDrive);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Heading (0-359):";
            // 
            // Heading
            // 
            this.Heading.Location = new System.Drawing.Point(538, 162);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(52, 20);
            this.Heading.TabIndex = 49;
            this.Heading.Text = "0";
            // 
            // BMotorStall
            // 
            this.BMotorStall.Location = new System.Drawing.Point(441, 188);
            this.BMotorStall.Name = "BMotorStall";
            this.BMotorStall.Size = new System.Drawing.Size(75, 23);
            this.BMotorStall.TabIndex = 50;
            this.BMotorStall.Text = "Motor Stall";
            this.BMotorStall.UseVisualStyleBackColor = true;
            this.BMotorStall.Click += new System.EventHandler(this.DoMotorStall);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Motor Stall:";
            // 
            // MotorStall
            // 
            this.MotorStall.AutoSize = true;
            this.MotorStall.Location = new System.Drawing.Point(616, 103);
            this.MotorStall.Name = "MotorStall";
            this.MotorStall.Size = new System.Drawing.Size(27, 13);
            this.MotorStall.TabIndex = 52;
            this.MotorStall.Text = "N/A";
            // 
            // BMotorFault
            // 
            this.BMotorFault.Location = new System.Drawing.Point(441, 220);
            this.BMotorFault.Name = "BMotorFault";
            this.BMotorFault.Size = new System.Drawing.Size(75, 23);
            this.BMotorFault.TabIndex = 53;
            this.BMotorFault.Text = "Motor Fault";
            this.BMotorFault.UseVisualStyleBackColor = true;
            this.BMotorFault.Click += new System.EventHandler(this.DoMotorFaultN);
            // 
            // LEDS
            // 
            this.LEDS.FormattingEnabled = true;
            this.LEDS.Items.AddRange(new object[] {
            "All LEDS",
            "indication left",
            "indication right",
            "headlight left",
            "headlight right",
            "battery door front",
            "battery door rear",
            "power button front",
            "power button rear",
            "brakelight left",
            "brakelight right"});
            this.LEDS.Location = new System.Drawing.Point(244, 127);
            this.LEDS.Name = "LEDS";
            this.LEDS.Size = new System.Drawing.Size(104, 21);
            this.LEDS.TabIndex = 54;
            // 
            // BAmbientLight
            // 
            this.BAmbientLight.Location = new System.Drawing.Point(441, 249);
            this.BAmbientLight.Name = "BAmbientLight";
            this.BAmbientLight.Size = new System.Drawing.Size(75, 42);
            this.BAmbientLight.TabIndex = 55;
            this.BAmbientLight.Text = "Ambient Light";
            this.BAmbientLight.UseVisualStyleBackColor = true;
            this.BAmbientLight.Click += new System.EventHandler(this.DoAmbient);
            // 
            // AmbientLight
            // 
            this.AmbientLight.AutoSize = true;
            this.AmbientLight.Location = new System.Drawing.Point(535, 264);
            this.AmbientLight.Name = "AmbientLight";
            this.AmbientLight.Size = new System.Drawing.Size(27, 13);
            this.AmbientLight.TabIndex = 56;
            this.AmbientLight.Text = "N/A";
            // 
            // BMotorTemp
            // 
            this.BMotorTemp.Location = new System.Drawing.Point(441, 297);
            this.BMotorTemp.Name = "BMotorTemp";
            this.BMotorTemp.Size = new System.Drawing.Size(75, 42);
            this.BMotorTemp.TabIndex = 57;
            this.BMotorTemp.Text = "Motor Temperature";
            this.BMotorTemp.UseVisualStyleBackColor = true;
            this.BMotorTemp.Click += new System.EventHandler(this.DoMotorTemp);
            // 
            // LeftMotor
            // 
            this.LeftMotor.AutoSize = true;
            this.LeftMotor.Location = new System.Drawing.Point(535, 307);
            this.LeftMotor.Name = "LeftMotor";
            this.LeftMotor.Size = new System.Drawing.Size(27, 13);
            this.LeftMotor.TabIndex = 58;
            this.LeftMotor.Text = "N/A";
            // 
            // RightMotor
            // 
            this.RightMotor.AutoSize = true;
            this.RightMotor.Location = new System.Drawing.Point(607, 307);
            this.RightMotor.Name = "RightMotor";
            this.RightMotor.Size = new System.Drawing.Size(27, 13);
            this.RightMotor.TabIndex = 59;
            this.RightMotor.Text = "N/A";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(160, 416);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(27, 13);
            this.Error.TabIndex = 61;
            this.Error.Text = "N/A";
            // 
            // BGetColors
            // 
            this.BGetColors.Location = new System.Drawing.Point(441, 347);
            this.BGetColors.Name = "BGetColors";
            this.BGetColors.Size = new System.Drawing.Size(75, 28);
            this.BGetColors.TabIndex = 62;
            this.BGetColors.Text = "Get Color";
            this.BGetColors.UseVisualStyleBackColor = true;
            this.BGetColors.Click += new System.EventHandler(this.DoColors);
            // 
            // XColor
            // 
            this.XColor.AutoSize = true;
            this.XColor.Location = new System.Drawing.Point(535, 355);
            this.XColor.Name = "XColor";
            this.XColor.Size = new System.Drawing.Size(27, 13);
            this.XColor.TabIndex = 63;
            this.XColor.Text = "N/A";
            // 
            // BStreaming
            // 
            this.BStreaming.Location = new System.Drawing.Point(441, 381);
            this.BStreaming.Name = "BStreaming";
            this.BStreaming.Size = new System.Drawing.Size(75, 48);
            this.BStreaming.TabIndex = 64;
            this.BStreaming.Text = "Start Streaming";
            this.BStreaming.UseVisualStyleBackColor = true;
            this.BStreaming.Click += new System.EventHandler(this.DoStreaming);
            // 
            // Streaming
            // 
            this.Streaming.FormattingEnabled = true;
            this.Streaming.Items.AddRange(new object[] {
            "Quaternion",
            "IMU",
            "Accelerometer",
            "Color",
            "Gyroscope",
            "Locator",
            "Velocity",
            "Speed",
            "Core Time",
            "Ambient Light"});
            this.Streaming.Location = new System.Drawing.Point(538, 384);
            this.Streaming.Name = "Streaming";
            this.Streaming.Size = new System.Drawing.Size(108, 21);
            this.Streaming.TabIndex = 65;
            // 
            // AccZ
            // 
            this.AccZ.AutoSize = true;
            this.AccZ.Location = new System.Drawing.Point(732, 416);
            this.AccZ.Name = "AccZ";
            this.AccZ.Size = new System.Drawing.Size(27, 13);
            this.AccZ.TabIndex = 66;
            this.AccZ.Text = "N/A";
            // 
            // SensorLabel
            // 
            this.SensorLabel.AutoSize = true;
            this.SensorLabel.Location = new System.Drawing.Point(535, 416);
            this.SensorLabel.Name = "SensorLabel";
            this.SensorLabel.Size = new System.Drawing.Size(27, 13);
            this.SensorLabel.TabIndex = 67;
            this.SensorLabel.Text = "N/A";
            // 
            // AccX
            // 
            this.AccX.AutoSize = true;
            this.AccX.Location = new System.Drawing.Point(619, 416);
            this.AccX.Name = "AccX";
            this.AccX.Size = new System.Drawing.Size(27, 13);
            this.AccX.TabIndex = 68;
            this.AccX.Text = "N/A";
            // 
            // AccY
            // 
            this.AccY.AutoSize = true;
            this.AccY.Location = new System.Drawing.Point(678, 416);
            this.AccY.Name = "AccY";
            this.AccY.Size = new System.Drawing.Size(27, 13);
            this.AccY.TabIndex = 69;
            this.AccY.Text = "N/A";
            // 
            // RVR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AccY);
            this.Controls.Add(this.AccX);
            this.Controls.Add(this.SensorLabel);
            this.Controls.Add(this.AccZ);
            this.Controls.Add(this.Streaming);
            this.Controls.Add(this.BStreaming);
            this.Controls.Add(this.XColor);
            this.Controls.Add(this.BGetColors);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.RightMotor);
            this.Controls.Add(this.LeftMotor);
            this.Controls.Add(this.BMotorTemp);
            this.Controls.Add(this.AmbientLight);
            this.Controls.Add(this.BAmbientLight);
            this.Controls.Add(this.LEDS);
            this.Controls.Add(this.BMotorFault);
            this.Controls.Add(this.MotorStall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BMotorStall);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BDrive);
            this.Controls.Add(this.BRawMotors);
            this.Controls.Add(this.BResetYaw);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.BVersion);
            this.Controls.Add(this.MotorFault);
            this.Controls.Add(this.LMotorFault);
            this.Controls.Add(this.UpTime);
            this.Controls.Add(this.LUpTime);
            this.Controls.Add(this.SKU);
            this.Controls.Add(this.LSKU);
            this.Controls.Add(this.BatteryState);
            this.Controls.Add(this.StatusID);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.Processor);
            this.Controls.Add(this.LProcessor);
            this.Controls.Add(this.MAC);
            this.Controls.Add(this.LMAC);
            this.Controls.Add(this.BootLoader);
            this.Controls.Add(this.LBootLoader);
            this.Controls.Add(this.BoardVer);
            this.Controls.Add(this.LBoardVer);
            this.Controls.Add(this.BMotorF);
            this.Controls.Add(this.MainVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LEDColor);
            this.Controls.Add(this.BluetoothName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BAllLEDs);
            this.Controls.Add(this.State);
            this.Controls.Add(this.LState);
            this.Controls.Add(this.Pct);
            this.Controls.Add(this.LPct);
            this.Controls.Add(this.BatteryPct);
            this.Controls.Add(this.plabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bWake);
            this.Name = "RVR";
            this.Text = "RVR";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DoPaint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.Button bWake;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label plabel;
        private System.Windows.Forms.Label BatteryPct;
        private System.Windows.Forms.Label LPct;
        private System.Windows.Forms.Label Pct;
        private System.Windows.Forms.Label LState;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Button BAllLEDs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BluetoothName;
        private System.Windows.Forms.ComboBox LEDColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MainVersion;
        private System.Windows.Forms.Button BMotorF;
        private System.Windows.Forms.Label LBoardVer;
        private System.Windows.Forms.Label BoardVer;
        private System.Windows.Forms.Label LBootLoader;
        private System.Windows.Forms.Label BootLoader;
        private System.Windows.Forms.Label LMAC;
        private System.Windows.Forms.Label MAC;
        private System.Windows.Forms.Label LProcessor;
        private System.Windows.Forms.Label Processor;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label StatusID;
        private System.Windows.Forms.Label BatteryState;
        private System.Windows.Forms.Label SKU;
        private System.Windows.Forms.Label LSKU;
        private System.Windows.Forms.Label UpTime;
        private System.Windows.Forms.Label LUpTime;
        private System.Windows.Forms.Label LMotorFault;
        private System.Windows.Forms.Label MotorFault;
        private System.Windows.Forms.Button BVersion;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Button BResetYaw;
        private System.Windows.Forms.Button BRawMotors;
        private System.Windows.Forms.Button BDrive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Heading;
        private System.Windows.Forms.Button BMotorStall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MotorStall;
        private System.Windows.Forms.Button BMotorFault;
        private System.Windows.Forms.ComboBox LEDS;
        private System.Windows.Forms.Button BAmbientLight;
        private System.Windows.Forms.Label AmbientLight;
        private System.Windows.Forms.Button BMotorTemp;
        private System.Windows.Forms.Label LeftMotor;
        private System.Windows.Forms.Label RightMotor;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Button BGetColors;
        private System.Windows.Forms.Label XColor;
        private System.Windows.Forms.Button BStreaming;
        private System.Windows.Forms.ComboBox Streaming;
        private System.Windows.Forms.Label AccZ;
        private System.Windows.Forms.Label SensorLabel;
        private System.Windows.Forms.Label AccX;
        private System.Windows.Forms.Label AccY;
    }
}

