using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            CalculateResult("+");
        }

        protected void SubtractButton_Click(object sender, EventArgs e)
        {
            CalculateResult("-");
        }

        protected void MultiplyButton_Click(object sender, EventArgs e)
        {
            CalculateResult("*");
        }

        private void CalculateResult(string operation)
        {
            if (double.TryParse(number1TextBox.Text, out double number1) && double.TryParse(number2TextBox.Text, out double number2))
            {
                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                }
                result.Text = $"Result: {result}";
            }
            else
            {
                result.Text = "Please enter valid numbers.";
            }
        }
    }
}