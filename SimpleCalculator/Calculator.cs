using System;
using System.Diagnostics;
using System.Windows.Forms;

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
            if (result != 0)
                btnEqual.PerformClick();
            else if (!string.IsNullOrEmpty(textDisplay.Text))
                result = Double.Parse(textDisplay.Text);

            if (!string.IsNullOrEmpty(textDisplay.Text))
                fstNum = textDisplay.Text;

            operation = optrSymbol;
            enterValue = true;

            textPreview.Text = $"{result} {operation}";
            textDisplay.Text = string.Empty;
        }
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button != null)
            {
                string buttonText = button.Text;
                secNumDisplay(buttonText);
            }
            else if (button.Text == ".")
            {
                if (!textDisplay.Text.Contains("."))
                    textDisplay.Text += ".";
            }
            else textDisplay.Text = textDisplay.Text + button.Text;
        }
        private void secNumDisplay(string value)
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
            string value = textDisplay.Text.Replace(",", "").Replace(".", "");
            if (long.TryParse(value, out _))
            {
                textDisplay.TextChanged -= textDisplay_TextChanged;
                if (textDisplay.Text.Contains("."))
                {
                    string[] parts = textDisplay.Text.Split('.');
                    textDisplay.Text = string.Format("{0:#,#0}.{1}", long.Parse(parts[0]), parts[1]);
                }
                else
                {
                    textDisplay.Text = string.Format("{0:#,#0}", long.Parse(value));
                }
                textDisplay.SelectionStart = textDisplay.Text.Length;
                textDisplay.TextChanged += textDisplay_TextChanged;
            }
        }
       
    }
}
