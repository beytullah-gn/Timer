using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label4.Text);
            if(progressBar2.Value < 100)
            {
            progressBar2.Value += 10;
                a -= 1;
                label4.Text = Convert.ToString(a);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            progressBar2.Value = 0;
            label4.Text = "10";
            timer1.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
