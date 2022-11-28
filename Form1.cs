using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string operate = "";
        decimal calculation = 0;

        SqlConnection con = new SqlConnection(
            @"Data Source= .\SQLEXPRESS; 
            Initial Catalog= bit3rdsem;
            user id =sa ; 
            password =kist@123;");
        //if error in slash it is due to string so write \\ double slash or @

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
            GetResultValue();
            operate = "%";
            result.Text =  "%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "*";
            result.Text =  "*";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "/";
            result.Text =  "/";

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "7";
            }
            else
            {
                string data = result.Text;
                result.Text = data + "7";
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "8";
            }
            else
            {
                string data = result.Text;
                result.Text = data + "8";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "9";
            }
            else
            {
                string data = result.Text;
                result.Text = data + "9";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "-";
            result.Text =  "-";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "4";
            }
            else
            {
                string data = result.Text;
                result.Text = data + "4";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "5";
            }
            else
            {
                string data = result.Text;
                result.Text = data + "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(result.Text == "+"|| result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%" )
            {
                result.Text = "6";
            }
            else
            {
                string data = result.Text;
                result.Text = data + "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "+";
            result.Text =  "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "1";
            }
            else
            {
                string data = result.Text;
                result.Text = data + "1";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "2";
            }
            else
            {
                string data = result.Text;
                result.Text = data + "2";
            }

        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "3";
            }
            else
            {
                string data = result.Text;
                result.Text = data + "3";
            }
            
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
            GetResultValue();
            operate = ".";          
            result.Text =  ".";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "0";
            }
            else
            {
                string data = result.Text;
                result.Text = data + "0";
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data.Remove(data.Length - 1);

        }
        private void button20_Click(object sender, EventArgs e)
        {
            decimal firstNum = calculation;
            decimal secondNum = Convert.ToDecimal(result.Text);
            switch(operate)
            {
                case "+":
                    calculation = (firstNum + secondNum);
                    result.Text = firstNum + " + " + secondNum + " = " + calculation.ToString();
                    
                    break;
                case "-":
                    calculation = (firstNum - secondNum);
                    result.Text = firstNum + " - " + secondNum + " = " + calculation.ToString();
                    break;
                case "*":
                    calculation = (firstNum * secondNum);
                    result.Text = firstNum + " * " + secondNum + " = " + calculation.ToString();
                    break;
                case "/":
                    calculation = (firstNum / secondNum);
                    result.Text = firstNum + " / " + secondNum + " = " + calculation.ToString();
                    break;
                case "%":
                    calculation = (firstNum % secondNum);
                    result.Text = firstNum + " % " + secondNum + " = " + calculation.ToString();
                    break;
            }
            

        }
        private void button21_Click(object sender, EventArgs e)
        {
            //this.Hide();        //hide current form and open new one 
            //Form2 EmployeeForm = new Form2();
            // // EmployeeForm.ShowDialog();
            // //The Show function shows the form in a non modal form. This means that you can click on the parent form.
            ////ShowDialog shows the form modally, meaning you cannot go to the parent form
            //     EmployeeForm.Show();
            try
            {
                con.Open();
                string query = @"Insert into Students values('upasana', 'thapathali', '9843816723','kist'),
    ('sova', 'tinkune', '9857687574','kist'),
    ('rinjha', 'jawlakhel', '9855647809','kist')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("saved Sucessfully");

            }
            catch(Exception ex)

            {
                MessageBox.Show("Error: " + ex.InnerException);
            }
        }
        public void GetResultValue()
        {
            if(result.Text !=""&& result.Text != "+" && result.Text != "/" && result.Text != "*" && result.Text != "-" && result.Text != "%" && result.Text != ".")
            {
                calculation = Convert.ToDecimal(result.Text);
               

            }
        }
        









    }
}