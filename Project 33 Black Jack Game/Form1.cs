using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Project_33_Black_Jack_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 f2 = new Form2();

            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream rud = new FileStream("userdata.txt", FileMode.Open, FileAccess.Read);
                FileStream ub = new FileStream("userbalance.txt", FileMode.Open, FileAccess.Read);

                StreamReader sk = new StreamReader(ub);

                StreamReader sr = new StreamReader(rud);

                string username = textBox1.Text;
                string password = textBox2.Text;
                string readusername = "username";
                string readpassword = "password";
                string checkbalance = "checkbalance";
                string checkusername = "username";

                while (!sr.EndOfStream)
                {
                    readusername = sr.ReadLine();

                    if (username == readusername)
                    {


                        while (!sr.EndOfStream)
                        {
                            readpassword = sr.ReadLine();


                            if (password == readpassword)
                            {
                                MessageBox.Show("You can start the Black Jack Game");

                                this.Hide();

                                Form3 f3 = new Form3();

                                f3.label2.Text = username;
                                f3.Show();

                                break;

                            }
                            else
                            {
                                MessageBox.Show("Invalid Password");
                                break;

                            }

                        }
                        break;
                    }

                    else

                    {

                        continue;


                    }

                }

                while (!sk.EndOfStream)

                {
                    checkusername = sk.ReadLine();
                    if (username == checkusername)

                    {


                        checkbalance = sk.ReadLine();



                        break;




                    }
                }

                if (username != readusername && password != readpassword)
                {
                    MessageBox.Show("User Not Found");
                }


                // Form4 f4 = new Form4();
                // f4.label3.Text = checkbalance;

                sr.Close();
                rud.Close();
                ub.Close();


            }
            
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
    } 

}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

