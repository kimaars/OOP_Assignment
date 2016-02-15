using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Ass
{
    public partial class Form1 : Form
    {
        double timeLeftSampling = 1.5;
        double timeLeftLogging = 49.0;
        int counter;
        int maxSid = 7;
        string[] sTxt = new string[7];
        private Sensor[] sObj;

        public Form1()
        {
            InitializeComponent();
            // Create an array of sensor objects
            sObj = new Sensor[maxSid];
            for (counter = 0; counter < maxSid; counter++)
            {
                sObj[counter] = new Sensor(counter);
            }


            




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

            tmrSampling.Start();
           

        }

        private void txtSensor_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void btnLogging_Click(object sender, EventArgs e)
        {

            tmrLogging.Start();
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
                tmrSampling.Stop();
                txtSampling.Text = "Next Sample" ;
                for (counter = 0; counter < maxSid; counter++)
                {
                    sTxt[counter] = sObj[counter].GetValue().ToString("F3");
                }
                txtSensor.Lines = sTxt;
                btnSampling.Enabled = true;
                timeLeftSampling = 1.5;


            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeftLogging > 0)
            {
                timeLeftLogging = timeLeftLogging - 0.1;
                txtLogging.Text = timeLeftLogging.ToString();
                
            }
            else
            {
                tmrLogging.Stop();
                txtLogging.Text = "0";
            }
        }
    }
}

