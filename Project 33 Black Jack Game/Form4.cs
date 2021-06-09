using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_33_Black_Jack_Game
{
    public partial class Form4 : Form
    {
        public int pic1;
        public int pic3;
        public int pic4;
        public int pic5;
        public int pic6;
        public int pic7;
       
        public int betmoney = 0;
        public int dealerscore=0;
        public int dealercard1score = 0;
        public int dealercard2score = 0;
        public int dealercard3score = 0;
        public int card1score = 0;
       public int card2score = 0;
        public int card3score = 0;
        public int score = 0;
        public string fscore = "zero";
        



        public string initialbalance = "balance";

        
        public int userbalance = 0;
       public  int finalbalance = 0;
        public string finaluserbalance = "finalbalance";
      
        public Form4()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)


        {
            try
            {
                button2.Show();
                button3.Hide();
                button4.Hide();
                label6.Hide();
                button1.Hide();
                button5.Hide();
                betmoney = 20;
                initialbalance = label3.Text;

                userbalance = Int32.Parse(initialbalance);
                finalbalance = userbalance - betmoney;

                finaluserbalance = finalbalance.ToString();
                label3.Text = finaluserbalance;








            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Hide();
                button3.Hide();
                button4.Hide();

                pictureBox7.Hide();

                images i = new images();

                pictureBox1.Image = i.pictureBox14.Image;
                pictureBox1.Show();
                Random random = new Random();

                pic3 = random.Next(1, 14);
                pic4 = random.Next(1, 14);
                pic5 = random.Next(1, 14);







                switch (pic3)
                {
                    case 1:
                        pictureBox3.Image = i.pictureBox1.Image;
                        card1score = 11;
                        break;

                    case 2:
                        pictureBox3.Image = i.pictureBox2.Image;
                        card1score = 2;
                        break;

                    case 3:
                        pictureBox3.Image = i.pictureBox3.Image;
                        card1score = 3;
                        break;

                    case 4:
                        pictureBox3.Image = i.pictureBox4.Image;
                        card1score = 4;
                        break;


                    case 5:
                        pictureBox3.Image = i.pictureBox5.Image;
                        card1score = 5;
                        break;

                    case 6:
                        pictureBox3.Image = i.pictureBox6.Image;
                        card1score = 6;
                        break;

                    case 7:
                        pictureBox3.Image = i.pictureBox7.Image;
                        card1score = 7;
                        break;

                    case 8:
                        pictureBox3.Image = i.pictureBox8.Image;
                        card1score = 8;
                        break;

                    case 9:
                        pictureBox3.Image = i.pictureBox9.Image;
                        card1score = 9;
                        break;

                    case 10:
                        pictureBox3.Image = i.pictureBox10.Image;
                        card1score = 10;
                        break;

                    case 11:
                        pictureBox3.Image = i.pictureBox11.Image;
                        card1score = 10;
                        break;

                    case 12:
                        pictureBox3.Image = i.pictureBox12.Image;
                        card1score = 10;
                        break;

                    case 13:
                        pictureBox3.Image = i.pictureBox13.Image;
                        card1score = 10;
                        break;




                }
                pictureBox3.Show();

                switch (pic4)
                {
                    case 1:
                        pictureBox4.Image = i.pictureBox1.Image;
                        card2score = 11;
                        break;

                    case 2:
                        pictureBox4.Image = i.pictureBox2.Image;
                        card2score = 2;
                        break;

                    case 3:
                        pictureBox4.Image = i.pictureBox3.Image;
                        card2score = 3;
                        break;

                    case 4:
                        pictureBox4.Image = i.pictureBox4.Image;
                        card2score = 4;
                        break;


                    case 5:
                        pictureBox4.Image = i.pictureBox5.Image;
                        card2score = 5;
                        break;

                    case 6:
                        pictureBox4.Image = i.pictureBox6.Image;
                        card2score = 6;
                        break;

                    case 7:
                        pictureBox4.Image = i.pictureBox7.Image;
                        card2score = 7;
                        break;

                    case 8:
                        pictureBox4.Image = i.pictureBox8.Image;
                        card2score = 8;
                        break;

                    case 9:
                        pictureBox4.Image = i.pictureBox9.Image;
                        card2score = 9;
                        break;

                    case 10:
                        pictureBox4.Image = i.pictureBox10.Image;
                        card2score = 10;
                        break;

                    case 11:
                        pictureBox4.Image = i.pictureBox11.Image;
                        card2score = 10;
                        break;

                    case 12:
                        pictureBox4.Image = i.pictureBox12.Image;
                        card2score = 10;
                        break;

                    case 13:
                        pictureBox4.Image = i.pictureBox13.Image;
                        card2score = 10;
                        break;




                }

                pictureBox4.Show();

                switch (pic5)
                {
                    case 1:
                        pictureBox5.Image = i.pictureBox1.Image;
                        dealercard1score = 11;
                        break;

                    case 2:
                        pictureBox5.Image = i.pictureBox2.Image;
                        dealercard1score = 2;
                        break;

                    case 3:
                        pictureBox5.Image = i.pictureBox3.Image;
                        dealercard1score = 3;
                        break;

                    case 4:
                        pictureBox5.Image = i.pictureBox4.Image;
                        dealercard1score = 4;
                        break;


                    case 5:
                        pictureBox5.Image = i.pictureBox5.Image;
                        dealercard1score = 5;
                        break;

                    case 6:
                        pictureBox5.Image = i.pictureBox6.Image;
                        dealercard1score = 6;
                        break;

                    case 7:
                        pictureBox5.Image = i.pictureBox7.Image;
                        dealercard1score = 7;
                        break;

                    case 8:
                        pictureBox5.Image = i.pictureBox8.Image;
                        dealercard1score = 8;
                        break;

                    case 9:
                        pictureBox5.Image = i.pictureBox9.Image;
                        dealercard1score = 9;
                        break;

                    case 10:
                        pictureBox5.Image = i.pictureBox10.Image;
                        dealercard1score = 10;
                        break;

                    case 11:
                        pictureBox5.Image = i.pictureBox11.Image;
                        dealercard1score = 10;
                        break;

                    case 12:
                        pictureBox5.Image = i.pictureBox12.Image;
                        dealercard1score = 10;
                        break;

                    case 13:
                        pictureBox5.Image = i.pictureBox13.Image;
                        dealercard1score = 10;
                        break;




                }
                pictureBox5.Show();

                score = card1score + card2score + card3score;
                fscore = score.ToString();
                label4.Text = fscore;
                label4.Show();
                dealerscore = dealercard1score + dealercard2score + dealercard3score;
                label5.Text = dealerscore.ToString();
                label5.Show();



                if (score == 21)
                {
                    finalbalance = userbalance + (3 * betmoney);
                    finaluserbalance = finalbalance.ToString();

                    label3.Text = finaluserbalance;

                    DialogResult ds;

                    ds = MessageBox.Show(" Would you like to start a new Game ?", "Congratulations ! You win 3 times your bet money amount ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (ds == DialogResult.No)
                    {
                        Close();
                    }

                    if (ds == DialogResult.Yes)
                    {
                        button1.Show();
                        button3.Show();
                        button4.Show();
                        button2.Hide();
                        label4.Hide();
                        label5.Hide();
                        pictureBox1.Hide();
                        pictureBox3.Hide();
                        pictureBox4.Hide();
                        pictureBox6.Hide();
                        pictureBox5.Hide();
                        pictureBox7.Hide();
                        dealercard1score = 0;
                        dealercard2score = 0;
                        dealercard3score = 0;
                        score = 0;
                        dealerscore = 0;
                        card1score = 0;
                        card2score = 0;
                        fscore = score.ToString();
                        label4.Text = fscore;
                        label5.Text = dealerscore.ToString();
                    }

                }

                if (score > 21)
                {
                    finalbalance = userbalance - betmoney;
                    finaluserbalance = finalbalance.ToString();

                    label3.Text = finaluserbalance;

                    DialogResult ds1;

                    ds1 = MessageBox.Show(" Would you like to start a new Game ?", "Sorry ! You lose your bet money amount ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (ds1 == DialogResult.No)
                    {
                        Close();
                    }

                    if (ds1 == DialogResult.Yes)
                    {
                        dealercard1score = 0;
                        dealercard2score = 0;
                        dealercard3score = 0;
                        score = 0;
                        dealerscore = 0;
                        card1score = 0;
                        card2score = 0;
                        fscore = score.ToString();
                        label4.Text = fscore;
                        label5.Text = dealerscore.ToString();
                        button1.Show();
                        button3.Show();
                        button4.Show();
                        button2.Hide();
                        label4.Hide();
                        label5.Hide();
                        pictureBox1.Hide();
                        pictureBox3.Hide();
                        pictureBox4.Hide();
                        pictureBox6.Hide();
                        pictureBox5.Hide();
                        pictureBox7.Hide();

                    }


                }

                if (score < 21)
                {

                    label6.Show();
                    button5.Show();
                    button6.Show();
                    button2.Hide();

                }

                dealerscore = dealercard1score + dealercard2score + dealercard3score;
                label5.Text = dealerscore.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

            public void button3_Click(object sender, EventArgs e)
        {

            try
            {
                button2.Show();
                button1.Hide();
                button4.Hide();
                label6.Hide();
                button5.Hide();
                button3.Hide();
                int betmoney = 50;
                string initialbalance = label3.Text;

                userbalance = Int32.Parse(initialbalance);
                int finalbalance = userbalance - betmoney;

                string finaluserbalance = finalbalance.ToString();
                label3.Text = finaluserbalance;
            }

            catch(Exception ex)

            {

                MessageBox.Show(ex.Message);
            }
        }

        public void button4_Click(object sender, EventArgs e)

        {
            try
            {
                button2.Show();
                button1.Hide();
                button3.Hide();
                label6.Hide();
                button5.Hide();
                button4.Hide();

                int betmoney = 100;
                string initialbalance = label3.Text;

                int userbalance = Int32.Parse(initialbalance);
                int finalbalance = userbalance - betmoney;

                string finaluserbalance = finalbalance.ToString();
                label3.Text = finaluserbalance;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void label3_Click(object sender, EventArgs e)
        {
            

        }

        public void button6_Click(object sender, EventArgs e)
        {

            try
            {
                button5.Hide();
                label6.Hide();
                button6.Hide();
                Random random = new Random();
                images i = new images();

                pic1 = random.Next(1, 14);
                switch (pic1)
                {
                    case 1:
                        pictureBox1.Image = i.pictureBox1.Image;
                        dealercard2score = 11;
                        break;

                    case 2:
                        pictureBox1.Image = i.pictureBox2.Image;
                        dealercard2score = 2;
                        break;

                    case 3:
                        pictureBox1.Image = i.pictureBox3.Image;
                        dealercard2score = 3;
                        break;

                    case 4:
                        pictureBox1.Image = i.pictureBox4.Image;
                        dealercard2score = 4;
                        break;


                    case 5:
                        pictureBox1.Image = i.pictureBox5.Image;
                        dealercard2score = 5;
                        break;

                    case 6:
                        pictureBox1.Image = i.pictureBox6.Image;
                        dealercard2score = 6;
                        break;

                    case 7:
                        pictureBox1.Image = i.pictureBox7.Image;
                        dealercard2score = 7;
                        break;

                    case 8:
                        pictureBox5.Image = i.pictureBox8.Image;
                        dealercard2score = 8;
                        break;

                    case 9:
                        pictureBox1.Image = i.pictureBox9.Image;
                        dealercard2score = 9;
                        break;

                    case 10:
                        pictureBox1.Image = i.pictureBox10.Image;
                        dealercard2score = 10;
                        break;

                    case 11:
                        pictureBox1.Image = i.pictureBox11.Image;
                        dealercard2score = 10;
                        break;

                    case 12:
                        pictureBox1.Image = i.pictureBox12.Image;
                        dealercard2score = 10;
                        break;

                    case 13:
                        pictureBox1.Image = i.pictureBox13.Image;
                        dealercard2score = 10;
                        break;




                }

                dealerscore = dealercard1score + dealercard2score + dealercard3score;
                label5.Text = dealerscore.ToString();

                if (dealerscore <= 16)
                {
                    // Random random = new Random();
                    // images i = new images();

                    pic6 = random.Next(1, 14);
                    switch (pic6)
                    {
                        case 1:
                            pictureBox6.Image = i.pictureBox1.Image;
                            dealercard3score = 11;
                            break;

                        case 2:
                            pictureBox6.Image = i.pictureBox2.Image;
                            dealercard3score = 2;
                            break;

                        case 3:
                            pictureBox6.Image = i.pictureBox3.Image;
                            dealercard3score = 3;
                            break;

                        case 4:
                            pictureBox6.Image = i.pictureBox4.Image;
                            dealercard3score = 4;
                            break;


                        case 5:
                            pictureBox6.Image = i.pictureBox5.Image;
                            dealercard3score = 5;
                            break;

                        case 6:
                            pictureBox6.Image = i.pictureBox6.Image;
                            dealercard3score = 6;
                            break;

                        case 7:
                            pictureBox6.Image = i.pictureBox7.Image;
                            dealercard3score = 7;
                            break;

                        case 8:
                            pictureBox6.Image = i.pictureBox8.Image;
                            dealercard3score = 8;
                            break;

                        case 9:
                            pictureBox6.Image = i.pictureBox9.Image;
                            dealercard3score = 9;
                            break;

                        case 10:
                            pictureBox6.Image = i.pictureBox10.Image;
                            dealercard3score = 10;
                            break;

                        case 11:
                            pictureBox6.Image = i.pictureBox11.Image;
                            dealercard3score = 10;
                            break;

                        case 12:
                            pictureBox6.Image = i.pictureBox12.Image;
                            dealercard3score = 10;
                            break;

                        case 13:
                            pictureBox6.Image = i.pictureBox13.Image;
                            dealercard3score = 10;
                            break;




                    }
                    pictureBox6.Show();
                    dealerscore = dealercard1score + dealercard2score + dealercard3score;
                    label5.Text = dealerscore.ToString();

                    if (dealerscore < score)

                    {
                        finalbalance = userbalance + (2 * betmoney);
                        finaluserbalance = finalbalance.ToString();

                        label3.Text = finaluserbalance;

                        DialogResult r;

                        r = MessageBox.Show(" Would you like to start a new Game ?", "Congatulations! Your score is higher than dealer's score & you win twice your bet money ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (r == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (r == DialogResult.Yes)

                        {
                            button6.Hide();
                            dealercard1score = 0;
                            dealercard2score = 0;
                            dealercard3score = 0;
                            score = 0;
                            dealerscore = 0;
                            card1score = 0;
                            card2score = 0;
                            fscore = score.ToString();
                            label4.Text = fscore;
                            label5.Text = dealerscore.ToString();
                            button1.Show();
                            button3.Show();
                            button4.Show();
                            label4.Hide();
                            label5.Hide();
                            pictureBox1.Hide();
                            pictureBox3.Hide();
                            pictureBox4.Hide();
                            pictureBox6.Hide();
                            pictureBox5.Hide();
                            pictureBox7.Hide();



                        }

                    }


                    if (dealerscore > score)

                    {

                        finalbalance = userbalance - betmoney;
                        finaluserbalance = finalbalance.ToString();

                        label3.Text = finaluserbalance;

                        DialogResult r;

                        r = MessageBox.Show(" Would you like to start a new Game ?", "Sorry! Your score is less than dealer's score & you lose your bet money ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (r == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (r == DialogResult.Yes)

                        {
                            button6.Hide();
                            dealercard1score = 0;
                            dealercard2score = 0;
                            dealercard3score = 0;
                            score = 0;
                            dealerscore = 0;
                            card1score = 0;

                            card2score = 0;
                            fscore = score.ToString();
                            label4.Text = fscore;
                            label5.Text = dealerscore.ToString();
                            button1.Show();
                            button3.Show();
                            button4.Show();
                            label4.Hide();
                            label5.Hide();
                            pictureBox1.Hide();
                            pictureBox3.Hide();
                            pictureBox4.Hide();
                            pictureBox6.Hide();
                            pictureBox5.Hide();
                            pictureBox7.Hide();


                        }



                    }

                    if (dealerscore == score)
                    {
                        finalbalance = userbalance;
                        finaluserbalance = finalbalance.ToString();

                        label3.Text = finaluserbalance;

                        DialogResult r;

                        r = MessageBox.Show(" Would you like to start a new Game ?", "Its a tie, you can keep your bet money", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (r == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (r == DialogResult.Yes)

                        {
                            button6.Hide();
                            dealercard1score = 0;
                            dealercard2score = 0;
                            dealercard3score = 0;
                            score = 0;
                            dealerscore = 0;
                            card1score = 0;
                            card2score = 0;
                            fscore = score.ToString();
                            label4.Text = fscore;
                            label5.Text = dealerscore.ToString();
                            button1.Show();
                            button3.Show();
                            button4.Show();
                            label4.Hide();
                            label5.Hide();
                            pictureBox1.Hide();
                            pictureBox3.Hide();
                            pictureBox4.Hide();
                            pictureBox6.Hide();
                            pictureBox5.Hide();
                            pictureBox7.Hide();



                        }
                    }

                }

                if (dealerscore > 16 && dealerscore <= 21)

                {
                    if (dealerscore == score)
                    {
                        finalbalance = userbalance + (2 * betmoney);
                        finaluserbalance = finalbalance.ToString();

                        label3.Text = finaluserbalance;

                        DialogResult r;

                        r = MessageBox.Show(" Would you like to start a new Game ?", "Its a tie, you can keep your bet money", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (r == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (r == DialogResult.Yes)

                        {
                            button6.Hide();
                            dealercard1score = 0;
                            dealercard2score = 0;
                            dealercard3score = 0;
                            score = 0;
                            dealerscore = 0;
                            card1score = 0;
                            card2score = 0;
                            fscore = score.ToString();
                            label4.Text = fscore;
                            label5.Text = dealerscore.ToString();
                            button1.Show();
                            button3.Show();
                            button4.Show();
                            label4.Hide();
                            label5.Hide();
                            pictureBox1.Hide();
                            pictureBox3.Hide();
                            pictureBox4.Hide();
                            pictureBox6.Hide();
                            pictureBox5.Hide();
                            pictureBox7.Hide();



                        }
                    }

                    if (dealerscore > score)

                    {

                        finalbalance = userbalance - betmoney;
                        finaluserbalance = finalbalance.ToString();

                        label3.Text = finaluserbalance;

                        DialogResult r;

                        r = MessageBox.Show(" Would you like to start a new Game ?", "Sorry! Your score is less than dealer's score & you lose your bet money ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (r == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (r == DialogResult.Yes)

                        {
                            button6.Hide();
                            dealercard1score = 0;
                            dealercard2score = 0;
                            dealercard3score = 0;
                            score = 0;
                            dealerscore = 0;
                            card1score = 0;

                            card2score = 0;
                            fscore = score.ToString();
                            label4.Text = fscore;
                            label5.Text = dealerscore.ToString();
                            button1.Show();
                            button3.Show();
                            button4.Show();
                            label4.Hide();
                            label5.Hide();
                            pictureBox1.Hide();
                            pictureBox3.Hide();
                            pictureBox4.Hide();
                            pictureBox6.Hide();
                            pictureBox5.Hide();
                            pictureBox7.Hide();


                        }



                    }



                    if (dealerscore < score)

                    {
                        finalbalance = userbalance + (2 * betmoney);
                        finaluserbalance = finalbalance.ToString();

                        label3.Text = finaluserbalance;

                        DialogResult r;

                        r = MessageBox.Show(" Would you like to start a new Game ?", "Congatulations! Your score is higher than dealer's score & you win twice your bet money ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (r == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (r == DialogResult.Yes)

                        {
                            button6.Hide();
                            dealercard1score = 0;
                            dealercard2score = 0;
                            dealercard3score = 0;
                            score = 0;
                            dealerscore = 0;
                            card1score = 0;
                            card2score = 0;
                            fscore = score.ToString();
                            label4.Text = fscore;
                            label5.Text = dealerscore.ToString();
                            button1.Show();
                            button3.Show();
                            button4.Show();
                            label4.Hide();
                            label5.Hide();
                            pictureBox1.Hide();
                            pictureBox3.Hide();
                            pictureBox4.Hide();
                            pictureBox6.Hide();
                            pictureBox5.Hide();
                            pictureBox7.Hide();



                        }

                    }






                }




                if (dealerscore > 21)
                {

                    finalbalance = userbalance + (2 * betmoney);
                    finaluserbalance = finalbalance.ToString();

                    label3.Text = finaluserbalance;

                    DialogResult r;

                    r = MessageBox.Show(" Would you like to start a new Game ?", "Congatulations! Delaer busted. You win twice your bet money ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (r == DialogResult.No)
                    {
                        this.Close();
                    }

                    if (r == DialogResult.Yes)

                    {
                        button6.Hide();
                        dealercard1score = 0;
                        dealercard2score = 0;
                        dealercard3score = 0;
                        score = 0;
                        dealerscore = 0;
                        card1score = 0;
                        card2score = 0;
                        button1.Show();
                        button3.Show();
                        button4.Show();
                        fscore = score.ToString();
                        label4.Text = fscore;
                        label5.Text = dealerscore.ToString();
                        label4.Hide();
                        label5.Hide();
                        pictureBox1.Hide();
                        pictureBox3.Hide();
                        pictureBox4.Hide();
                        pictureBox6.Hide();
                        pictureBox5.Hide();
                        pictureBox7.Hide();



                    }
                }
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                button6.Hide();
                label6.Hide();
                button5.Hide();
                Random random = new Random();
                images i = new images();

                pic7 = random.Next(1, 14);
                switch (pic7)
                {
                    case 1:
                        pictureBox7.Image = i.pictureBox1.Image;
                        card3score = 11;
                        break;

                    case 2:
                        pictureBox7.Image = i.pictureBox2.Image;
                        card3score = 2;
                        break;

                    case 3:
                        pictureBox7.Image = i.pictureBox3.Image;
                        card3score = 3;
                        break;

                    case 4:
                        pictureBox7.Image = i.pictureBox4.Image;
                        card3score = 4;
                        break;


                    case 5:
                        pictureBox7.Image = i.pictureBox5.Image;
                        card3score = 5;
                        break;

                    case 6:
                        pictureBox7.Image = i.pictureBox6.Image;
                        card3score = 6;
                        break;

                    case 7:
                        pictureBox7.Image = i.pictureBox7.Image;
                        card3score = 7;
                        break;

                    case 8:
                        pictureBox7.Image = i.pictureBox8.Image;
                        card3score = 8;
                        break;

                    case 9:
                        pictureBox7.Image = i.pictureBox9.Image;
                        card3score = 9;
                        break;

                    case 10:
                        pictureBox7.Image = i.pictureBox10.Image;
                        card3score = 10;
                        break;

                    case 11:
                        pictureBox7.Image = i.pictureBox11.Image;
                        card3score = 10;
                        break;

                    case 12:
                        pictureBox7.Image = i.pictureBox12.Image;
                        card3score = 10;
                        break;

                    case 13:
                        pictureBox7.Image = i.pictureBox13.Image;
                        card3score = 10;
                        break;




                }


                score = card1score + card2score + card3score;
                fscore = score.ToString();
                label4.Text = fscore;
                label4.Show();
                pictureBox7.Show();


                button6.Hide();
                label6.Hide();
                // Random random = new Random();
                //  images i = new images();

                pic1 = random.Next(1, 14);
                switch (pic1)
                {
                    case 1:
                        pictureBox1.Image = i.pictureBox1.Image;
                        dealercard2score = 11;
                        break;

                    case 2:
                        pictureBox1.Image = i.pictureBox2.Image;
                        dealercard2score = 2;
                        break;

                    case 3:
                        pictureBox1.Image = i.pictureBox3.Image;
                        dealercard2score = 3;
                        break;

                    case 4:
                        pictureBox1.Image = i.pictureBox4.Image;
                        dealercard2score = 4;
                        break;


                    case 5:
                        pictureBox1.Image = i.pictureBox5.Image;
                        dealercard2score = 5;
                        break;

                    case 6:
                        pictureBox1.Image = i.pictureBox6.Image;
                        dealercard2score = 6;
                        break;

                    case 7:
                        pictureBox1.Image = i.pictureBox7.Image;
                        dealercard2score = 7;
                        break;

                    case 8:
                        pictureBox5.Image = i.pictureBox8.Image;
                        dealercard2score = 8;
                        break;

                    case 9:
                        pictureBox1.Image = i.pictureBox9.Image;
                        dealercard2score = 9;
                        break;

                    case 10:
                        pictureBox1.Image = i.pictureBox10.Image;
                        dealercard2score = 10;
                        break;

                    case 11:
                        pictureBox1.Image = i.pictureBox11.Image;
                        dealercard2score = 10;
                        break;

                    case 12:
                        pictureBox1.Image = i.pictureBox12.Image;
                        dealercard2score = 10;
                        break;

                    case 13:
                        pictureBox1.Image = i.pictureBox13.Image;
                        dealercard2score = 10;
                        break;




                }

                dealerscore = dealercard1score + dealercard2score + dealercard3score;
                label5.Text = dealerscore.ToString();

                if (dealerscore <= 16)
                {
                    // Random random = new Random();
                    // images i = new images();

                    pic6 = random.Next(1, 14);
                    switch (pic6)
                    {
                        case 1:
                            pictureBox6.Image = i.pictureBox1.Image;
                            dealercard3score = 11;
                            break;

                        case 2:
                            pictureBox6.Image = i.pictureBox2.Image;
                            dealercard3score = 2;
                            break;

                        case 3:
                            pictureBox6.Image = i.pictureBox3.Image;
                            dealercard3score = 3;
                            break;

                        case 4:
                            pictureBox6.Image = i.pictureBox4.Image;
                            dealercard3score = 4;
                            break;


                        case 5:
                            pictureBox6.Image = i.pictureBox5.Image;
                            dealercard3score = 5;
                            break;

                        case 6:
                            pictureBox6.Image = i.pictureBox6.Image;
                            dealercard3score = 6;
                            break;

                        case 7:
                            pictureBox6.Image = i.pictureBox7.Image;
                            dealercard3score = 7;
                            break;

                        case 8:
                            pictureBox6.Image = i.pictureBox8.Image;
                            dealercard3score = 8;
                            break;

                        case 9:
                            pictureBox6.Image = i.pictureBox9.Image;
                            dealercard3score = 9;
                            break;

                        case 10:
                            pictureBox6.Image = i.pictureBox10.Image;
                            dealercard3score = 10;
                            break;

                        case 11:
                            pictureBox6.Image = i.pictureBox11.Image;
                            dealercard3score = 10;
                            break;

                        case 12:
                            pictureBox6.Image = i.pictureBox12.Image;
                            dealercard3score = 10;
                            break;

                        case 13:
                            pictureBox6.Image = i.pictureBox13.Image;
                            dealercard3score = 10;
                            break;




                    }

                    dealerscore = dealercard1score + dealercard2score + dealercard3score;
                    label5.Text = dealerscore.ToString();

                    if (dealerscore > score)
                    {
                        finalbalance = userbalance - betmoney;
                        finaluserbalance = finalbalance.ToString();

                        label3.Text = finaluserbalance;

                        DialogResult r;

                        r = MessageBox.Show(" Would you like to start a new Game ?", "Sorry! Your score is less than dealer's score & you lose your bet money ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (r == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (r == DialogResult.Yes)

                        {
                            button6.Hide();
                            dealercard1score = 0;
                            dealercard2score = 0;
                            dealercard3score = 0;
                            score = 0;
                            dealerscore = 0;
                            card1score = 0;

                            card2score = 0;
                            fscore = score.ToString();
                            label4.Text = fscore;
                            label5.Text = dealerscore.ToString();
                            button1.Show();
                            button3.Show();
                            button4.Show();
                            label4.Hide();
                            label5.Hide();
                            pictureBox1.Hide();
                            pictureBox3.Hide();
                            pictureBox4.Hide();
                            pictureBox6.Hide();
                            pictureBox5.Hide();
                            pictureBox7.Hide();
                            button5.Hide();


                        }

                    }

                    if (dealerscore < score && score <= 21)

                    {
                        finalbalance = userbalance + (2 * betmoney);
                        finaluserbalance = finalbalance.ToString();

                        label3.Text = finaluserbalance;

                        DialogResult r;

                        r = MessageBox.Show(" Would you like to start a new Game ?", "Congatulations! Your score is higher than dealer's score & you win twice your bet money ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (r == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (r == DialogResult.Yes)

                        {
                            button6.Hide();
                            dealercard1score = 0;
                            dealercard2score = 0;
                            dealercard3score = 0;
                            score = 0;
                            dealerscore = 0;
                            card1score = 0;
                            card2score = 0;
                            fscore = score.ToString();
                            label4.Text = fscore;
                            label5.Text = dealerscore.ToString();
                            button1.Show();
                            button3.Show();
                            button4.Show();
                            label4.Hide();
                            label5.Hide();
                            pictureBox1.Hide();
                            pictureBox3.Hide();
                            pictureBox4.Hide();
                            pictureBox6.Hide();
                            pictureBox5.Hide();
                            pictureBox7.Hide();



                        }
                    }

                    if (dealerscore < score && score > 21)

                    {
                        finalbalance = userbalance - betmoney;
                        finaluserbalance = finalbalance.ToString();

                        label3.Text = finaluserbalance;

                        DialogResult r;

                        r = MessageBox.Show(" Would you like to start a new Game ?", "Black Jack, you are busted & you lose your bet money ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (r == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (r == DialogResult.Yes)

                        {
                            button6.Hide();
                            dealercard1score = 0;
                            dealercard2score = 0;
                            dealercard3score = 0;
                            score = 0;
                            dealerscore = 0;
                            card1score = 0;
                            card2score = 0;
                            fscore = score.ToString();
                            label4.Text = fscore;
                            label5.Text = dealerscore.ToString();
                            button1.Show();
                            button3.Show();
                            button4.Show();
                            label4.Hide();
                            label5.Hide();
                            pictureBox1.Hide();
                            pictureBox3.Hide();
                            pictureBox4.Hide();
                            pictureBox6.Hide();
                            pictureBox5.Hide();
                            pictureBox7.Hide();



                        }
                    }



                    if (dealerscore == score)

                    {
                        finalbalance = userbalance + (2 * betmoney);
                        finaluserbalance = finalbalance.ToString();

                        label3.Text = finaluserbalance;

                        DialogResult r;

                        r = MessageBox.Show(" Would you like to start a new Game ?", "Its a tie, you get back your bet money ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (r == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (r == DialogResult.Yes)

                        {
                            button6.Hide();
                            dealercard1score = 0;
                            dealercard2score = 0;
                            dealercard3score = 0;
                            score = 0;
                            dealerscore = 0;
                            card1score = 0;
                            card2score = 0;
                            fscore = score.ToString();
                            label4.Text = fscore;
                            label5.Text = dealerscore.ToString();
                            button1.Show();
                            button3.Show();
                            button4.Show();
                            label4.Hide();
                            label5.Hide();
                            pictureBox1.Hide();
                            pictureBox3.Hide();
                            pictureBox4.Hide();
                            pictureBox6.Hide();
                            pictureBox5.Hide();
                            pictureBox7.Hide();



                        }
                    }

                }

                if (dealerscore > 16 && dealerscore <= 21)

                {

                    if (dealerscore == score)

                    {
                        finalbalance = userbalance + (2 * betmoney);
                        finaluserbalance = finalbalance.ToString();

                        label3.Text = finaluserbalance;

                        DialogResult r;

                        r = MessageBox.Show(" Would you like to start a new Game ?", "Its a tie, you get back your bet money ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (r == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (r == DialogResult.Yes)

                        {
                            button6.Hide();
                            dealercard1score = 0;
                            dealercard2score = 0;
                            dealercard3score = 0;
                            score = 0;
                            dealerscore = 0;
                            card1score = 0;
                            card2score = 0;
                            fscore = score.ToString();
                            label4.Text = fscore;
                            label5.Text = dealerscore.ToString();
                            button1.Show();
                            button3.Show();
                            button4.Show();
                            label4.Hide();
                            label5.Hide();
                            pictureBox1.Hide();
                            pictureBox3.Hide();
                            pictureBox4.Hide();
                            pictureBox6.Hide();
                            pictureBox5.Hide();
                            pictureBox7.Hide();



                        }
                    }
                    if (dealerscore > score)

                    {

                        finalbalance = userbalance - betmoney;
                        finaluserbalance = finalbalance.ToString();

                        label3.Text = finaluserbalance;

                        DialogResult r;

                        r = MessageBox.Show(" Would you like to start a new Game ?", "Sorry! Your score is less than dealer's score & you lose your bet money ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (r == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (r == DialogResult.Yes)

                        {
                            button6.Hide();
                            dealercard1score = 0;
                            dealercard2score = 0;
                            dealercard3score = 0;
                            score = 0;
                            dealerscore = 0;
                            card1score = 0;

                            card2score = 0;
                            fscore = score.ToString();
                            label4.Text = fscore;
                            label5.Text = dealerscore.ToString();
                            button1.Show();
                            button3.Show();
                            button4.Show();
                            label4.Hide();
                            label5.Hide();
                            pictureBox1.Hide();
                            pictureBox3.Hide();
                            pictureBox4.Hide();
                            pictureBox6.Hide();
                            pictureBox5.Hide();
                            pictureBox7.Hide();
                            button5.Hide();


                        }



                    }



                    if (dealerscore < score)

                    {
                        finalbalance = userbalance + (2 * betmoney);
                        finaluserbalance = finalbalance.ToString();

                        label3.Text = finaluserbalance;

                        DialogResult r;

                        r = MessageBox.Show(" Would you like to start a new Game ?", "Congatulations! Your score is higher than dealer's score & you win twice your bet money ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (r == DialogResult.No)
                        {
                            this.Close();
                        }

                        if (r == DialogResult.Yes)

                        {
                            button6.Hide();
                            dealercard1score = 0;
                            dealercard2score = 0;
                            dealercard3score = 0;
                            score = 0;
                            dealerscore = 0;
                            card1score = 0;
                            card2score = 0;
                            fscore = score.ToString();
                            label4.Text = fscore;
                            label5.Text = dealerscore.ToString();
                            button1.Show();
                            button3.Show();
                            button4.Show();
                            label4.Hide();
                            label5.Hide();
                            pictureBox1.Hide();
                            pictureBox3.Hide();
                            pictureBox4.Hide();
                            pictureBox6.Hide();
                            pictureBox5.Hide();
                            pictureBox7.Hide();



                        }

                    }



                }


                if (dealerscore > 21)
                {

                    finalbalance = userbalance + (2 * betmoney);
                    finaluserbalance = finalbalance.ToString();

                    label3.Text = finaluserbalance;

                    DialogResult r;

                    r = MessageBox.Show(" Would you like to start a new Game ?", "Congatulations! Delaer busted. You win twice your bet money ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (r == DialogResult.No)
                    {
                        this.Close();
                    }

                    if (r == DialogResult.Yes)

                    {
                        button6.Hide();
                        dealercard1score = 0;
                        dealercard2score = 0;
                        dealercard3score = 0;
                        score = 0;
                        dealerscore = 0;
                        card1score = 0;
                        card2score = 0;
                        button1.Show();
                        button3.Show();
                        button4.Show();
                        fscore = score.ToString();
                        label4.Text = fscore;
                        label5.Text = dealerscore.ToString();
                        label4.Hide();
                        label5.Hide();
                        pictureBox1.Hide();
                        pictureBox3.Hide();
                        pictureBox4.Hide();
                        pictureBox6.Hide();
                        pictureBox5.Hide();
                        pictureBox7.Hide();
                        button5.Hide();


                    }
                }


                score = card1score + card2score + card3score;
                fscore = score.ToString();
                label4.Text = fscore;
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
