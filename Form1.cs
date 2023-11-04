using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Diagnostics.Metrics;

namespace WindowsFormsApp_time_231104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            a.Interval = 1000;
            a.Tick += new EventHandler(TimerEventProcessor);
            button_end.Enabled = false;
            button_start.Enabled = true;
        }
        public int seconds = 1, minutes = 0;
        public Timer a=new Timer();
        private void TimerEventProcessor (Object sender, EventArgs e)
        {
            if (seconds < 10 && minutes < 10)
            {
                label1.Text="0"+minutes.ToString()+":0"+seconds.ToString();
            }
            else if (seconds < 10)
            {
                label1.Text=minutes.ToString()+ ":0" + seconds.ToString();
            }
            else if (minutes < 10)
            {
                label1.Text="0"+minutes.ToString()+":"+seconds.ToString();
            }
            seconds++;
            if (seconds == 60)
            {
                minutes++;
                seconds= 0;
            }
        }



        private void button_start_Click(object sender, EventArgs e)
        {
            a.Start();
            button_end.Enabled = true;
            button_start.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seconds=0;
            minutes=0;
            label1.Text = "00:00";
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            a.Stop();
            button_start.Enabled = true;
            button_end.Enabled = false;
            
        }
    }
}
