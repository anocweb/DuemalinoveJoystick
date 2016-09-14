namespace DuemilanoveJoystick
{
    partial class Form1
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
            this.RZ_Max = new System.Windows.Forms.Label();
            this.RY_Max = new System.Windows.Forms.Label();
            this.RX_Max = new System.Windows.Forms.Label();
            this.Y_Max = new System.Windows.Forms.Label();
            this.X_Max = new System.Windows.Forms.Label();
            this.RZ_Min = new System.Windows.Forms.Label();
            this.RY_Min = new System.Windows.Forms.Label();
            this.RX_Min = new System.Windows.Forms.Label();
            this.Y_Min = new System.Windows.Forms.Label();
            this.X_Min = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.RZ_Bar = new System.Windows.Forms.ProgressBar();
            this.Label4 = new System.Windows.Forms.Label();
            this.RY_Bar = new System.Windows.Forms.ProgressBar();
            this.Label3 = new System.Windows.Forms.Label();
            this.RX_Bar = new System.Windows.Forms.ProgressBar();
            this.Label2 = new System.Windows.Forms.Label();
            this.Y_Bar = new System.Windows.Forms.ProgressBar();
            this.Label1 = new System.Windows.Forms.Label();
            this.X_Bar = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.serialBaud = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.X_Inv = new System.Windows.Forms.CheckBox();
            this.Y_Inv = new System.Windows.Forms.CheckBox();
            this.RX_Inv = new System.Windows.Forms.CheckBox();
            this.RY_Inv = new System.Windows.Forms.CheckBox();
            this.RZ_Inv = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RZ_Val = new System.Windows.Forms.Label();
            this.RY_Val = new System.Windows.Forms.Label();
            this.RX_Val = new System.Windows.Forms.Label();
            this.Y_Val = new System.Windows.Forms.Label();
            this.X_Val = new System.Windows.Forms.Label();
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
            this.comListRefresh = new System.Windows.Forms.Button();
            this.list_SerialPorts = new System.Windows.Forms.ComboBox();
            this.S2_Val = new System.Windows.Forms.Label();
            this.S1_Val = new System.Windows.Forms.Label();
            this.S2_Inv = new System.Windows.Forms.CheckBox();
            this.S1_Inv = new System.Windows.Forms.CheckBox();
            this.S2_Max = new System.Windows.Forms.Label();
            this.S1_Max = new System.Windows.Forms.Label();
            this.S2_Min = new System.Windows.Forms.Label();
            this.S1_Min = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.S2_Bar = new System.Windows.Forms.ProgressBar();
            this.label33 = new System.Windows.Forms.Label();
            this.S1_Bar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialConnect
            // 
            this.serialConnect.Location = new System.Drawing.Point(436, 21);
            this.serialConnect.Margin = new System.Windows.Forms.Padding(4);
            this.serialConnect.Name = "serialConnect";
            this.serialConnect.Size = new System.Drawing.Size(109, 28);
            this.serialConnect.TabIndex = 52;
            this.serialConnect.Text = "Connect";
            this.serialConnect.UseVisualStyleBackColor = true;
            this.serialConnect.Click += new System.EventHandler(this.serialConnect_Click);
            // 
            // RZ_Max
            // 
            this.RZ_Max.AutoSize = true;
            this.RZ_Max.Location = new System.Drawing.Point(463, 194);
            this.RZ_Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RZ_Max.Name = "RZ_Max";
            this.RZ_Max.Size = new System.Drawing.Size(40, 17);
            this.RZ_Max.TabIndex = 46;
            this.RZ_Max.Text = "1500";
            // 
            // RY_Max
            // 
            this.RY_Max.AutoSize = true;
            this.RY_Max.Location = new System.Drawing.Point(463, 162);
            this.RY_Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RY_Max.Name = "RY_Max";
            this.RY_Max.Size = new System.Drawing.Size(40, 17);
            this.RY_Max.TabIndex = 45;
            this.RY_Max.Text = "1500";
            // 
            // RX_Max
            // 
            this.RX_Max.AutoSize = true;
            this.RX_Max.Location = new System.Drawing.Point(463, 130);
            this.RX_Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RX_Max.Name = "RX_Max";
            this.RX_Max.Size = new System.Drawing.Size(40, 17);
            this.RX_Max.TabIndex = 44;
            this.RX_Max.Text = "1500";
            // 
            // Y_Max
            // 
            this.Y_Max.AutoSize = true;
            this.Y_Max.Location = new System.Drawing.Point(463, 98);
            this.Y_Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Y_Max.Name = "Y_Max";
            this.Y_Max.Size = new System.Drawing.Size(40, 17);
            this.Y_Max.TabIndex = 43;
            this.Y_Max.Text = "1500";
            // 
            // X_Max
            // 
            this.X_Max.AutoSize = true;
            this.X_Max.Location = new System.Drawing.Point(463, 66);
            this.X_Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.X_Max.Name = "X_Max";
            this.X_Max.Size = new System.Drawing.Size(40, 17);
            this.X_Max.TabIndex = 42;
            this.X_Max.Text = "1500";
            // 
            // RZ_Min
            // 
            this.RZ_Min.AutoSize = true;
            this.RZ_Min.Location = new System.Drawing.Point(402, 194);
            this.RZ_Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RZ_Min.Name = "RZ_Min";
            this.RZ_Min.Size = new System.Drawing.Size(40, 17);
            this.RZ_Min.TabIndex = 41;
            this.RZ_Min.Text = "1500";
            // 
            // RY_Min
            // 
            this.RY_Min.AutoSize = true;
            this.RY_Min.Location = new System.Drawing.Point(402, 162);
            this.RY_Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RY_Min.Name = "RY_Min";
            this.RY_Min.Size = new System.Drawing.Size(40, 17);
            this.RY_Min.TabIndex = 40;
            this.RY_Min.Text = "1500";
            // 
            // RX_Min
            // 
            this.RX_Min.AutoSize = true;
            this.RX_Min.Location = new System.Drawing.Point(402, 130);
            this.RX_Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RX_Min.Name = "RX_Min";
            this.RX_Min.Size = new System.Drawing.Size(40, 17);
            this.RX_Min.TabIndex = 39;
            this.RX_Min.Text = "1500";
            // 
            // Y_Min
            // 
            this.Y_Min.AutoSize = true;
            this.Y_Min.Location = new System.Drawing.Point(402, 98);
            this.Y_Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Y_Min.Name = "Y_Min";
            this.Y_Min.Size = new System.Drawing.Size(40, 17);
            this.Y_Min.TabIndex = 38;
            this.Y_Min.Text = "1500";
            // 
            // X_Min
            // 
            this.X_Min.AutoSize = true;
            this.X_Min.Location = new System.Drawing.Point(402, 66);
            this.X_Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.X_Min.Name = "X_Min";
            this.X_Min.Size = new System.Drawing.Size(40, 17);
            this.X_Min.TabIndex = 37;
            this.X_Min.Text = "1500";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(16, 194);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(27, 17);
            this.Label5.TabIndex = 36;
            this.Label5.Text = "RZ";
            // 
            // RZ_Bar
            // 
            this.RZ_Bar.Location = new System.Drawing.Point(54, 190);
            this.RZ_Bar.Margin = new System.Windows.Forms.Padding(4);
            this.RZ_Bar.Maximum = 65535;
            this.RZ_Bar.Name = "RZ_Bar";
            this.RZ_Bar.Size = new System.Drawing.Size(267, 25);
            this.RZ_Bar.Step = 1;
            this.RZ_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RZ_Bar.TabIndex = 35;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(16, 162);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(27, 17);
            this.Label4.TabIndex = 34;
            this.Label4.Text = "RY";
            // 
            // RY_Bar
            // 
            this.RY_Bar.Location = new System.Drawing.Point(54, 158);
            this.RY_Bar.Margin = new System.Windows.Forms.Padding(4);
            this.RY_Bar.Maximum = 65535;
            this.RY_Bar.Name = "RY_Bar";
            this.RY_Bar.Size = new System.Drawing.Size(267, 25);
            this.RY_Bar.Step = 1;
            this.RY_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RY_Bar.TabIndex = 33;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(16, 130);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(27, 17);
            this.Label3.TabIndex = 32;
            this.Label3.Text = "RX";
            // 
            // RX_Bar
            // 
            this.RX_Bar.Location = new System.Drawing.Point(54, 126);
            this.RX_Bar.Margin = new System.Windows.Forms.Padding(4);
            this.RX_Bar.Maximum = 65535;
            this.RX_Bar.Name = "RX_Bar";
            this.RX_Bar.Size = new System.Drawing.Size(267, 25);
            this.RX_Bar.Step = 1;
            this.RX_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RX_Bar.TabIndex = 31;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(16, 98);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(17, 17);
            this.Label2.TabIndex = 30;
            this.Label2.Text = "Y";
            // 
            // Y_Bar
            // 
            this.Y_Bar.Location = new System.Drawing.Point(54, 94);
            this.Y_Bar.Margin = new System.Windows.Forms.Padding(4);
            this.Y_Bar.Maximum = 65535;
            this.Y_Bar.Name = "Y_Bar";
            this.Y_Bar.Size = new System.Drawing.Size(267, 25);
            this.Y_Bar.Step = 1;
            this.Y_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Y_Bar.TabIndex = 29;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 66);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(17, 17);
            this.Label1.TabIndex = 28;
            this.Label1.Text = "X";
            // 
            // X_Bar
            // 
            this.X_Bar.Location = new System.Drawing.Point(54, 62);
            this.X_Bar.Margin = new System.Windows.Forms.Padding(4);
            this.X_Bar.Maximum = 65535;
            this.X_Bar.Name = "X_Bar";
            this.X_Bar.Size = new System.Drawing.Size(267, 25);
            this.X_Bar.Step = 1;
            this.X_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.X_Bar.TabIndex = 27;
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
            this.serialBaud.Location = new System.Drawing.Point(268, 25);
            this.serialBaud.Margin = new System.Windows.Forms.Padding(4);
            this.serialBaud.Name = "serialBaud";
            this.serialBaud.Size = new System.Drawing.Size(69, 22);
            this.serialBaud.TabIndex = 57;
            this.serialBaud.Text = "9600";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(185, 27);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 17);
            this.label22.TabIndex = 56;
            this.label22.Text = "Baud Rate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 314);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(525, 22);
            this.textBox1.TabIndex = 58;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(523, 28);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 17);
            this.label23.TabIndex = 61;
            this.label23.Text = "Inv";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(463, 28);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 17);
            this.label24.TabIndex = 60;
            this.label24.Text = "Max";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(402, 28);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 17);
            this.label25.TabIndex = 59;
            this.label25.Text = "Min";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 28);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 17);
            this.label26.TabIndex = 62;
            this.label26.Text = "Name";
            // 
            // X_Inv
            // 
            this.X_Inv.AutoSize = true;
            this.X_Inv.Checked = true;
            this.X_Inv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.X_Inv.Location = new System.Drawing.Point(527, 66);
            this.X_Inv.Margin = new System.Windows.Forms.Padding(4);
            this.X_Inv.Name = "X_Inv";
            this.X_Inv.Size = new System.Drawing.Size(18, 17);
            this.X_Inv.TabIndex = 63;
            this.X_Inv.UseVisualStyleBackColor = true;
            // 
            // Y_Inv
            // 
            this.Y_Inv.AutoSize = true;
            this.Y_Inv.Location = new System.Drawing.Point(527, 97);
            this.Y_Inv.Margin = new System.Windows.Forms.Padding(4);
            this.Y_Inv.Name = "Y_Inv";
            this.Y_Inv.Size = new System.Drawing.Size(18, 17);
            this.Y_Inv.TabIndex = 64;
            this.Y_Inv.UseVisualStyleBackColor = true;
            // 
            // RX_Inv
            // 
            this.RX_Inv.AutoSize = true;
            this.RX_Inv.Checked = true;
            this.RX_Inv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RX_Inv.Location = new System.Drawing.Point(527, 130);
            this.RX_Inv.Margin = new System.Windows.Forms.Padding(4);
            this.RX_Inv.Name = "RX_Inv";
            this.RX_Inv.Size = new System.Drawing.Size(18, 17);
            this.RX_Inv.TabIndex = 65;
            this.RX_Inv.UseVisualStyleBackColor = true;
            // 
            // RY_Inv
            // 
            this.RY_Inv.AutoSize = true;
            this.RY_Inv.Location = new System.Drawing.Point(527, 161);
            this.RY_Inv.Margin = new System.Windows.Forms.Padding(4);
            this.RY_Inv.Name = "RY_Inv";
            this.RY_Inv.Size = new System.Drawing.Size(18, 17);
            this.RY_Inv.TabIndex = 66;
            this.RY_Inv.UseVisualStyleBackColor = true;
            // 
            // RZ_Inv
            // 
            this.RZ_Inv.AutoSize = true;
            this.RZ_Inv.Location = new System.Drawing.Point(527, 193);
            this.RZ_Inv.Margin = new System.Windows.Forms.Padding(4);
            this.RZ_Inv.Name = "RZ_Inv";
            this.RZ_Inv.Size = new System.Drawing.Size(18, 17);
            this.RZ_Inv.TabIndex = 67;
            this.RZ_Inv.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 74;
            this.label6.Text = "Val";
            // 
            // RZ_Val
            // 
            this.RZ_Val.AutoSize = true;
            this.RZ_Val.Location = new System.Drawing.Point(336, 194);
            this.RZ_Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RZ_Val.Name = "RZ_Val";
            this.RZ_Val.Size = new System.Drawing.Size(40, 17);
            this.RZ_Val.TabIndex = 73;
            this.RZ_Val.Text = "1500";
            // 
            // RY_Val
            // 
            this.RY_Val.AutoSize = true;
            this.RY_Val.Location = new System.Drawing.Point(336, 162);
            this.RY_Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RY_Val.Name = "RY_Val";
            this.RY_Val.Size = new System.Drawing.Size(40, 17);
            this.RY_Val.TabIndex = 72;
            this.RY_Val.Text = "1500";
            // 
            // RX_Val
            // 
            this.RX_Val.AutoSize = true;
            this.RX_Val.Location = new System.Drawing.Point(336, 130);
            this.RX_Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RX_Val.Name = "RX_Val";
            this.RX_Val.Size = new System.Drawing.Size(40, 17);
            this.RX_Val.TabIndex = 71;
            this.RX_Val.Text = "1500";
            // 
            // Y_Val
            // 
            this.Y_Val.AutoSize = true;
            this.Y_Val.Location = new System.Drawing.Point(336, 98);
            this.Y_Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Y_Val.Name = "Y_Val";
            this.Y_Val.Size = new System.Drawing.Size(40, 17);
            this.Y_Val.TabIndex = 70;
            this.Y_Val.Text = "1500";
            // 
            // X_Val
            // 
            this.X_Val.AutoSize = true;
            this.X_Val.Location = new System.Drawing.Point(336, 66);
            this.X_Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.X_Val.Name = "X_Val";
            this.X_Val.Size = new System.Drawing.Size(40, 17);
            this.X_Val.TabIndex = 69;
            this.X_Val.Text = "1500";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 28);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 17);
            this.label15.TabIndex = 75;
            this.label15.Text = "vJoy Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 294);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 76;
            this.label7.Text = "Raw Data:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 77;
            this.label8.Text = "vJoy Product:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 78;
            this.label9.Text = "vJoy Version:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 79;
            this.label10.Text = "vJoy Vendor:";
            // 
            // vjoy_product
            // 
            this.vjoy_product.AutoSize = true;
            this.vjoy_product.Location = new System.Drawing.Point(109, 60);
            this.vjoy_product.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vjoy_product.Name = "vjoy_product";
            this.vjoy_product.Size = new System.Drawing.Size(66, 17);
            this.vjoy_product.TabIndex = 80;
            this.vjoy_product.Text = "Unknown";
            // 
            // vjoy_vendor
            // 
            this.vjoy_vendor.AutoSize = true;
            this.vjoy_vendor.Location = new System.Drawing.Point(109, 44);
            this.vjoy_vendor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vjoy_vendor.Name = "vjoy_vendor";
            this.vjoy_vendor.Size = new System.Drawing.Size(66, 17);
            this.vjoy_vendor.TabIndex = 81;
            this.vjoy_vendor.Text = "Unknown";
            // 
            // vjoy_version
            // 
            this.vjoy_version.AutoSize = true;
            this.vjoy_version.Location = new System.Drawing.Point(109, 76);
            this.vjoy_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vjoy_version.Name = "vjoy_version";
            this.vjoy_version.Size = new System.Drawing.Size(66, 17);
            this.vjoy_version.TabIndex = 82;
            this.vjoy_version.Text = "Unknown";
            // 
            // vjoy_status
            // 
            this.vjoy_status.AutoSize = true;
            this.vjoy_status.Location = new System.Drawing.Point(109, 28);
            this.vjoy_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vjoy_status.Name = "vjoy_status";
            this.vjoy_status.Size = new System.Drawing.Size(66, 17);
            this.vjoy_status.TabIndex = 83;
            this.vjoy_status.Text = "Unknown";
            // 
            // dpov_e
            // 
            this.dpov_e.AutoSize = true;
            this.dpov_e.Location = new System.Drawing.Point(473, 60);
            this.dpov_e.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dpov_e.Name = "dpov_e";
            this.dpov_e.Size = new System.Drawing.Size(66, 17);
            this.dpov_e.TabIndex = 89;
            this.dpov_e.Text = "Unknown";
            // 
            // button_e
            // 
            this.button_e.AutoSize = true;
            this.button_e.Location = new System.Drawing.Point(473, 28);
            this.button_e.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button_e.Name = "button_e";
            this.button_e.Size = new System.Drawing.Size(66, 17);
            this.button_e.TabIndex = 88;
            this.button_e.Text = "Unknown";
            // 
            // cpov_e
            // 
            this.cpov_e.AutoSize = true;
            this.cpov_e.Location = new System.Drawing.Point(473, 44);
            this.cpov_e.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpov_e.Name = "cpov_e";
            this.cpov_e.Size = new System.Drawing.Size(66, 17);
            this.cpov_e.TabIndex = 87;
            this.cpov_e.Text = "Unknown";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(371, 28);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 17);
            this.label18.TabIndex = 86;
            this.label18.Text = "vJoy Buttons:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(371, 60);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 17);
            this.label19.TabIndex = 85;
            this.label19.Text = "vJoy D POV:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(371, 44);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 17);
            this.label20.TabIndex = 84;
            this.label20.Text = "vJoy C POV:";
            // 
            // axis_e_x
            // 
            this.axis_e_x.AutoSize = true;
            this.axis_e_x.Location = new System.Drawing.Point(473, 76);
            this.axis_e_x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis_e_x.Name = "axis_e_x";
            this.axis_e_x.Size = new System.Drawing.Size(66, 17);
            this.axis_e_x.TabIndex = 91;
            this.axis_e_x.Text = "Unknown";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(371, 76);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 17);
            this.label28.TabIndex = 90;
            this.label28.Text = "vJoy X Axis:";
            // 
            // axis_e_y
            // 
            this.axis_e_y.AutoSize = true;
            this.axis_e_y.Location = new System.Drawing.Point(473, 92);
            this.axis_e_y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis_e_y.Name = "axis_e_y";
            this.axis_e_y.Size = new System.Drawing.Size(66, 17);
            this.axis_e_y.TabIndex = 93;
            this.axis_e_y.Text = "Unknown";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(371, 92);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 17);
            this.label30.TabIndex = 92;
            this.label30.Text = "vJoy Y Axis:";
            // 
            // axis_e_ry
            // 
            this.axis_e_ry.AutoSize = true;
            this.axis_e_ry.Location = new System.Drawing.Point(473, 124);
            this.axis_e_ry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis_e_ry.Name = "axis_e_ry";
            this.axis_e_ry.Size = new System.Drawing.Size(66, 17);
            this.axis_e_ry.TabIndex = 97;
            this.axis_e_ry.Text = "Unknown";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(371, 124);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(93, 17);
            this.label32.TabIndex = 96;
            this.label32.Text = "vJoy RY Axis:";
            // 
            // axis_e_rx
            // 
            this.axis_e_rx.AutoSize = true;
            this.axis_e_rx.Location = new System.Drawing.Point(473, 108);
            this.axis_e_rx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis_e_rx.Name = "axis_e_rx";
            this.axis_e_rx.Size = new System.Drawing.Size(66, 17);
            this.axis_e_rx.TabIndex = 95;
            this.axis_e_rx.Text = "Unknown";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(371, 108);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(93, 17);
            this.label34.TabIndex = 94;
            this.label34.Text = "vJoy RX Axis:";
            // 
            // axis_e_s1
            // 
            this.axis_e_s1.AutoSize = true;
            this.axis_e_s1.Location = new System.Drawing.Point(473, 156);
            this.axis_e_s1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis_e_s1.Name = "axis_e_s1";
            this.axis_e_s1.Size = new System.Drawing.Size(66, 17);
            this.axis_e_s1.TabIndex = 101;
            this.axis_e_s1.Text = "Unknown";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(371, 156);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(91, 17);
            this.label36.TabIndex = 100;
            this.label36.Text = "vJoy S1 Axis:";
            // 
            // axis_e_rz
            // 
            this.axis_e_rz.AutoSize = true;
            this.axis_e_rz.Location = new System.Drawing.Point(473, 140);
            this.axis_e_rz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis_e_rz.Name = "axis_e_rz";
            this.axis_e_rz.Size = new System.Drawing.Size(66, 17);
            this.axis_e_rz.TabIndex = 99;
            this.axis_e_rz.Text = "Unknown";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(371, 140);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(93, 17);
            this.label38.TabIndex = 98;
            this.label38.Text = "vJoy RZ Axis:";
            // 
            // axis_e_s2
            // 
            this.axis_e_s2.AutoSize = true;
            this.axis_e_s2.Location = new System.Drawing.Point(473, 172);
            this.axis_e_s2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axis_e_s2.Name = "axis_e_s2";
            this.axis_e_s2.Size = new System.Drawing.Size(66, 17);
            this.axis_e_s2.TabIndex = 103;
            this.axis_e_s2.Text = "Unknown";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(371, 172);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(91, 17);
            this.label40.TabIndex = 102;
            this.label40.Text = "vJoy S2 Axis:";
            // 
            // vjoy_drvver
            // 
            this.vjoy_drvver.AutoSize = true;
            this.vjoy_drvver.Location = new System.Drawing.Point(109, 124);
            this.vjoy_drvver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vjoy_drvver.Name = "vjoy_drvver";
            this.vjoy_drvver.Size = new System.Drawing.Size(66, 17);
            this.vjoy_drvver.TabIndex = 107;
            this.vjoy_drvver.Text = "Unknown";
            // 
            // vjoy_dllver
            // 
            this.vjoy_dllver.AutoSize = true;
            this.vjoy_dllver.Location = new System.Drawing.Point(109, 108);
            this.vjoy_dllver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vjoy_dllver.Name = "vjoy_dllver";
            this.vjoy_dllver.Size = new System.Drawing.Size(66, 17);
            this.vjoy_dllver.TabIndex = 106;
            this.vjoy_dllver.Text = "Unknown";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 124);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 105;
            this.label13.Text = "vJoy DrvVer:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 108);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 104;
            this.label14.Text = "vJoy DllVer:";
            // 
            // comListRefresh
            // 
            this.comListRefresh.Location = new System.Drawing.Point(345, 22);
            this.comListRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.comListRefresh.Name = "comListRefresh";
            this.comListRefresh.Size = new System.Drawing.Size(83, 28);
            this.comListRefresh.TabIndex = 108;
            this.comListRefresh.Text = "Refresh";
            this.comListRefresh.UseVisualStyleBackColor = true;
            this.comListRefresh.Click += new System.EventHandler(this.comListRefresh_Click);
            // 
            // list_SerialPorts
            // 
            this.list_SerialPorts.FormattingEnabled = true;
            this.list_SerialPorts.Location = new System.Drawing.Point(88, 24);
            this.list_SerialPorts.Margin = new System.Windows.Forms.Padding(4);
            this.list_SerialPorts.Name = "list_SerialPorts";
            this.list_SerialPorts.Size = new System.Drawing.Size(89, 24);
            this.list_SerialPorts.TabIndex = 109;
            // 
            // S2_Val
            // 
            this.S2_Val.AutoSize = true;
            this.S2_Val.Enabled = false;
            this.S2_Val.Location = new System.Drawing.Point(336, 258);
            this.S2_Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.S2_Val.Name = "S2_Val";
            this.S2_Val.Size = new System.Drawing.Size(40, 17);
            this.S2_Val.TabIndex = 122;
            this.S2_Val.Text = "1500";
            // 
            // S1_Val
            // 
            this.S1_Val.AutoSize = true;
            this.S1_Val.Enabled = false;
            this.S1_Val.Location = new System.Drawing.Point(336, 226);
            this.S1_Val.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.S1_Val.Name = "S1_Val";
            this.S1_Val.Size = new System.Drawing.Size(40, 17);
            this.S1_Val.TabIndex = 121;
            this.S1_Val.Text = "1500";
            // 
            // S2_Inv
            // 
            this.S2_Inv.AutoSize = true;
            this.S2_Inv.Enabled = false;
            this.S2_Inv.Location = new System.Drawing.Point(527, 257);
            this.S2_Inv.Margin = new System.Windows.Forms.Padding(4);
            this.S2_Inv.Name = "S2_Inv";
            this.S2_Inv.Size = new System.Drawing.Size(18, 17);
            this.S2_Inv.TabIndex = 120;
            this.S2_Inv.UseVisualStyleBackColor = true;
            // 
            // S1_Inv
            // 
            this.S1_Inv.AutoSize = true;
            this.S1_Inv.Enabled = false;
            this.S1_Inv.Location = new System.Drawing.Point(527, 225);
            this.S1_Inv.Margin = new System.Windows.Forms.Padding(4);
            this.S1_Inv.Name = "S1_Inv";
            this.S1_Inv.Size = new System.Drawing.Size(18, 17);
            this.S1_Inv.TabIndex = 119;
            this.S1_Inv.UseVisualStyleBackColor = true;
            // 
            // S2_Max
            // 
            this.S2_Max.AutoSize = true;
            this.S2_Max.Enabled = false;
            this.S2_Max.Location = new System.Drawing.Point(463, 258);
            this.S2_Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.S2_Max.Name = "S2_Max";
            this.S2_Max.Size = new System.Drawing.Size(40, 17);
            this.S2_Max.TabIndex = 118;
            this.S2_Max.Text = "1500";
            // 
            // S1_Max
            // 
            this.S1_Max.AutoSize = true;
            this.S1_Max.Enabled = false;
            this.S1_Max.Location = new System.Drawing.Point(463, 226);
            this.S1_Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.S1_Max.Name = "S1_Max";
            this.S1_Max.Size = new System.Drawing.Size(40, 17);
            this.S1_Max.TabIndex = 117;
            this.S1_Max.Text = "1500";
            // 
            // S2_Min
            // 
            this.S2_Min.AutoSize = true;
            this.S2_Min.Enabled = false;
            this.S2_Min.Location = new System.Drawing.Point(402, 258);
            this.S2_Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.S2_Min.Name = "S2_Min";
            this.S2_Min.Size = new System.Drawing.Size(40, 17);
            this.S2_Min.TabIndex = 116;
            this.S2_Min.Text = "1500";
            // 
            // S1_Min
            // 
            this.S1_Min.AutoSize = true;
            this.S1_Min.Enabled = false;
            this.S1_Min.Location = new System.Drawing.Point(402, 226);
            this.S1_Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.S1_Min.Name = "S1_Min";
            this.S1_Min.Size = new System.Drawing.Size(40, 17);
            this.S1_Min.TabIndex = 115;
            this.S1_Min.Text = "1500";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Enabled = false;
            this.label31.Location = new System.Drawing.Point(16, 258);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(25, 17);
            this.label31.TabIndex = 114;
            this.label31.Text = "S2";
            // 
            // S2_Bar
            // 
            this.S2_Bar.Enabled = false;
            this.S2_Bar.Location = new System.Drawing.Point(54, 254);
            this.S2_Bar.Margin = new System.Windows.Forms.Padding(4);
            this.S2_Bar.Maximum = 65535;
            this.S2_Bar.Name = "S2_Bar";
            this.S2_Bar.Size = new System.Drawing.Size(267, 25);
            this.S2_Bar.Step = 1;
            this.S2_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.S2_Bar.TabIndex = 113;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Enabled = false;
            this.label33.Location = new System.Drawing.Point(16, 226);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(25, 17);
            this.label33.TabIndex = 112;
            this.label33.Text = "S1";
            // 
            // S1_Bar
            // 
            this.S1_Bar.Enabled = false;
            this.S1_Bar.Location = new System.Drawing.Point(54, 222);
            this.S1_Bar.Margin = new System.Windows.Forms.Padding(4);
            this.S1_Bar.Maximum = 65535;
            this.S1_Bar.Name = "S1_Bar";
            this.S1_Bar.Size = new System.Drawing.Size(267, 25);
            this.S1_Bar.Step = 1;
            this.S1_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.S1_Bar.TabIndex = 111;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.serialBaud);
            this.groupBox1.Controls.Add(this.comListRefresh);
            this.groupBox1.Controls.Add(this.list_SerialPorts);
            this.groupBox1.Controls.Add(this.serialConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 65);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Connection Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.X_Bar);
            this.groupBox2.Controls.Add(this.S2_Val);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.S1_Val);
            this.groupBox2.Controls.Add(this.Y_Bar);
            this.groupBox2.Controls.Add(this.S2_Inv);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Controls.Add(this.S1_Inv);
            this.groupBox2.Controls.Add(this.RX_Bar);
            this.groupBox2.Controls.Add(this.S2_Max);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.S1_Max);
            this.groupBox2.Controls.Add(this.RY_Bar);
            this.groupBox2.Controls.Add(this.S2_Min);
            this.groupBox2.Controls.Add(this.Label4);
            this.groupBox2.Controls.Add(this.S1_Min);
            this.groupBox2.Controls.Add(this.RZ_Bar);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.Label5);
            this.groupBox2.Controls.Add(this.S2_Bar);
            this.groupBox2.Controls.Add(this.X_Min);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.Y_Min);
            this.groupBox2.Controls.Add(this.S1_Bar);
            this.groupBox2.Controls.Add(this.RX_Min);
            this.groupBox2.Controls.Add(this.RY_Min);
            this.groupBox2.Controls.Add(this.RZ_Min);
            this.groupBox2.Controls.Add(this.X_Max);
            this.groupBox2.Controls.Add(this.Y_Max);
            this.groupBox2.Controls.Add(this.RX_Max);
            this.groupBox2.Controls.Add(this.RY_Max);
            this.groupBox2.Controls.Add(this.RZ_Max);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.X_Inv);
            this.groupBox2.Controls.Add(this.Y_Inv);
            this.groupBox2.Controls.Add(this.RX_Inv);
            this.groupBox2.Controls.Add(this.RY_Inv);
            this.groupBox2.Controls.Add(this.RZ_Inv);
            this.groupBox2.Controls.Add(this.X_Val);
            this.groupBox2.Controls.Add(this.Y_Val);
            this.groupBox2.Controls.Add(this.RX_Val);
            this.groupBox2.Controls.Add(this.RY_Val);
            this.groupBox2.Controls.Add(this.RZ_Val);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 350);
            this.groupBox2.TabIndex = 124;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RC Input";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 199);
            this.groupBox3.TabIndex = 125;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "vJoy Debug Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 651);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Duemalinove Joystick";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button serialConnect;
        internal System.Windows.Forms.Label RZ_Max;
        internal System.Windows.Forms.Label RY_Max;
        internal System.Windows.Forms.Label RX_Max;
        internal System.Windows.Forms.Label Y_Max;
        internal System.Windows.Forms.Label X_Max;
        internal System.Windows.Forms.Label RZ_Min;
        internal System.Windows.Forms.Label RY_Min;
        internal System.Windows.Forms.Label RX_Min;
        internal System.Windows.Forms.Label Y_Min;
        internal System.Windows.Forms.Label X_Min;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ProgressBar RZ_Bar;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ProgressBar RY_Bar;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ProgressBar RX_Bar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ProgressBar Y_Bar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ProgressBar X_Bar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox serialBaud;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox X_Inv;
        private System.Windows.Forms.CheckBox Y_Inv;
        private System.Windows.Forms.CheckBox RX_Inv;
        private System.Windows.Forms.CheckBox RY_Inv;
        private System.Windows.Forms.CheckBox RZ_Inv;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label RZ_Val;
        internal System.Windows.Forms.Label RY_Val;
        internal System.Windows.Forms.Label RX_Val;
        internal System.Windows.Forms.Label Y_Val;
        internal System.Windows.Forms.Label X_Val;
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
        internal System.Windows.Forms.Button comListRefresh;
        private System.Windows.Forms.ComboBox list_SerialPorts;
        internal System.Windows.Forms.Label S2_Val;
        internal System.Windows.Forms.Label S1_Val;
        private System.Windows.Forms.CheckBox S2_Inv;
        private System.Windows.Forms.CheckBox S1_Inv;
        internal System.Windows.Forms.Label S2_Max;
        internal System.Windows.Forms.Label S1_Max;
        internal System.Windows.Forms.Label S2_Min;
        internal System.Windows.Forms.Label S1_Min;
        internal System.Windows.Forms.Label label31;
        internal System.Windows.Forms.ProgressBar S2_Bar;
        internal System.Windows.Forms.Label label33;
        internal System.Windows.Forms.ProgressBar S1_Bar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

