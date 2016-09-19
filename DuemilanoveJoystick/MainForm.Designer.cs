namespace DuemilanoveJoystick
{
    partial class MainForm
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
            this.serialConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.serialBaud = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.vjoy_product = new System.Windows.Forms.Label();
            this.vjoy_vendor = new System.Windows.Forms.Label();
            this.vjoy_version = new System.Windows.Forms.Label();
            this.vjoy_status = new System.Windows.Forms.Label();
            this.dpov_e = new System.Windows.Forms.Label();
            this.button_e = new System.Windows.Forms.Label();
            this.cpov_e = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.axis_e_x = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.axis_e_y = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.axis_e_ry = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.axis_e_rx = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.axis_e_s1 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.axis_e_rz = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.axis_e_s2 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.vjoy_drvver = new System.Windows.Forms.Label();
            this.vjoy_dllver = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.list_SerialPorts = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openGamePad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lightAux1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lineJoyY1 = new System.Windows.Forms.Panel();
            this.lineJoyX1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lightGear1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lineJoyY2 = new System.Windows.Forms.Panel();
            this.lineJoyX2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightAux1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightGear1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialConnect
            // 
            this.serialConnect.Location = new System.Drawing.Point(10, 56);
            this.serialConnect.Margin = new System.Windows.Forms.Padding(4);
            this.serialConnect.Name = "serialConnect";
            this.serialConnect.Size = new System.Drawing.Size(179, 32);
            this.serialConnect.TabIndex = 52;
            this.serialConnect.Text = "Connect";
            this.serialConnect.UseVisualStyleBackColor = true;
            this.serialConnect.Click += new System.EventHandler(this.serialConnect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.ReadBufferSize = 18;
            this.serialPort1.ReceivedBytesThreshold = 17;
            this.serialPort1.WriteBufferSize = 18;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 27);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 17);
            this.label21.TabIndex = 54;
            this.label21.Text = "Serial Port";
            // 
            // serialBaud
            // 
            this.serialBaud.Location = new System.Drawing.Point(306, 25);
            this.serialBaud.Margin = new System.Windows.Forms.Padding(4);
            this.serialBaud.Name = "serialBaud";
            this.serialBaud.Size = new System.Drawing.Size(84, 22);
            this.serialBaud.TabIndex = 57;
            this.serialBaud.Text = "9600";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(223, 27);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 17);
            this.label22.TabIndex = 56;
            this.label22.Text = "Baud Rate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(525, 22);
            this.textBox1.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 98);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 17);
            this.label15.TabIndex = 75;
            this.label15.Text = "vJoy Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 76;
            this.label7.Text = "Raw Serial Data:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 77;
            this.label8.Text = "vJoy Product:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 146);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 78;
            this.label9.Text = "vJoy Version:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 114);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 79;
            this.label10.Text = "vJoy Vendor:";
            // 
            // vjoy_product
            // 
            this.vjoy_product.AutoSize = true;
            this.vjoy_product.Location = new System.Drawing.Point(109, 130);
            this.vjoy_product.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vjoy_product.Name = "vjoy_product";
            this.vjoy_product.Size = new System.Drawing.Size(66, 17);
            this.vjoy_product.TabIndex = 80;
            this.vjoy_product.Text = "Unknown";
            // 
            // vjoy_vendor
            // 
            this.vjoy_vendor.AutoSize = true;
            this.vjoy_vendor.Location = new System.Drawing.Point(109, 114);
            this.vjoy_vendor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vjoy_vendor.Name = "vjoy_vendor";
            this.vjoy_vendor.Size = new System.Drawing.Size(66, 17);
            this.vjoy_vendor.TabIndex = 81;
            this.vjoy_vendor.Text = "Unknown";
            // 
            // vjoy_version
            // 
            this.vjoy_version.AutoSize = true;
            this.vjoy_version.Location = new System.Drawing.Point(109, 146);
            this.vjoy_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vjoy_version.Name = "vjoy_version";
            this.vjoy_version.Size = new System.Drawing.Size(66, 17);
            this.vjoy_version.TabIndex = 82;
            this.vjoy_version.Text = "Unknown";
            // 
            // vjoy_status
            // 
            this.vjoy_status.AutoSize = true;
            this.vjoy_status.Location = new System.Drawing.Point(109, 98);
            this.vjoy_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vjoy_status.Name = "vjoy_status";
            this.vjoy_status.Size = new System.Drawing.Size(66, 17);
            this.vjoy_status.TabIndex = 83;
            this.vjoy_status.Text = "Unknown";
            // 
            // dpov_e
            // 
            this.dpov_e.AutoSize = true;
            this.dpov_e.Location = new System.Drawing.Point(473, 130);
            this.dpov_e.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dpov_e.Name = "dpov_e";
            this.dpov_e.Size = new System.Drawing.Size(66, 17);
            this.dpov_e.TabIndex = 89;
            this.dpov_e.Text = "Unknown";
            // 
            // button_e
            // 
            this.button_e.AutoSize = true;
            this.button_e.Location = new System.Drawing.Point(473, 98);
            this.button_e.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button_e.Name = "button_e";
            this.button_e.Size = new System.Drawing.Size(66, 17);
            this.button_e.TabIndex = 88;
            this.button_e.Text = "Unknown";
            // 
            // cpov_e
            // 
            this.cpov_e.AutoSize = true;
            this.cpov_e.Location = new System.Drawing.Point(473, 114);
            this.cpov_e.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpov_e.Name = "cpov_e";
            this.cpov_e.Size = new System.Drawing.Size(66, 17);
            this.cpov_e.TabIndex = 87;
            this.cpov_e.Text = "Unknown";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(371, 98);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 17);
            this.label18.TabIndex = 86;
            this.label18.Text = "vJoy Buttons:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(371, 130);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 17);
            this.label19.TabIndex = 85;
            this.label19.Text = "vJoy D POV:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(371, 114);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 17);
            this.label20.TabIndex = 84;
            this.label20.Text = "vJoy C POV:";
            // 
            // axis_e_x
            // 
            this.axis_e_x.AutoSize = true;
            this.axis_e_x.Location = new System.Drawing.Point(473, 146);
            this.axis_e_x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis_e_x.Name = "axis_e_x";
            this.axis_e_x.Size = new System.Drawing.Size(66, 17);
            this.axis_e_x.TabIndex = 91;
            this.axis_e_x.Text = "Unknown";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(371, 146);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 17);
            this.label28.TabIndex = 90;
            this.label28.Text = "vJoy X Axis:";
            // 
            // axis_e_y
            // 
            this.axis_e_y.AutoSize = true;
            this.axis_e_y.Location = new System.Drawing.Point(473, 162);
            this.axis_e_y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis_e_y.Name = "axis_e_y";
            this.axis_e_y.Size = new System.Drawing.Size(66, 17);
            this.axis_e_y.TabIndex = 93;
            this.axis_e_y.Text = "Unknown";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(371, 162);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 17);
            this.label30.TabIndex = 92;
            this.label30.Text = "vJoy Y Axis:";
            // 
            // axis_e_ry
            // 
            this.axis_e_ry.AutoSize = true;
            this.axis_e_ry.Location = new System.Drawing.Point(473, 194);
            this.axis_e_ry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis_e_ry.Name = "axis_e_ry";
            this.axis_e_ry.Size = new System.Drawing.Size(66, 17);
            this.axis_e_ry.TabIndex = 97;
            this.axis_e_ry.Text = "Unknown";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(371, 194);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(93, 17);
            this.label32.TabIndex = 96;
            this.label32.Text = "vJoy RY Axis:";
            // 
            // axis_e_rx
            // 
            this.axis_e_rx.AutoSize = true;
            this.axis_e_rx.Location = new System.Drawing.Point(473, 178);
            this.axis_e_rx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis_e_rx.Name = "axis_e_rx";
            this.axis_e_rx.Size = new System.Drawing.Size(66, 17);
            this.axis_e_rx.TabIndex = 95;
            this.axis_e_rx.Text = "Unknown";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(371, 178);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(93, 17);
            this.label34.TabIndex = 94;
            this.label34.Text = "vJoy RX Axis:";
            // 
            // axis_e_s1
            // 
            this.axis_e_s1.AutoSize = true;
            this.axis_e_s1.Location = new System.Drawing.Point(473, 226);
            this.axis_e_s1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis_e_s1.Name = "axis_e_s1";
            this.axis_e_s1.Size = new System.Drawing.Size(66, 17);
            this.axis_e_s1.TabIndex = 101;
            this.axis_e_s1.Text = "Unknown";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(371, 226);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(91, 17);
            this.label36.TabIndex = 100;
            this.label36.Text = "vJoy S1 Axis:";
            // 
            // axis_e_rz
            // 
            this.axis_e_rz.AutoSize = true;
            this.axis_e_rz.Location = new System.Drawing.Point(473, 210);
            this.axis_e_rz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis_e_rz.Name = "axis_e_rz";
            this.axis_e_rz.Size = new System.Drawing.Size(66, 17);
            this.axis_e_rz.TabIndex = 99;
            this.axis_e_rz.Text = "Unknown";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(371, 210);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(93, 17);
            this.label38.TabIndex = 98;
            this.label38.Text = "vJoy RZ Axis:";
            // 
            // axis_e_s2
            // 
            this.axis_e_s2.AutoSize = true;
            this.axis_e_s2.Location = new System.Drawing.Point(473, 242);
            this.axis_e_s2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis_e_s2.Name = "axis_e_s2";
            this.axis_e_s2.Size = new System.Drawing.Size(66, 17);
            this.axis_e_s2.TabIndex = 103;
            this.axis_e_s2.Text = "Unknown";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(371, 242);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(91, 17);
            this.label40.TabIndex = 102;
            this.label40.Text = "vJoy S2 Axis:";
            // 
            // vjoy_drvver
            // 
            this.vjoy_drvver.AutoSize = true;
            this.vjoy_drvver.Location = new System.Drawing.Point(109, 194);
            this.vjoy_drvver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vjoy_drvver.Name = "vjoy_drvver";
            this.vjoy_drvver.Size = new System.Drawing.Size(66, 17);
            this.vjoy_drvver.TabIndex = 107;
            this.vjoy_drvver.Text = "Unknown";
            // 
            // vjoy_dllver
            // 
            this.vjoy_dllver.AutoSize = true;
            this.vjoy_dllver.Location = new System.Drawing.Point(109, 178);
            this.vjoy_dllver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vjoy_dllver.Name = "vjoy_dllver";
            this.vjoy_dllver.Size = new System.Drawing.Size(66, 17);
            this.vjoy_dllver.TabIndex = 106;
            this.vjoy_dllver.Text = "Unknown";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 194);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 105;
            this.label13.Text = "vJoy DrvVer:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 178);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 104;
            this.label14.Text = "vJoy DllVer:";
            // 
            // list_SerialPorts
            // 
            this.list_SerialPorts.FormattingEnabled = true;
            this.list_SerialPorts.Location = new System.Drawing.Point(88, 24);
            this.list_SerialPorts.Margin = new System.Windows.Forms.Padding(4);
            this.list_SerialPorts.Name = "list_SerialPorts";
            this.list_SerialPorts.Size = new System.Drawing.Size(101, 24);
            this.list_SerialPorts.TabIndex = 109;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openGamePad);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.serialBaud);
            this.groupBox1.Controls.Add(this.list_SerialPorts);
            this.groupBox1.Controls.Add(this.serialConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 99);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Settings";
            // 
            // openGamePad
            // 
            this.openGamePad.Location = new System.Drawing.Point(211, 56);
            this.openGamePad.Margin = new System.Windows.Forms.Padding(4);
            this.openGamePad.Name = "openGamePad";
            this.openGamePad.Size = new System.Drawing.Size(179, 32);
            this.openGamePad.TabIndex = 110;
            this.openGamePad.Text = "Gamepad Settings";
            this.openGamePad.UseVisualStyleBackColor = true;
            this.openGamePad.Click += new System.EventHandler(this.openGamePad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.lightAux1);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lightGear1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 325);
            this.groupBox2.TabIndex = 124;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RC Input";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(11, 158);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(379, 149);
            this.listView1.TabIndex = 142;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Inv";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "RC Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Min";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Max";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 75;
            // 
            // lightAux1
            // 
            this.lightAux1.Image = global::DuemilanoveJoystick.Properties.Resources.buttonOpen;
            this.lightAux1.Location = new System.Drawing.Point(331, 84);
            this.lightAux1.Name = "lightAux1";
            this.lightAux1.Size = new System.Drawing.Size(32, 32);
            this.lightAux1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lightAux1.TabIndex = 139;
            this.lightAux1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(278, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 17);
            this.label17.TabIndex = 138;
            this.label17.Text = "Gear";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lineJoyY1);
            this.panel1.Controls.Add(this.lineJoyX1);
            this.panel1.Location = new System.Drawing.Point(31, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 101);
            this.panel1.TabIndex = 127;
            // 
            // lineJoyY1
            // 
            this.lineJoyY1.BackColor = System.Drawing.Color.Black;
            this.lineJoyY1.Location = new System.Drawing.Point(0, 50);
            this.lineJoyY1.Margin = new System.Windows.Forms.Padding(0);
            this.lineJoyY1.Name = "lineJoyY1";
            this.lineJoyY1.Size = new System.Drawing.Size(100, 1);
            this.lineJoyY1.TabIndex = 129;
            // 
            // lineJoyX1
            // 
            this.lineJoyX1.BackColor = System.Drawing.Color.Black;
            this.lineJoyX1.Location = new System.Drawing.Point(50, 0);
            this.lineJoyX1.Margin = new System.Windows.Forms.Padding(0);
            this.lineJoyX1.Name = "lineJoyX1";
            this.lineJoyX1.Size = new System.Drawing.Size(1, 100);
            this.lineJoyX1.TabIndex = 130;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(328, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 17);
            this.label16.TabIndex = 137;
            this.label16.Text = "Aux1";
            // 
            // lightGear1
            // 
            this.lightGear1.Image = global::DuemilanoveJoystick.Properties.Resources.buttonOpen;
            this.lightGear1.Location = new System.Drawing.Point(281, 84);
            this.lightGear1.Name = "lightGear1";
            this.lightGear1.Size = new System.Drawing.Size(32, 32);
            this.lightGear1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lightGear1.TabIndex = 126;
            this.lightGear1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(161, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 130;
            this.label12.Text = "Right Stick";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.lineJoyY2);
            this.panel2.Controls.Add(this.lineJoyX2);
            this.panel2.Location = new System.Drawing.Point(158, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 101);
            this.panel2.TabIndex = 128;
            // 
            // lineJoyY2
            // 
            this.lineJoyY2.BackColor = System.Drawing.Color.Black;
            this.lineJoyY2.Location = new System.Drawing.Point(0, 50);
            this.lineJoyY2.Margin = new System.Windows.Forms.Padding(0);
            this.lineJoyY2.Name = "lineJoyY2";
            this.lineJoyY2.Size = new System.Drawing.Size(100, 1);
            this.lineJoyY2.TabIndex = 131;
            // 
            // lineJoyX2
            // 
            this.lineJoyX2.BackColor = System.Drawing.Color.Black;
            this.lineJoyX2.Location = new System.Drawing.Point(50, 0);
            this.lineJoyX2.Margin = new System.Windows.Forms.Padding(0);
            this.lineJoyX2.Name = "lineJoyX2";
            this.lineJoyX2.Size = new System.Drawing.Size(1, 100);
            this.lineJoyX2.TabIndex = 132;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 129;
            this.label11.Text = "Left Stick";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.vjoy_drvver);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.vjoy_dllver);
            this.groupBox3.Controls.Add(this.vjoy_product);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.vjoy_vendor);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.vjoy_version);
            this.groupBox3.Controls.Add(this.axis_e_s2);
            this.groupBox3.Controls.Add(this.vjoy_status);
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.axis_e_s1);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.axis_e_rz);
            this.groupBox3.Controls.Add(this.cpov_e);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.button_e);
            this.groupBox3.Controls.Add(this.axis_e_ry);
            this.groupBox3.Controls.Add(this.dpov_e);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.axis_e_rx);
            this.groupBox3.Controls.Add(this.axis_e_x);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.axis_e_y);
            this.groupBox3.Location = new System.Drawing.Point(446, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 280);
            this.groupBox3.TabIndex = 125;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Debug Data";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 473);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Duemalinove Joystick";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightAux1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lightGear1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button serialConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox serialBaud;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label vjoy_product;
        private System.Windows.Forms.Label vjoy_vendor;
        private System.Windows.Forms.Label vjoy_version;
        private System.Windows.Forms.Label vjoy_status;
        private System.Windows.Forms.Label dpov_e;
        private System.Windows.Forms.Label button_e;
        private System.Windows.Forms.Label cpov_e;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label axis_e_x;
        internal System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label axis_e_y;
        internal System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label axis_e_ry;
        internal System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label axis_e_rx;
        internal System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label axis_e_s1;
        internal System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label axis_e_rz;
        internal System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label axis_e_s2;
        internal System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label vjoy_drvver;
        private System.Windows.Forms.Label vjoy_dllver;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox list_SerialPorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox lightGear1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel lineJoyY1;
        private System.Windows.Forms.Panel lineJoyX1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel lineJoyY2;
        private System.Windows.Forms.Panel lineJoyX2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox lightAux1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Button openGamePad;
    }
}

