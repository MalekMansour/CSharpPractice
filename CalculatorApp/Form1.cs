using System;
using System.Data;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxInput.Text += button.Text;
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxInput.Text += button.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(textBoxInput.Text, null);
                textBoxInput.Text = result.ToString();
            }
            catch (Exception ex)
            {
                textBoxInput.Text = "Error";
            }
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxInput.Text) && textBoxInput.Text[0] == '-')
            {
                textBoxInput.Text = textBoxInput.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(textBoxInput.Text) && textBoxInput.Text[0] != '-')
            {
                textBoxInput.Text = '-' + textBoxInput.Text;
            }
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(textBoxInput.Text + "*0.01", null);
                textBoxInput.Text = result.ToString();
            }
            catch (Exception ex)
            {
                textBoxInput.Text = "Error";
            }
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (!textBoxInput.Text.Contains("."))
            {
                textBoxInput.Text += ".";
            }
        }
    }
}
