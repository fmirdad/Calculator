using System.Diagnostics.Eventing.Reader;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int result;

            if (Addition.Checked)
            {
                result = num1 + num2;
                textBox3.Text = Convert.ToString(result);
            }
            else if (Minus.Checked)
            {
                result = num1 - num2;
                textBox3.Text = Convert.ToString(result);
            }
            else if (Multiply.Checked)
            {
                result = num1 * num2;
                textBox3.Text = Convert.ToString(result);
            }
            else if (Power.Checked)
            {
                result = num1;
                for (int i = 0; i < num2; i++)
                {
                    result = result * num1;
                }
                if (num2 == 0)
                {
                    result = 1;
                    textBox3.Text = Convert.ToString(result);
                }
                else
                {
                    textBox3.Text = Convert.ToString(result);
                }
            }
        }
    }
}
