using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace ModelMotorDC
{
    public partial class MainForm : Form
    {
        int tickStart;
        double kecepatan, PWM;

        RollingPointPairList list1 = new RollingPointPairList(1200);


        System.Reflection.PropertyInfo list1item = null;
        CurveItem list1curve;

        public MainForm()
        {
            InitializeComponent();
        }

        private void timerMotor_Tick(object sender, EventArgs e)
        {
            try
            { PWM = Convert.ToInt16(textBoxInput.Text); }
            catch { }
            kecepatan = 0.9 * kecepatan + 0.1 * PWM;
            textBoxOutput.Text = kecepatan.ToString();
            try { setKurvaGrafik(1, kecepatan); } catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init_zedGraph();
        }

        private void inputPWM(double data)
        {
            textBoxInput.Text = data.ToString();
        }

        private double outputKecepatan()
        {
            return Convert.ToDouble(textBoxOutput.Text);
        }

        private void init_zedGraph()
        {
            zedGraphControl.Visible = true;
            GraphPane myPaneAcc = zedGraphControl.GraphPane;

            myPaneAcc.Title.FontSpec.Size = 20.0f;


            myPaneAcc.Title.Text = "Data Rekam Kecepatan Motor";

            myPaneAcc.XAxis.Title.Text = "Time, Seconds";
            myPaneAcc.YAxis.Title.Text = "Kecepatan, Persen";

            LineItem curve1 = myPaneAcc.AddCurve("n1", list1, Color.Blue, SymbolType.None);
            curve1.Line.Width = 3.0f;

            myPaneAcc.XAxis.Scale.Min = 0;
            myPaneAcc.XAxis.Scale.MinorStep = 1;
            myPaneAcc.XAxis.Scale.MajorStep = 5;
            zedGraphControl.AxisChange();
            tickStart = Environment.TickCount;
        }

        private void setKurvaGrafik(byte node, double dataGrafik)
        {
            if (zedGraphControl.GraphPane.CurveList.Count <= 0)
                return;

            double time = (Environment.TickCount - tickStart) / 1000.0;

            LineItem curve1 = zedGraphControl.GraphPane.CurveList[0] as LineItem;
            if (curve1 == null)
                return;
            IPointListEdit list1 = curve1.Points as IPointListEdit;
            if (list1 == null)
                return;
            list1.Add(time, Convert.ToDouble(dataGrafik));

            Scale xScale = zedGraphControl.GraphPane.XAxis.Scale;

            if (time > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = time + xScale.MajorStep;
                xScale.Min = xScale.Max - 30.0;
            }
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }


    }
}
