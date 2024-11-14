using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Project
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            timer1.Interval = 100;
            timer1.Start();
      
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                lblLoadingPercent.Text = Convert.ToString(progressBar1.Value) + " %";            
            }
            else
            {
                timer1.Stop();
                Home home = new Home();
                home.Show();
                this.Hide();
            }
        }
    }
}
