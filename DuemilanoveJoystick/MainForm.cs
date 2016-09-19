using System;
using System.Windows.Forms;
using System.IO.Ports;
using vJoyInterfaceWrap;

namespace DuemilanoveJoystick
{
    public partial class MainForm : Form
    {

        // Declaring one joystick (Device id 1) and a position structure. 
        static public vJoy ujoyStick;
        static public vJoy.JoystickState iReport;
        static public uint uJoyId = 1;
        public long joyMin = 0;
        public long joyMax = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void serialConnect_Click(object sender, EventArgs e)
        {
            if (serialConnect.Text == "Connect")
            {
                serialPort1.BaudRate = int.Parse(serialBaud.Text);
                serialPort1.PortName = list_SerialPorts.SelectedItem.ToString();
                serialPort1.NewLine = "\n";
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                try
                {
                    serialPort1.Open();
                    timer1.Enabled = true;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                if (serialPort1.IsOpen)
                {
                    list_SerialPorts.Enabled = false;
                    serialBaud.Enabled = false;


                    // Create one joystick object and a position structure.
                    
                    axis_e_x.Text = ujoyStick.GetVJDAxisExist(uJoyId, HID_USAGES.HID_USAGE_X).ToString();
                    axis_e_y.Text = ujoyStick.GetVJDAxisExist(uJoyId, HID_USAGES.HID_USAGE_Y).ToString();
                    axis_e_rx.Text = ujoyStick.GetVJDAxisExist(uJoyId, HID_USAGES.HID_USAGE_RX).ToString();
                    axis_e_ry.Text = ujoyStick.GetVJDAxisExist(uJoyId, HID_USAGES.HID_USAGE_RY).ToString();
                    axis_e_rz.Text = ujoyStick.GetVJDAxisExist(uJoyId, HID_USAGES.HID_USAGE_RZ).ToString();
                    axis_e_s1.Text = ujoyStick.GetVJDAxisExist(uJoyId, HID_USAGES.HID_USAGE_SL0).ToString();
                    axis_e_s2.Text = ujoyStick.GetVJDAxisExist(uJoyId, HID_USAGES.HID_USAGE_SL1).ToString();
                    button_e.Text = ujoyStick.GetVJDButtonNumber(uJoyId).ToString();
                    cpov_e.Text = ujoyStick.GetVJDContPovNumber(uJoyId).ToString();
                    dpov_e.Text = ujoyStick.GetVJDDiscPovNumber(uJoyId).ToString();

                    ujoyStick.GetVJDAxisMax(uJoyId, HID_USAGES.HID_USAGE_X, ref joyMax);
                    ujoyStick.GetVJDAxisMin(uJoyId, HID_USAGES.HID_USAGE_X, ref joyMin);
                    MessageBox.Show("Min:" + joyMin.ToString() + ", Max:" + joyMax.ToString());


                        // Acquire the target
                        if ((vjoy_status.Text == VjdStat.VJD_STAT_OWN.ToString()) || ((vjoy_status.Text == VjdStat.VJD_STAT_FREE.ToString()) && (!ujoyStick.AcquireVJD(uJoyId))))
                    {
                        vjoy_status.Text = "Failed to acquire vJoy device";
                        Console.WriteLine(vjoy_status.Text);
                        return;
                    }
                    else
                    {
                        vjoy_status.Text = "Acquired: vJoy device";
                        Console.WriteLine(vjoy_status.Text);
                    }


                    ujoyStick.ResetVJD(uJoyId);
                    serialConnect.Text = "Disconnect";
                }
            } else
            {
                serialConnect.Enabled = true;
                serialPort1.Close();
                if (serialPort1.IsOpen == false)
                {
                    timer1.Enabled = false;
                    serialConnect.Enabled = true;
                    list_SerialPorts.Enabled = true;
                    serialBaud.Enabled = true;
                    serialConnect.Text = "Connect";
                }
                else
                {
                    MessageBox.Show("Error disconnecting");
                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize vJoy
            ujoyStick = new vJoy();

            // Get the driver attributes (Vendor ID, Product ID, Version Number)
            if (!ujoyStick.vJoyEnabled())
            {
                vjoy_status.Text = "vJoy driver not enabled";
                Application.Exit();
                Console.WriteLine(vjoy_status.Text);
            }
            
            vjoy_status.Text = ujoyStick.GetVJDStatus(uJoyId).ToString();
            vjoy_vendor.Text = ujoyStick.GetvJoyManufacturerString();
            vjoy_product.Text = ujoyStick.GetvJoyProductString();
            vjoy_version.Text = ujoyStick.GetvJoySerialNumberString();

            UInt32 DllVer = 0, DrvVer = 0;
            bool match = ujoyStick.DriverMatch(ref DllVer, ref DrvVer);
            if (match)
            {
                vjoy_dllver.Text = DllVer.ToString();
                vjoy_drvver.Text = DrvVer.ToString();
                Console.WriteLine("DLL: " + vjoy_dllver.Text);
                Console.WriteLine("DRV: " + vjoy_drvver.Text);
            }
            else
            {
                vjoy_status.Text = "DLL MISMATCH";
                Console.WriteLine(vjoy_status.Text);
            }

            comRefresh();
            fillListView(new string[] { "Throttle", "Rudder", "Aileron", "Elevator", "Gear", "Aux 1" },new int[] { 0,0,1,1,0,0});
        }
        
        private delegate void SetTextDeleg(string text);
        
        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)

        {
            try
            {
                if (serialPort1.IsOpen)
                {

                    string data = serialPort1.ReadLine();

                    // Invokes the delegate on the UI thread, and sends the data that was received to the invoked method.

                    // ---- The "si_DataReceived" method will be executed on the UI thread which allows populating of the textbox.
                    
                    this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data
    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private int MAP(int inMin, int inMax, int outMin, int outMax, int input)
        {
            if (input > inMax || input < inMin)
                return -1;

            if (outMax == 1 && outMin == 0)
            {
                int d = inMin + ((inMax - inMin) / 2);
                if (input > d)
                    return 1;
                else
                    return 0;
            }

            return (input - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
        }
        private long LMAP(long inMin, long inMax, long outMin, long outMax, long input)
        {
            if (input > inMax || input < inMin)
                return -1;

            if (outMax == 1 && outMin == 0)
            {
                long d = inMin + ((inMax - inMin) / 2);
                if (input > d)
                    return 1;
                else
                    return 0;
            }

            return (input - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
        }


        private void si_DataReceived(string data)
        {
            string serialDataPre = data.Trim();
            textBox1.Text = serialDataPre;

            int[] serialData = Array.ConvertAll(serialDataPre.Split(','), int.Parse);
            //int[] serialData = { 0, 0 };
            if (serialData.Length == 6)
            {
                int c = 0;
                int il = 0;
                int ih = 101;
                foreach(int line in serialData)
                {
                    listView1.Items[c].SubItems[2].Text = line.ToString();
                    if (listView1.Items[c].Checked == true)
                    {
                        il = 101;
                        ih = 0;
                    }
                    if (c == 0)
                    {
                        lineJoyY1.Top = MAP(1100, 1900, il, ih, line);
                        ujoyStick.SetAxis(MAP(1100, 1900, (int)joyMin, (int)joyMax, line), uJoyId, HID_USAGES.HID_USAGE_X);
                    }
                    if (c == 1)
                    {
                        lineJoyX1.Left = MAP(1100, 1900, il, ih, line);
                        Console.WriteLine("1: " + MAP(1100, 1900, (int)joyMin, (int)joyMax, line).ToString());
                        ujoyStick.SetAxis(MAP(1100, 1900, (int)joyMin, (int)joyMax, line), uJoyId, HID_USAGES.HID_USAGE_RX);
                        ujoyStick.SetAxis(MAP(1100, 1900, (int)joyMin, (int)joyMax, line), uJoyId, HID_USAGES.HID_USAGE_RZ);
                        ujoyStick.SetAxis(MAP(1100, 1900, (int)joyMin, (int)joyMax, line), uJoyId, HID_USAGES.HID_USAGE_SL0);
                        ujoyStick.SetAxis(MAP(1100, 1900, (int)joyMin, (int)joyMax, line), uJoyId, HID_USAGES.HID_USAGE_SL1);
                        ujoyStick.SetAxis(MAP(1100, 1900, (int)joyMin, (int)joyMax, line), uJoyId, HID_USAGES.HID_USAGE_Z);
                    }
                    if (c == 2)
                    {
                        lineJoyY2.Top = MAP(1100, 1900, il, ih, line);
                        ujoyStick.SetAxis(MAP(1100, 1900, (int)joyMin, (int)joyMax, line), uJoyId, HID_USAGES.HID_USAGE_RX);
                    }
                    if (c == 3)
                    {
                        lineJoyX2.Left = MAP(1100, 1900, il, ih, line);
                        ujoyStick.SetAxis(MAP(1100, 1900, (int)joyMin, (int)joyMax, line), uJoyId, HID_USAGES.HID_USAGE_RY);
                    }
                        if (c == 4)
                    {
                        int l = MAP(1100, 1900, 0, 1, line);
                        if (l == 1)
                            lightGear1.Image = Properties.Resources.buttonOpen;
                        else
                            lightGear1.Image = Properties.Resources.buttonClosed;
                        ujoyStick.SetBtn(Convert.ToBoolean(l), uJoyId, 0);
                    }
                    if (c == 5)
                    {
                        int l = MAP(1100, 1900, 0, 1, line);
                        if (l == 1)
                            lightAux1.Image = Properties.Resources.buttonOpen;
                        else
                            lightAux1.Image = Properties.Resources.buttonClosed;
                        ujoyStick.SetBtn(Convert.ToBoolean(l), uJoyId, 1);
                    }
                    c++;
                }  


                  
            } // end check for 5 vars


            // Setting joystick values

            bool res;
            int val;
            int scaleH = 32767 - 163;
            int scaleL = 0 + 163;
            



            /*
            val = ConvertRange(X_Bar.Minimum, X_Bar.Maximum, scaleL, scaleH, X_Bar.Value);
            res = joystick.SetAxis(val, id, HID_USAGES.HID_USAGE_X);

            val = ConvertRange(Y_Bar.Minimum, Y_Bar.Maximum, scaleL, scaleH, Y_Bar.Value);
            res = joystick.SetAxis(Y_Bar.Value * val, id, HID_USAGES.HID_USAGE_Y);

            val = ConvertRange(RX_Bar.Minimum, RX_Bar.Maximum, scaleL, scaleH, RX_Bar.Value);
            res = joystick.SetAxis(RX_Bar.Value * val, id, HID_USAGES.HID_USAGE_RX);

            val = ConvertRange(RY_Bar.Minimum, RY_Bar.Maximum, scaleL, scaleH, RY_Bar.Value);
            res = joystick.SetAxis(RY_Bar.Value * val, id, HID_USAGES.HID_USAGE_RY);

            val = ConvertRange(RZ_Bar.Minimum, RZ_Bar.Maximum, scaleL, scaleH, RZ_Bar.Value);
            res = joystick.SetAxis(RZ_Bar.Value * val, id, HID_USAGES.HID_USAGE_RZ);
            */

        }

        public static int ConvertRange(int originalStart, int originalEnd, int newStart, int newEnd, int value)
        {
            double scale = (double)(newEnd - newStart) / (originalEnd - originalStart);
            return (int)(newStart + ((value - originalStart) * scale));
        }

        public void comRefresh()
        {
            string text = "";

            if (list_SerialPorts.Items.Count > 1)
            {
                int item = list_SerialPorts.SelectedIndex;
                text = list_SerialPorts.Items[item].ToString();
            }

            string[] ports = SerialPort.GetPortNames();
            list_SerialPorts.Items.Clear();
            if (ports.Length == 0)
            {
                timer1.Interval = 1000;
                list_SerialPorts.Items.Add("No Ports");
                list_SerialPorts.SelectedIndex = 0;
                serialBaud.Text = "";
                list_SerialPorts.Enabled = false;
                serialBaud.Enabled = false;
                serialConnect.Enabled = false;
            }
            else
            {
                timer1.Interval = 15000;
                list_SerialPorts.Items.Add("Ports...");
                list_SerialPorts.Items.AddRange(ports);
                list_SerialPorts.SelectedIndex = 0;
                if (list_SerialPorts.Items.Contains(text))
                list_SerialPorts.SelectedIndex = list_SerialPorts.Items.IndexOf(text);
                serialBaud.Text = "9600";
                list_SerialPorts.Enabled = true;
                serialBaud.Enabled = true;
                serialConnect.Enabled = true;
            }
        }

        public void fillListView(string[] names, int[] inverse = null)
        {
            listView1.Items.Clear();
            int c = 0;
            foreach (string item in names)
            {
                ListViewItem i = new ListViewItem(new string[] { "", item, "nul", "nul", "nul" });
                if (inverse[c] == 1)
                    i.Checked = true;
                listView1.Items.Add(i);
                c++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer1: Tick! Check for com port change");
            comRefresh();
        }

        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Width == 450)
                this.Width = 1037;
            else
                this.Width = 450;
        }

        private void openGamePad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32.exe", "shell32.dll,Control_RunDLL joy.cpl");
        }
    }



    }

