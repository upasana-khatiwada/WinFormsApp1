namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "/";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "7";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "8";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "-";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "2";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            if (data.Contains("("))
            {
                result.Text = data + ")";
            }
            else
            {
                result.Text = "("+data;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + ".";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + "0";
        }
        private void button19_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data.Remove(data.Length - 1);

        }
        private void button20_Click(object sender, EventArgs e)
        {
            
        }









    }
}