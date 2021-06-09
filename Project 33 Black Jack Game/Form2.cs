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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string userbalance = "zero";
                int usergain = 1500;
                FileStream rwud = new FileStream("userdata.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                FileStream uba = new FileStream("userbalance.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter ad = new StreamWriter(uba);
                StreamReader sr = new StreamReader(rwud);
                StreamWriter sw = new StreamWriter(rwud);
                StreamReader uc = new StreamReader(uba);


                string username = textBox1.Text;
                string readusername = "username";

                while (!sr.EndOfStream)
                {
                    readusername = sr.ReadLine();




                    if (readusername == username)
                    {
                        readusername = username;
                        MessageBox.Show("Username already exists");
                        break;
                    }

                    else

                    {

                        continue;


                    }

                }


                while (!uc.EndOfStream)
                {
                    readusername = uc.ReadLine();




                    if (readusername == username)
                    {
                        readusername = username;

                        break;
                    }

                    else

                    {

                        continue;


                    }

                }

                if (readusername != username)
                {
                    ad.WriteLine(textBox1.Text);
                    ad.WriteLine("1500");
                    sw.WriteLine(username);
                    sw.WriteLine(textBox2.Text);

                    // FileStream uba = new FileStream("userbalance.txt", FileMode.OpenOrCreate, FileAccess.Write);

                    //  StreamReader uc = new StreamReader(uba);
                    //  StreamWriter ad = new StreamWriter(uba);

                    // ad.WriteLine(username);

                    // ad.WriteLine(usergain);

                    //  userbalance = usergain.ToString();

                    //  ad.Close();
                    // uc.Close();
                    //  uba.Close();
                    DialogResult d;

                    d = MessageBox.Show(" Do you want to start the game now ?", "You are now registered, Congratulations ! You win 1500$ ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (d == DialogResult.No)
                    {
                        Close();
                    }

                    if (d == DialogResult.Yes)
                    {
                        this.Hide();
                        Form3 f3 = new Form3();


                        f3.label2.Text = username;
                        f3.Show();

                    }

                }



                sw.Close();
                sr.Close();
                ad.Close();
                uba.Close();
                uc.Close();
                rwud.Close();

            }

            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
    }
    }
             
}
