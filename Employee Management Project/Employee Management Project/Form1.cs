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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxPower.ImageLocation = Application.StartupPath + "\\power.png";
            pictureBoxPower.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPower.BackColor = Color.Transparent;
        }

        private void pictureBoxPower_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtboxUsername.Text == "" || txtboxPassword.Text == "")
            {
                lblInvalid.Text = "Invalid Username or Password";
            }
            else
            {
                lblInvalid.Text = "";
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                this.Hide();
            }
        }
    }
}
