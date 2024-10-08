using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum, operatr;
        bool enterValue = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            if (result != 0) btnEqual.PerformClick();
            else result = Double.Parse(textDisplay.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if (textDisplay.Text != "0")
            {
                textPreview.Text = fstNum = result + " " + operation;
                textDisplay.Text = string.Empty;
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            secNum = textDisplay.Text;
             
            textPreview.Text = $"{textPreview.Text} {secNum} = ";
            if (textDisplay.Text != string.Empty)
            {
                if (textDisplay.Text == "0") textPreview.Text = string.Empty;
                switch (operation)
                {
                    case "+":
                        textDisplay.Text = (result + Double.Parse(textDisplay.Text)).ToString();
                        break;
                    case "-":
                        textDisplay.Text = (result - Double.Parse(textDisplay.Text)).ToString();
                        break;
                    case "×":
                        textDisplay.Text = (result * Double.Parse(textDisplay.Text)).ToString();
                        break;
                    case "÷":
                        try
                        {
                            double divisor = Double.Parse(textDisplay.Text);
                            if (divisor == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            textDisplay.Text = (result / divisor).ToString();
                        }
                        catch (DivideByZeroException)
                        {
                            textDisplay.Text = " Cannot divide by zero.";
                            return;
                        }
                        catch (FormatException)
                        {
                            textDisplay.Text = "Invalid input. Please enter a number.";
                            return;
                        }
                        break;
                    default:
                        textPreview.Text = $"{textDisplay.Text} = ";
                        break;
                }
                result = Double.Parse(textDisplay.Text);
                operation = string.Empty;
            }
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1);
            if (textDisplay.Text == string.Empty) textDisplay.Text = "0";
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            textPreview.Text = string.Empty;
            result = 0;
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textPreview.Text = $"%({textDisplay.Text})";
            textDisplay.Text = Convert.ToString(Convert.ToDouble(textDisplay.Text) / Convert.ToDouble(100));
        }
        private void textDisplay_TextChanged(object sender, EventArgs e)
        {
            string value = textDisplay.Text.Replace(",", "");
            long ul;
            if (long.TryParse(value, out ul))
            {
                textDisplay.TextChanged -= textDisplay_TextChanged;
                textDisplay.Text = string.Format("{0:#,#0}", ul);
                textDisplay.SelectionStart = textDisplay.Text.Length;
                textDisplay.TextChanged += textDisplay_TextChanged;
            }
        }
        private void btnNum_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0" || enterValue) textDisplay.Text = string.Empty;

            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textDisplay.Text.Contains("."))
                    textDisplay.Text += "0.";
            }
            else textDisplay.Text = textDisplay.Text + button.Text;
        }
    }
    
}
