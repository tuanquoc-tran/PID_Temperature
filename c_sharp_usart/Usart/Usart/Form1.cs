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
using ZedGraph;

namespace Usart
{
    public partial class frmMain : Form
    {
        int tickStart = 0;
        double time=0, timetam=0, timecount=0;
        double Temp;
        double set_Temp=25;

        bool OpenSerial=false;
        public frmMain()
        {
            InitializeComponent();
        }
        // Tìm cổng com trên máy tính
        private void getAvailablePort()
        {
            string[] ports = SerialPort.GetPortNames();
            cbmCom.Items.AddRange(ports);
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(OpenSerial==false)
            {
                try
                {
                    if (cbmCom.Text == "" || cbmBaud.Text == "")
                    {
                        MessageBox.Show("Check Port and Baud");
                    }
                    else
                    {
                        OpenSerial = true;
                        Connect();
                    }
                }
                catch
                {

                }
            }
            else
            {
                OpenSerial = false;
                Disconnect();
            }
        }
        private void Start_Serial()
        {
            serialPort1.PortName = cbmCom.Text;
            serialPort1.BaudRate = int.Parse(cbmBaud.Text);
            serialPort1.Open();
        }
        private void End_Serial()
        {
            serialPort1.Close();
        }
        private void Connect()
        {
            btnConnect.Text = "DISCONNECT";
            Start_Serial();
            txtSetPoint.Enabled = true;
            btnSendSetPoint.Enabled = true;
            btnConnect.BackColor = Color.Red;

            TimerGraph.Enabled = true;
            tickStart = Environment.TickCount;

        }
        private void Disconnect()
        {
            txtSetPoint.Text = 25 + "";
            set_Temp = Convert.ToDouble(txtSetPoint.Text);
            if (OpenSerial==true)
            {
                serialPort1.Write(txtSetPoint.Text + "s");
            }
           
            btnConnect.Text = "CONNECT";
            End_Serial();
            txtSetPoint.Enabled = false;
            btnSendSetPoint.Enabled = false;
            TimerGraph.Enabled = false;
            btnConnect.BackColor = Color.Green;
            
        }
   
        private void btnSendSetPoint_Click(object sender, EventArgs e)
        {
            set_Temp = Convert.ToDouble(txtSetPoint.Text);
            serialPort1.Write(txtSetPoint.Text+"s");
            
        }

        string InputData = String.Empty;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                InputData = serialPort1.ReadLine();
                if (InputData != String.Empty)
                {
                    this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            getAvailablePort();
            if (OpenSerial == false)
            {
                Disconnect();
            }
            ZedGraph_Initialize();
        }

        private void ZedGraph_Initialize()
        {
            GraphPane TempPane = GraphTemp.GraphPane;

            TempPane.Title.FontSpec.Size = 12;
            TempPane.XAxis.Title.FontSpec.Size = 11;
            TempPane.YAxis.Title.FontSpec.Size = 11;
            TempPane.Title.Text = "Temperature Graph";
            TempPane.XAxis.Title.Text = "Time (s)";
            TempPane.YAxis.Title.Text = "Temperature (oC)";
            TempPane.XAxis.MajorGrid.IsVisible = true;
            TempPane.YAxis.MajorGrid.IsVisible = true;
            TempPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(139, 195, 74), 45.0f);
            TempPane.Fill = new Fill(Color.White, Color.White, 45.0f);

            RollingPointPairList list1 = new RollingPointPairList(60000);
            RollingPointPairList list2 = new RollingPointPairList(60000);

            LineItem curve1 = TempPane.AddCurve("Set Temperature", list1, Color.Red, SymbolType.None);
            LineItem curve2 = TempPane.AddCurve("Temperature", list2, Color.Blue, SymbolType.None);

            TimerGraph.Interval = 10;
            TempPane.XAxis.Scale.Min = 0;
            TempPane.XAxis.Scale.Max = 180;

            TempPane.YAxis.Scale.Min = 20;
            TempPane.YAxis.Scale.Max = 50;

            TempPane.XAxis.Scale.MinorStep = 1;
            TempPane.XAxis.Scale.MajorStep = 5;
            GraphTemp.AxisChange();
        }

        private void TimerGraph_Tick(object sender, EventArgs e)
        {
            ZedGraph_Draw();
        }

        private void ZedGraph_Draw()
        {
            if (GraphTemp.GraphPane.CurveList.Count <= 0) return;

            LineItem curve1 = GraphTemp.GraphPane.CurveList[0] as LineItem;
            LineItem curve2 = GraphTemp.GraphPane.CurveList[1] as LineItem;

            if (curve1 == null) return;
            if (curve2 == null) return;

            IPointListEdit list1 = curve1.Points as IPointListEdit;
            IPointListEdit list2 = curve2.Points as IPointListEdit;

            if (list1 == null) return;
            if (list2 == null) return;
            timecount = -timetam + Environment.TickCount;

            time = (timecount - tickStart) / 1000.0;

            list1.Add(time, set_Temp);
            list2.Add(time, Temp);

            GraphTemp.AxisChange();
            GraphTemp.Invalidate();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msg;
            msg = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                serialPort1.Close();
                e.Cancel = false;
            }
            else e.Cancel = true;
        }

        delegate void SetTextCallback(string text);
        private void SetText(string data)
        {

            try
            {
                data = data.Trim();
                string strCheck = data.Substring(0, 1);
                string strData = data.Substring(1);

                switch (strCheck)
                {
                    case "T":
                        txtSenSor.Text = strData;
                        Temp = Convert.ToDouble(strData);
                        break;
                      
                }
            }
            catch 
            {
              
            }
        }

        private void txtSetPoint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSendSetPoint_Click(this, new EventArgs());
            }
        }

        private void btnSendSetPoint_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TimerGraph.Stop();
            txtSetPoint.Text = 25 + "";
            set_Temp = Convert.ToDouble(txtSetPoint.Text);
            GraphTemp.GraphPane.CurveList.Clear();
            GraphTemp.GraphPane.GraphObjList.Clear();
            if(OpenSerial==true)
            {
                serialPort1.Write(txtSetPoint.Text + "s");
            }
            ZedGraph_Initialize();
            tickStart = 0;
            time = 0;
            timecount = 0;
            timetam = Environment.TickCount ;
            TimerGraph.Start();

        }
    }
}
