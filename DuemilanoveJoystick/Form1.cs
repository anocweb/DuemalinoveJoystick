using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

// Don't forget to add this
using vJoyInterfaceWrap;

namespace DuemilanoveJoystick
{
    public partial class Form1 : Form
    {

        // Declaring one joystick (Device id 1) and a position structure. 
        static public vJoy joystick;
        static public vJoy.JoystickState iReport;
        static public uint id = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void serialConnect_Click(object sender, EventArgs e)
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

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            if (serialPort1.IsOpen)
            {
                serialConnect.Enabled = false;
                serialDisconnect.Enabled = true;
                list_SerialPorts.Enabled = false;
                serialBaud.Enabled = false;
                

                // Create one joystick object and a position structure.
                joystick = new vJoy();
                iReport = new vJoy.JoystickState();

                // Get the driver attributes (Vendor ID, Product ID, Version Number)
                if (!joystick.vJoyEnabled())
                {
                    vjoy_status.Text = "vJoy driver not enabled";

                }
                else
                {
                    vjoy_status.Text = joystick.GetVJDStatus(id).ToString();
                    vjoy_vendor.Text = joystick.GetvJoyManufacturerString();
                    vjoy_product.Text = joystick.GetvJoyProductString();
                    vjoy_version.Text = joystick.GetvJoySerialNumberString();
                }

                axis_e_x.Text = joystick.GetVJDAxisExist(id, HID_USAGES.HID_USAGE_X).ToString();
                axis_e_y.Text = joystick.GetVJDAxisExist(id, HID_USAGES.HID_USAGE_Y).ToString();
                axis_e_rx.Text = joystick.GetVJDAxisExist(id, HID_USAGES.HID_USAGE_RX).ToString();
                axis_e_ry.Text = joystick.GetVJDAxisExist(id, HID_USAGES.HID_USAGE_RY).ToString();
                axis_e_rz.Text = joystick.GetVJDAxisExist(id, HID_USAGES.HID_USAGE_RZ).ToString();
                axis_e_s1.Text = joystick.GetVJDAxisExist(id, HID_USAGES.HID_USAGE_SL0).ToString();
                axis_e_s2.Text = joystick.GetVJDAxisExist(id, HID_USAGES.HID_USAGE_SL1).ToString();
                button_e.Text = joystick.GetVJDButtonNumber(id).ToString();
                cpov_e.Text = joystick.GetVJDContPovNumber(id).ToString();
                dpov_e.Text = joystick.GetVJDDiscPovNumber(id).ToString();

                UInt32 DllVer = 0, DrvVer = 0;
                bool match = joystick.DriverMatch(ref DllVer, ref DrvVer);
                if (match)
                {
                    vjoy_dllver.Text = DllVer.ToString();
                    vjoy_drvver.Text = DrvVer.ToString();
                }
                else
                    vjoy_status.Text = "DLL MISMATCH";


                // Acquire the target
                if ((vjoy_status.Text == VjdStat.VJD_STAT_OWN.ToString()) || ((vjoy_status.Text == VjdStat.VJD_STAT_FREE.ToString()) && (!joystick.AcquireVJD(id))))
                {
                    vjoy_status.Text = "Failed to acquire vJoy device";
                    return;
                }
                else
                    vjoy_status.Text = "Acquired: vJoy device";


                joystick.ResetVJD(id);
            }
        }






        private void serialDisconnect_Click(object sender, EventArgs e)
        {
            serialDisconnect.Enabled = false;
            serialConnect.Enabled = true;
            serialPort1.Close();
            if (serialPort1.IsOpen == false)
            {
                serialConnect.Enabled = true;
                serialDisconnect.Enabled = false;
                list_SerialPorts.Enabled = true;
                serialBaud.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error disconnecting");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comRefresh();

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

            }

        }


