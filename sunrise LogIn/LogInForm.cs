using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sunrise_LogIn
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        private void BtnEnter(object sender, EventArgs e)
        {
            MessageBox.Show($" Welcome Maam/Sir {textDisplay.Text}, you have been booked. ");

            if (textDisplay.Text == "Mariel" && textPin_Code.Text == "1234")
            {
                MainForm mainform = new MainForm();
                mainform.UserName = "Mariel";
                mainform.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserName or PIN", "LogIn Failed",MessageBoxButtons.OK ,MessageBoxIcon.Error);
                textDisplay.Clear();
                textPin_Code.Clear();
                textDisplay.Focus();
            }
        }
    }
}
