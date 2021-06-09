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
using System.Linq.Expressions;

namespace Project_33_Black_Jack_Game
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form4 f4 = new Form4();
                f4.label6.Hide();
                f4.button6.Hide();
                f4.button5.Hide();



                f4.pictureBox2.Image = pictureBox2.Image;
                f4.label2.Text = label2.Text;

                string username = "username";
                string userbalance = "unknown";

                FileStream ub = new FileStream("userbalance.txt", FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(ub);
                while (!sr.EndOfStream)

                {
                    username = sr.ReadLine();
                    if (label2.Text == username)

                    {


                        userbalance = sr.ReadLine();



                        break;




                    }
                }






                f4.label3.Text = userbalance;


                f4.Show();
            }

            catch(Exception ex)

            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {


                this.Hide();
                Form4 f4 = new Form4();
                f4.label6.Hide();
                f4.button6.Hide();
                f4.button5.Hide();


                f4.pictureBox2.Image = pictureBox4.Image;
                f4.label2.Text = label2.Text;

                string username = "username";
                string userbalance = "unknown";

                FileStream ub = new FileStream("userbalance.txt", FileMode.Open, FileAccess.Read);

                StreamReader ubr = new StreamReader(ub);
                while (!ubr.EndOfStream)

                {
                    username = ubr.ReadLine();
                    if (label2.Text == username)

                    {


                        userbalance = ubr.ReadLine();



                        break;




                    }
                }






                f4.label3.Text = userbalance;


                f4.Show();

            }

            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();
                Form4 f4 = new Form4();

                f4.pictureBox2.Image = pictureBox6.Image;
                f4.label2.Text = label2.Text;
                f4.label6.Hide();
                f4.button6.Hide();
                f4.button5.Hide();


                string username = "username";
                string userbalance = "unknown";

                FileStream ub = new FileStream("userbalance.txt", FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(ub);
                while (!sr.EndOfStream)

                {
                    username = sr.ReadLine();
                    if (label2.Text == username)

                    {


                        userbalance = sr.ReadLine();



                        break;




                    }
                }






                f4.label3.Text = userbalance;


                f4.Show();
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form4 f4 = new Form4();

                f4.pictureBox2.Image = pictureBox5.Image;
                f4.label2.Text = label2.Text;
                f4.label6.Hide();
                f4.button6.Hide();
                f4.button5.Hide();



                string username = "username";
                string userbalance = "unknown";

                FileStream ub = new FileStream("userbalance.txt", FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(ub);
                while (!sr.EndOfStream)

                {
                    username = sr.ReadLine();
                    if (label2.Text == username)

                    {


                        userbalance = sr.ReadLine();



                        break;




                    }
                }






                f4.label3.Text = userbalance;


                f4.Show();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form4 f4 = new Form4();

                f4.pictureBox2.Image = pictureBox1.Image;
                f4.label2.Text = label2.Text;
                f4.label6.Hide();
                f4.button6.Hide();
                f4.button5.Hide();



                string username = "username";
                string userbalance = "unknown";

                FileStream ub = new FileStream("userbalance.txt", FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(ub);
                while (!sr.EndOfStream)

                {
                    username = sr.ReadLine();
                    if (label2.Text == username)

                    {


                        userbalance = sr.ReadLine();



                        break;




                    }
                }






                f4.label3.Text = userbalance;


                f4.Show();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form4 f4 = new Form4();

                f4.pictureBox2.Image = pictureBox7.Image;
                f4.label2.Text = label2.Text;
                f4.label6.Hide();
                f4.button6.Hide();
                f4.button5.Hide();


                string username = "username";
                string userbalance = "unknown";

                FileStream ub = new FileStream("userbalance.txt", FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(ub);
                while (!sr.EndOfStream)

                {
                    username = sr.ReadLine();
                    if (label2.Text == username)

                    {


                        userbalance = sr.ReadLine();



                        break;




                    }
                }






                f4.label3.Text = userbalance;


                f4.Show();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try {
                this.Hide();
                Form4 f4 = new Form4();
                f4.label6.Hide();
                f4.button6.Hide();
                f4.button5.Hide();

                f4.pictureBox2.Image = pictureBox3.Image;
                f4.label2.Text = label2.Text;

                string username = "username";
                string userbalance = "unknown";

                FileStream ub = new FileStream("userbalance.txt", FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(ub);
                while (!sr.EndOfStream)

                {
                    username = sr.ReadLine();
                    if (label2.Text == username)

                    {


                        userbalance = sr.ReadLine();



                        break;




                    }
                }






                f4.label3.Text = userbalance;


                f4.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
         
    }
   

    }

