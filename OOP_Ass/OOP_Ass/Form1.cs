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

namespace OOP_Ass
{
    public partial class Form1 : Form
    {
        double timeLeftSampling = 1.5;
        double timeLeftLogging = 49.0;
        int counter;
        int senAnalog = 5;
        int senDigital = 2;
        string sTxt;
        private Sensor[] sObj;
        int LogCount = 0;
        string filename;

        public Form1()
        {
            InitializeComponent();
           
            sObj = new Sensor[senDigital+senAnalog];
            for (counter = 0; counter < senAnalog+senDigital; counter++)
            {
                sObj[counter] = new Sensor(counter);
            }
            filename = "log.txt";
            lblFileName.Text = filename;
            lblNoLog.Text = LogCount.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSampling_Click(object sender, EventArgs e)
        {
            sTxt = null;
            tmrSampling.Start();
           

        }

        private void txtSensor_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void btnLogging_Click(object sender, EventArgs e)
        {
            LogCount++;
            lblNoLog.Text = LogCount.ToString();
            tmrLogging.Start();
            using (StreamWriter writer = File.AppendText(filename))
            {
                writer.Write(sTxt);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (timeLeftSampling > 0)
            {
                timeLeftSampling = timeLeftSampling - 0.1;
                txtSampling.Text = timeLeftSampling.ToString("F1");
                btnSampling.Enabled = false;
            }
            else
            {
                string time = DateTime.Now.ToLongTimeString();
                string value = null;
                tmrSampling.Stop();
                txtSampling.Text = "Next Sample" ;
                for (int i = 0; i < senAnalog; i++)
                {
                    value = sObj[i].GetValue(false).ToString("F3");
                    value = value.Replace(",", ".");
                    sTxt += sObj[i].GetSenId().ToString() +"," + value +","+time+","+"Analog"+"\r\n";
                }
                for (int j = senAnalog; j < senAnalog+senDigital; j++)
                {
                    sTxt += sObj[j].GetSenId().ToString() + "," + sObj[j].GetValue(true).ToString("F3") + "," + time +"," + "Digital"+"\r\n";
                }

                txtSensor.Text = sTxt;
                btnSampling.Enabled = true;
                timeLeftSampling = 1.5;
  


            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeftLogging > 0)
            {
                timeLeftLogging = timeLeftLogging - 0.1;
                txtLogging.Text = timeLeftLogging.ToString("F1");
                btnLogging.Enabled = false;
                
            }
            else
            {
                tmrLogging.Stop();
                btnLogging.Enabled = true;
                txtLogging.Text = "Next Logging";
                timeLeftLogging = 49.0;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtLogCount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a DAQ Simulator ","About", System.Windows.Forms.MessageBoxButtons.OK);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void lblLogPath_Click(object sender, EventArgs e)
        {

        }

        private void lblNoLog_Click(object sender, EventArgs e)
        {

        }
    }
}

