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
    public partial class Calculator : Form
    {
        double result = 0;
        string operation = string.Empty;
        string fstNum, secNum, operatr;
        bool enterValue = false;
        public Calculator()
        {
            InitializeComponent();
        }
        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button != null)
            {
                string buttonText = button.Text;
                SetOperator(buttonText);
            }
        }
        private void SetOperator(string optrSymbol)
        {
            if (enterValue)
            {
                operation = optrSymbol;
                textPreview.Text = fstNum + operation;
            }
            else
            {
                fstNum = secNum;
                operation = optrSymbol;
                secNum = "";
                textPreview.Text = fstNum + operation;
                textDisplay.Text = "0";
            }
            enterValue = true;
        }
        private void AgainEqual(string value)
        {
            if (enterValue)
            {
                secNum = value;
                enterValue = false;
            }
            else
            {
                secNum += value;
            }
            textDisplay.Text = secNum;
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(fstNum);
            double num2 = double.Parse(secNum);
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "×":
                        result = num1 * num2;
                        break;
                    case "÷":
                        try
                        {
                            double divisor = Double.Parse(textDisplay.Text);
                            if (divisor == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            result = num1 / num2;
                        }
                        catch (DivideByZeroException)
                        {
                            textDisplay.Text = " Cannot divide by zero.";
                            return;
                        }
                        break;
                }
                textDisplay.Text = result.ToString();
                textPreview.Text = $"{num1} {operation} {num2} = ";
                fstNum = result.ToString();
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1);
            if (textDisplay.Text == string.Empty) textDisplay.Text = "0";
            fstNum = "";
            secNum = "";
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            textPreview.Text = string.Empty;
            fstNum = "";
            secNum = "";
            result = 0;
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            fstNum = "";
            secNum = "";
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
            Button button = (Button)sender;
            if (button != null)
            {
                string buttonText = button.Text;
                AgainEqual(buttonText);
            }
            else if (button.Text == ".")
            {
                if (!textDisplay.Text.Contains("."))
                    textDisplay.Text += "0.";
            }
            else textDisplay.Text = textDisplay.Text + button.Text;
        }
    }
}
