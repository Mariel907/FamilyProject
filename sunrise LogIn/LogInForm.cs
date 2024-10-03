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

            if (textDisplay.Text == "Mariel" && textPin_Code.Text == "1234")
            {
                MessageBox.Show($" Welcome Maam/Sir {textDisplay.Text}, you have been booked. ");
                MainForm mainform = new MainForm();
                mainform.UserName = "Mariel";
                mainform.Show();

                this.Hide();
            }
            else if (textDisplay.Text == string.Empty || textPin_Code.Text == string.Empty)
            {
                MessageBox.Show("UserName or PIN is empty", "LogIn Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDisplay.Clear();
                textPin_Code.Clear();
                textDisplay.Focus();
            }
            else 
            {
                MessageBox.Show("Invalid UserName or PIN", "LogIn Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDisplay.Clear();
                textPin_Code.Clear();
                textDisplay.Focus();
            }
        }
        private void BtnSign_Up_Click(object sender, EventArgs e)
        {
            BookIn bookin = new BookIn();
            bookin.Show();
            this.Hide();
        }
         private void OnClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
