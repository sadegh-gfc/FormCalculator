using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {

        static string inp = "";
        static string inp1 = "";
         string inph = "";
        string show;
        string valuaForComputAgainBug = "";
        string valuaForComputAgainBug2 = "";
        double inpL;
        double inphL;
        bool isbigerThan3 = false;
        //static int T = 0;
        // string[] labelA = new string[T];

        //static double y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void sadgh()
        { }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = new DialogResult();

            d = MessageBox.Show("If You Want To Exit press Yes", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        //=================
        //#region OperationMethod
        //public void Sum(string b)
        //{
        //    errorProvider1.Clear();

        //    if (a.Length == 0)
        //    {
        //        errorProvider1.SetError(textBox1, "Your Didn't Enter any valua");
        //        return;
        //    }
        //    if (b.Length == 0)
        //    {
        //        errorProvider1.SetError(textBox2, "Your Didn't Enter any valua");
        //        return;
        //    }
        //    int e = int.Parse(a);
        //    int d = int.Parse(b);
        //    int v = e + d;
        //    textBoxResult.Text = v.ToString();


        //} 
        //public void Minese(string a,string b)
        //{
        //    errorProvider1.Clear();
        //    if (a.Length == 0)
        //    {
        //        errorProvider1.SetError(textBox1, "Your Didn't Enter any valua");
        //        return;
        //    }
        //    if (b.Length == 0)
        //    {
        //        errorProvider1.SetError(textBox2, "Your Didn't Enter any valua");
        //        return;
        //    }
        //    int e = int.Parse(a);
        //    int d = int.Parse(b);
        //    int v = e - d;
        //    textBoxResult.Text = v.ToString();
        //}
        //public void Division(string a,string b)
        //{
        //    errorProvider1.Clear();
        //    if (a.Length == 0)
        //    {
        //        errorProvider1.SetError(textBox1,"Your Didn't Enter any valua");   
        //        return;
        //    }
        //    if (b.Length == 0)
        //    {
        //        errorProvider1.SetError(textBox2,"Your Didn't Enter any valua");
        //        return;
        //    }
        //    int e = int.Parse(a);
        //    int d = int.Parse(b);
        //    int v = e / d;
        //    textBoxResult.Text = v.ToString();

        //}
        //public void Multipicat(string a, string b)
        //{
        //    errorProvider1.Clear();
        //    if (a.Length == 0)
        //    {
        //        errorProvider1.SetError(textBox1, "Your Didn't Enter any valua");
        //        return;
        //    }
        //    if (b.Length == 0)
        //    {
        //        errorProvider1.SetError(textBox2, "Your Didn't Enter any valua");
        //        return;
        //    }
        //    int e = int.Parse(a);
        //    int d = int.Parse(b);
        //    int v = e * d;
        //    textBoxResult.Text = v.ToString();
        //}
        //#endregion
        //=================
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b' &&
                e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/'
                && e.KeyChar != '%')
            {
                e.Handled = true;
            }
        }
        private void buttonSum_Click(object sender, EventArgs e)
        {
            operation();

            double o = 0.0;
            double d = 0.0;
            bool IsCorrect = true;
            try
            {
                if (inp == "")
                {
                    inp1 = "+";
                    label1.Text = inph + " +" + inp;
                    return;
                }
                else
                {
                    o = Convert.ToDouble(inp);
                }

                if (Convert.ToDouble(inph) != 0)
                {
                    d = Convert.ToDouble(inph);
                }
            }
            catch
            {
                // MessageBox.Show("Your value is Wrong!!",
                //"Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // //inp = string.Empty;
                // IsCorrect = false;
            }
            if (IsCorrect == false)
            {
                inp = "";
            }
            else
            { 
                inp = Convert.ToString(o + d);

                inp1 = "";
                inp1 = "+";
                inph = inp;
                inp = "";
                label1.Text = inph + " +" + inp;
                textBox1.Text = inph;
            }
        }
        private void ButtonMinese_Click(object sender, EventArgs e)
        {
            // inp1 = "";
            //inp1 += "-";

            //inp1 = "-";

            //operation();
            //return;
            operation();
            double o = 0.0;
            double d = 0.0;
            bool IsCorrect = true;
            try
            {
                if (inp == "")
                {
                    inp1 = "-";
                    label1.Text = inph + " -" + inp;
                    return;
                }
                else
                {
                    o = Convert.ToDouble(inp);
                }

                if (Convert.ToDouble(inph) != 0)
                {
                    d = Convert.ToDouble(inph);
                }


            }
            catch
            {
                // MessageBox.Show("Your value is Wrong!!",
                //"Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // //inp = string.Empty;
                // IsCorrect = false;
            }
            if (IsCorrect == false)
            {
                inp = "";
            }
            else
            {
                inp = Convert.ToString(o - d);

                inp1 = "";
                inp1 = "-";
                inph = inp;
                inp = "";
                label1.Text = inph + " -" + inp;
                textBox1.Text = inph;
            }
        }

        private void buttonMultipicate_Click(object sender, EventArgs e)
        {
            if (inp == "" & inph == "")
            {
                ClearAll();
                return;
            }
            operation();
            double o = 0.0;
            double d = 0.0;
            bool IsCorrect = true;
            try
            {
                if (inp == "")
                {
                    inp1 = "*";
                    label1.Text = inph + " ×" + inp;
                    return;
                }
                else
                {
                    o = Convert.ToDouble(inp);
                }

                if (Convert.ToDouble(inph) != 0)
                {
                    d = Convert.ToDouble(inph);
                }

            }
            catch
            {
                // MessageBox.Show("Your value is Wrong!!",
                //"Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (IsCorrect == false)
            {
                inp = "";
            }
            else
            {
                if (d != 0)
                {
                    inp = Convert.ToString(d * o);
                }

                inp1 = "";
                inp1 = "*";
                inph = inp;
                inp = "";
                label1.Text = inph + " ×" + inp;
                textBox1.Text = inph;
            }
        }
        /// <summary>
        /// this method 
        /// </summary>
        /// <param name="sender">lkjas lsjkd</param>
        /// <param name="e">safsda</param>
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (inp == "" & inph == "")
            {
                ClearAll();
                return;
            }
            operation();
            double o = 0.0;
            double d = 0.0;
            bool IsCorrect = true;
            try
            {
                if(inp == "")
                {
                    inp1 = "÷";
                    label1.Text = inph + " ÷" + inp;
                    return;
                }
                else
                {
                    o = Convert.ToDouble(inp);
                }

                if (Convert.ToDouble(inph) != 0)
                {
                    d = Convert.ToDouble(inph);
                }

            }
            catch
            {
                // MessageBox.Show("Your value is Wrong!!",
                //"Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (IsCorrect == false)
            {
                inp = "";
            }
            else
            {

               
               
                   if (d != 0)
                    {
                    //    if (o > d)
                    //    {
                    //        inp = Convert.ToString(o / d);

                    //    }
                    //    else if (d < o)
                    //    {
                            inp = Convert.ToString(d / o);
                    //    }
                    //    else
                    //    {
                    //        inp = "1";
                    //    }
                   }
             
               

                    inp1 = "";
                    inp1 += "/";
                    inph = inp;
                    inp = "";
                    textBox1.Text = inph;
                    label1.Text = inph + " ÷" + inp;
                
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (inp == "" & inph == "")
            {
                ClearAll();
                return;
            }
            operation();

            double o = 0.0;
            double d = 0.0;
            bool IsCorrect = true;
            try
            {
                if (inp == "")
                {
                    inp1 = "/";
                    label1.Text = inph + " %" + inp;
                    return;
                }
                else
                {
                    o = Convert.ToDouble(inp);
                }

                if (Convert.ToDouble(inp) != 0)
                {
                    d = Convert.ToDouble(inph);
                }
            }
            catch
            {
                // MessageBox.Show("Your value is Wrong!!",
                //"Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (IsCorrect == false)
            {
                inp = "";
            }
            else
            {
                if (d != 0)
                {
                    if (d > o)
                    {
                        inp = Convert.ToString(d % o);
                    }
                    else if (o > d)
                    {
                        inp = Convert.ToString(o % d);

                    }
                    else
                    {
                        inp = "0";
                    }
                }
                else
                {
                    inp1 = "";
                    inp1 += "%";
                    inph = inp;
                    inp = "";
                    textBox1.Text = inph;
                    label1.Text = inph + " %" + inp;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //=====================
        //number buttons
        #region number_buttons
        private void button1_Click(object sender, EventArgs e)
        {
            //inp = "";
          
           
            this.textBox1.Text = "";
            inp += "1";
            this.textBox1.Text += inp;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // inp = "";
            this.textBox1.Text = "";
            inp += "2";
            this.textBox1.Text += inp;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /// inp = "";
            this.textBox1.Text = "";
            inp += "3";
            this.textBox1.Text += inp;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // inp = "";
            this.textBox1.Text = "";
            inp += "4";
            this.textBox1.Text += inp;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // inp = "";
            this.textBox1.Text = "";
            inp += "5";
            this.textBox1.Text += inp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // inp = "";
            this.textBox1.Text = "";
            inp += "6";
            this.textBox1.Text += inp;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // inp = "";
            this.textBox1.Text = "";
            inp += "7";
            this.textBox1.Text += inp;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //inp = "";
            this.textBox1.Text = "";
            inp += "8";
            this.textBox1.Text += inp;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // inp = "";
            this.textBox1.Text = "";
            inp += "9";
            this.textBox1.Text += inp;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            // inp = "";
            this.textBox1.Text = "";
            inp += "0";
            this.textBox1.Text += inp;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            inp += ".";
            this.textBox1.Text += inp;
        }
        private void buttonPI_Click(object sender, EventArgs e)
        {
            inp = "";
            this.textBox1.Text = "";
            inp += "3.14159265359";
            this.textBox1.Text += inp;
        }
        #endregion
        //=====================
        private void buttonResult_Click(object sender, EventArgs e)
        {

            this.operation();

            inp1 = "";

            return;

        }

        private void buttonclear_all_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy Righted by sadegh_gfc" + "\n" + "Warning!" + "\n" + "Dont Wait For next version!",
                "About me", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonclear_all_KeyDown(object sender, KeyEventArgs e)
        {

        }



        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                inp = inp.Remove(inp.Length - 1, 1);
            }
            catch
            {
                MessageBox.Show(" You cant backspace when no more number There is! ",
                    "Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetColor();

            this.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;
            textBox1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            menuStrip1.ForeColor = Color.White;

           
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetColor();

            this.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            textBox1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            menuStrip1.ForeColor = Color.Black;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetColor();

            this.BackColor = Color.LightBlue;
            textBox1.ForeColor = Color.Black;
            textBox1.BackColor = Color.LightBlue;
            label1.ForeColor = Color.Black;
            menuStrip1.ForeColor = Color.Black;

        }
        private void goldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetColor();
            this.BackColor = Color.DarkGoldenrod;
            textBox1.ForeColor = Color.Black;
            textBox1.BackColor = Color.DarkGoldenrod;
            label1.ForeColor = Color.Black;
            menuStrip1.ForeColor = Color.Black;


            button1.BackColor = Color.DarkGoldenrod;
            button2.BackColor = Color.DarkGoldenrod;
            button3.BackColor = Color.DarkGoldenrod;
            button4.BackColor = Color.DarkGoldenrod;
            button5.BackColor = Color.DarkGoldenrod;
            button6.BackColor = Color.DarkGoldenrod;
            button7.BackColor = Color.DarkGoldenrod;
            button8.BackColor = Color.DarkGoldenrod;
            button9.BackColor = Color.DarkGoldenrod;
            button0.BackColor = Color.DarkGoldenrod;
            buttonResult.BackColor = Color.Green;
        }
        void operation()
        {
            string operation = inp1;
            // double x = 0.0;
            //// double y = 0.0;
            // if (inp != "")
            // {
            //     x = Convert.ToDouble(inp);                //y = Convert.ToDouble(inph);
            // }
            double v;
            double x = 0.0;
            double y = 0.0;
            if (inp1 == "+")
            {

                show = inph + " " + "+" + " " + inp +  "=";

                //valuaForComputAgainBug = inp;
                label1.Text = show;

                try
                {
                    if (inp == "")
                    {
                        return;
                    }
                    else
                    {
                        x = Convert.ToDouble(inp);

                    }


                    if (Convert.ToDouble(inph) != 0)
                    {
                        y = Convert.ToDouble(inph);
                    }

                }
                catch
                {
                    // MessageBox.Show("Your value is Wrong!!",
                    //"Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                v = x + y;
                string ComputingAgain = v.ToString();
                this.textBox1.Text = "";
                this.textBox1.Text = v.ToString();
                this.textBox1.ReadOnly = true;

                inp = ComputingAgain;
                inph = "";

            }
            else if (inp1 == "-")
            {

                show = inph + " " + "-" + " " + inp + " =";
                label1.Text = show;
                try
                {
                    if (inp == "")
                    {
                        return;
                    }
                    else
                    {
                        x = Convert.ToDouble(inp);

                    }

                    if (Convert.ToDouble(inph) != 0)
                    {
                        y = Convert.ToDouble(inph);
                    }
                }
                catch
                {
                    // messagebox.show("your value is wrong!!",
                    //"erorr!", messageboxbuttons.ok, messageboxicon.error);
                }
                v = y - x;
                string computingagain = v.ToString();
                this.textBox1.Text = "";
                this.textBox1.Text = v.ToString();
                this.textBox1.ReadOnly = true;
                inp = computingagain;
                inph = "";

            }
            else if (inp1 == "/")
            {
                double R = 0.0;
                show = inph + " " + "÷" + " " + inp + " =";
                label1.Text = show;

                try
                {
                    if (inp == "")
                    {
                        return;
                    }
                    else
                    {
                        x = Convert.ToDouble(inp);

                    }

                    if (Convert.ToDouble(inph) != 0)
                    {
                        y = Convert.ToDouble(inph);

                    }
                }
                catch
                {
                    // MessageBox.Show("Your value is Wrong!!",
                    //"Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (y != 0)
                {
                   
                        R = Convert.ToDouble(y / x);     
                }

                 if (inp == "0")
                {
                    textBox1.Text = "Can Not Divide by Zero";
                    return;
                }

               
                



                string ComputingAgain;
                ComputingAgain = R.ToString();
                this.textBox1.Text = "";
                this.textBox1.Text = R.ToString();
                this.textBox1.ReadOnly = true;
                inp = ComputingAgain;
                inph = "";
            }
            else if (inp1 == "*")
            {
                y = 1;
                show = inph + " " + "×" + " " + inp + " =";
                label1.Text = show;


                try
                {
                    if (inp == "")
                    {
                        return;
                    }
                    else
                    {
                        x = Convert.ToDouble(inp);

                    }

                    if (Convert.ToDouble(inph) != 0)
                    {
                        y = Convert.ToDouble(inph);
                    }

                }
                catch
                {
                    // MessageBox.Show("Your value is Wrong!!",
                    //"Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                v = x * y;
                string ComputingAgain = v.ToString();
                this.textBox1.Text = "";
                this.textBox1.Text = v.ToString();
                this.textBox1.ReadOnly = true;
                inp = ComputingAgain;
                inph = "";

            }
            else if (inp1 == "%")
            {
                show = inph + " " + "%" + " " + inp + " =";
                label1.Text = show;

                try
                {
                    if (inp == "")
                    {
                        return;
                    }
                    else
                    {
                        x = Convert.ToDouble(inp);

                    }

                    if (Convert.ToDouble(inph) != 0)
                    {
                        y = Convert.ToDouble(inph);
                    }

                }
                catch
                {
                    // MessageBox.Show("Your value is Wrong!!",
                    //"Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                v = y % x;
                
                    
                
                string ComputingAgain = v.ToString();
                this.textBox1.Text = "";
                this.textBox1.Text = v.ToString();
                this.textBox1.ReadOnly = true;
                inp = ComputingAgain;
                inph = "";

                //textBox1.Text = y.ToString();
                //inp = "";
            }
        }

        public void Vchange(string a,string b)
        {
             inpL = Convert.ToDouble(a);
             inphL = Convert.ToDouble(b);
        }

        public void ClearAll()
        {

            inp = "";
            inp1 = "";
            inph = "";
            valuaForComputAgainBug = "";
            valuaForComputAgainBug2 = "";
            //inph = "";
            textBox1.Text = "0";
            label1.Text = "";
        }

        public void HideBorder()
        {
            
        }

        public void ResetColor()
        {
            button1.BackColor = Color.Aquamarine;
            button2.BackColor = Color.Aquamarine;
            button3.BackColor = Color.Aquamarine;
            button4.BackColor = Color.Aquamarine;
            button5.BackColor = Color.Aquamarine;
            button6.BackColor = Color.Aquamarine;
            button7.BackColor = Color.Aquamarine;
            button8.BackColor = Color.Aquamarine;
            button9.BackColor = Color.Aquamarine;
            button0.BackColor = Color.Aquamarine;
            buttonResult.BackColor = Color.Green;

            
        }
    }
}
