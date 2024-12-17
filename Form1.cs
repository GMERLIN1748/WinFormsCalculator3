namespace WinFormsCalculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            double iNum1 = Double.Parse(inputNum1);
            double iNum2 = Double.Parse(inputNum2);
            double iresult = iNum1 + iNum2;
            result.Text = iresult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            double iNum1 = Double.Parse(inputNum1);
            double iNum2 = Double.Parse(inputNum2);
            double iresult = iNum1 - iNum2;
            result.Text = iresult.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            double iNum1 = Double.Parse(inputNum1);
            double iNum2 = Double.Parse(inputNum2);
            double iresult = iNum1 * iNum2;
            result.Text = iresult.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            double iNum1 = Double.Parse(inputNum1);
            double iNum2 = Double.Parse(inputNum2);
            double iresult = iNum1 / iNum2;
            result.Text = iresult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            result.Clear();
        }
    }
}