        private void si_DataReceived(string data)
        {
            string serialDataPre = data.Trim();
            textBox1.Text = serialDataPre;
            int[] serialData = Array.ConvertAll(serialDataPre.Split(','), int.Parse);


            if (serialData.Length == 5)
            {

                // set min/max on X

                if (int.Parse(X_Min.Text) > serialData[3])
                {
                    X_Min.Text = serialData[3].ToString();
                    X_Bar.Minimum = serialData[3];
                }
                if (int.Parse(X_Max.Text) < serialData[3])
                {
                    X_Max.Text = serialData[3].ToString();
                    X_Bar.Maximum = serialData[3];
                }

                // set min/max on Y

                if (int.Parse(Y_Min.Text) > serialData[2])
                {
                    Y_Min.Text = serialData[2].ToString();
                    Y_Bar.Minimum = serialData[2];
                }
                if (int.Parse(Y_Max.Text) < serialData[2])
                {
                    Y_Bar.Maximum =
                    Y_Bar.Maximum = serialData[2];
                    Y_Max.Text = Y_Bar.Maximum.ToString();
                }

                // set min/max on RX

                if (int.Parse(RX_Min.Text) > serialData[1])
                {
                    RX_Min.Text = serialData[1].ToString();
                    RX_Bar.Minimum = serialData[1];
                }
                if (int.Parse(RX_Max.Text) < serialData[1])
                {
                    RX_Max.Text = serialData[1].ToString();
                    RX_Bar.Maximum = serialData[1];
                }

                // set min/max on RY

                if (int.Parse(RY_Min.Text) > serialData[0])
                {
                    RY_Min.Text = serialData[0].ToString();
                    RY_Bar.Minimum = serialData[0];
                }
                if (int.Parse(RY_Max.Text) < serialData[0])
                {
                    RY_Max.Text = serialData[0].ToString();
                    RY_Bar.Maximum = serialData[0];
                }
                // set min/max on RZ

                if (int.Parse(RZ_Min.Text) > serialData[4])
                {
                    RZ_Min.Text = serialData[4].ToString();
                    RZ_Bar.Minimum = serialData[4];
                }
                if (int.Parse(RZ_Max.Text) < serialData[4])
                {
                    RZ_Max.Text = serialData[4].ToString();
                    RZ_Bar.Maximum = serialData[4];
                }


                // Set the Values

                if (X_Bar.Maximum >= serialData[3] && serialData[3] >= X_Bar.Minimum)
                {
                    X_Bar.Value = serialData[3];

                    if (X_Inv.Checked)
                    {
                        X_Bar.Value = (X_Bar.Maximum - serialData[3]) + X_Bar.Minimum;
                    }
                    X_Val.Text = X_Bar.Value.ToString();
                }

                if (Y_Bar.Maximum >= serialData[2] && serialData[2] >= Y_Bar.Minimum)
                {
                    Y_Bar.Value = serialData[2];
                    if (Y_Inv.Checked)
                    {
                        Y_Bar.Value = (Y_Bar.Maximum - serialData[2]) + Y_Bar.Minimum;
                    }
                    Y_Val.Text = Y_Bar.Value.ToString();
                }

                if (RX_Bar.Maximum >= serialData[1] && serialData[1] >= RX_Bar.Minimum)
                {
                    RX_Bar.Value = serialData[1];
                    if (RX_Inv.Checked)
                    {
                        RX_Bar.Value = (RX_Bar.Maximum - serialData[1]) + RX_Bar.Minimum;
                    }
                    RX_Val.Text = RX_Bar.Value.ToString();
                }

                if (RY_Bar.Maximum >= serialData[0] && serialData[0] >= RY_Bar.Minimum)
                {
                    RY_Bar.Value = serialData[0];
                    if (RY_Inv.Checked)
                    {
                        RY_Bar.Value = (RY_Bar.Maximum - serialData[0]) + RY_Bar.Minimum;
                    }
                    RY_Val.Text = RY_Bar.Value.ToString();
                }

                if (RZ_Bar.Maximum >= serialData[4] && serialData[4] >= RZ_Bar.Minimum)
                {
                    RZ_Bar.Value = serialData[4];
                    if (RZ_Inv.Checked)
                    {
                        RZ_Bar.Value = (RZ_Bar.Maximum - serialData[4]) + RZ_Bar.Minimum;
                    }
                    RZ_Val.Text = RZ_Bar.Value.ToString();
                }

            } // end check for 5 vars


            // Setting joystick values

            bool res;
            int val;
            int scaleH = 32767 - 163;
            int scaleL = 0 + 163;


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


        }


        public static int ConvertRange(int originalStart, int originalEnd, int newStart, int newEnd, int value)
        {
            double scale = (double)(newEnd - newStart) / (originalEnd - originalStart);
            return (int)(newStart + ((value - originalStart) * scale));
        }

        private void comListRefresh_Click(object sender, EventArgs e)
        {
            comRefresh();
            
        }

        public void comRefresh()
        {
            string[] ports = SerialPort.GetPortNames();
            list_SerialPorts.Items.Clear();
            if (ports.Length == 0)
            {
                list_SerialPorts.Text = "No Ports";
                list_SerialPorts.Enabled = false;
            }
            else
                list_SerialPorts.Items.AddRange(ports);
            list_SerialPorts.Enabled = true;
            list_SerialPorts.SelectedIndex = 0;
            {

            }
        }

    }



    }

