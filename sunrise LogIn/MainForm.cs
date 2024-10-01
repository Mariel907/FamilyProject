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
    public partial class MainForm : Form
    {
        public string UserName {  set { LblUserName.Text = value; } }
        public MainForm()
        {
            InitializeComponent();
        }
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
