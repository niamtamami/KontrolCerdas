using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace KarakteristikMotor
{
    public partial class Form1 : Form
    {
        int rpm;
        StreamWriter fileSimpan;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = "COM"+ textBoxCOM.Text;
                serialPort.BaudRate = 9600;
                serialPort.ReceivedBytesThreshold = 1;
                serialPort.RtsEnable = true;
                serialPort.Open();
            }
            catch
            {
                MessageBox.Show("serial port error");
            }


        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            rpm = serialPort.ReadChar();
            this.BeginInvoke(new EventHandler(parseData));
        }

        private void parseData(object sender, EventArgs e)
        {
            String dataSimpan;
            textBoxKecepatan.Text = rpm.ToString();
            dataSimpan = String.Format("1," + textBoxPWM.Text + ", " + rpm.ToString());
            fileSimpan.WriteLine(dataSimpan);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            byte data;
            data = Convert.ToByte(textBoxPWM.Text);
            serialPort.Write(new byte[] {data}, 0, 1);
        }

        private void buttonKurang_Click(object sender, EventArgs e)
        {
            int tempdata;
            tempdata = Convert.ToInt16(textBoxPWM.Text);
            tempdata = tempdata - 1;
            if (tempdata < 0) tempdata = 0;
            textBoxPWM.Text = tempdata.ToString();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            int tempdata;
            tempdata = Convert.ToInt16(textBoxPWM.Text);
            tempdata = tempdata - 1;
            if (tempdata > 100) tempdata = 100;
            textBoxPWM.Text = tempdata.ToString();

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            
            fileSimpan.Close();
            serialPort.Close();
        }

        private void buttonRekam_Click(object sender, EventArgs e)
        {
            try
            {
                fileSimpan = new StreamWriter("data.csv");
                fileSimpan.WriteLine("Waktu, PWM, Kecepatan");
            }
            catch
            {
                MessageBox.Show("IO File error");
            }
        }
    }
}
