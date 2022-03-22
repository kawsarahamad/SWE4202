using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_11_Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public string Pl, Cm;
        public bool flag_Pl = false;
        public bool flag_Cm = false;
        public int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            if((button2.Text == "O") || (button2.Text == "X"))
            {
                MessageBox.Show("Select another button.");
            }
            else
            {
                button2.Text = Pl;
                if(button1.Text == "B1")
                {
                    button1.Text = Cm;
               }
      
                else if(button3.Text == "B3")
                {
                    button3.Text = Cm;
                }
                else if (button4.Text == "B4")
                {
                    button4.Text = Cm;
                }
                else if (button5.Text == "B5")
                {
                    button5.Text = Cm;
                }
                else if (button6.Text == "B6")
                {
                    button6.Text = Cm;
                }
                else if (button7.Text == "B7")
                {
                    button7.Text = Cm;
                }
                else if (button8.Text == "B8")
                {
                    button8.Text = Cm;
                }
                else if (button9.Text == "B9")
                {
                    button9.Text = Cm;
                }
            }
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }

            else if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((button1.Text == "O") || (button1.Text == "X"))
            {
                MessageBox.Show("Select another button.");
            }
            else
            {
                button1.Text = Pl;
                if (button2.Text == "B2")
                {
                    button2.Text = Cm;
                }

                else if (button3.Text == "B3")
                {
                    button3.Text = Cm;
                }
                else if (button4.Text == "B4")
                {
                    button4.Text = Cm;
                }
                else if (button5.Text == "B5")
                {
                    button5.Text = Cm;
                }
                else if (button6.Text == "B6")
                {
                    button6.Text = Cm;
                }
                else if (button7.Text == "B7")
                {
                    button7.Text = Cm;
                }
                else if (button8.Text == "B8")
                {
                    button8.Text = Cm;
                }
                else if (button9.Text == "B9")
                {
                    button9.Text = Cm;
                }
            }
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }

            else if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }

        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((button3.Text == "O") || (button3.Text == "X"))
            {
                MessageBox.Show("Select another button.");
            }
            else
            {
                button3.Text = Pl;
                if (button1.Text == "B1")
                {
                    button1.Text = Cm;
                }

                else if (button2.Text == "B2")
                {
                    button2.Text = Cm;
                }
                else if (button4.Text == "B4")
                {
                    button4.Text = Cm;
                }
                else if (button5.Text == "B5")
                {
                    button5.Text = Cm;
                }
                else if (button6.Text == "B6")
                {
                    button6.Text = Cm;
                }
                else if (button7.Text == "B7")
                {
                    button7.Text = Cm;
                }
                else if (button8.Text == "B8")
                {
                    button8.Text = Cm;
                }
                else if (button9.Text == "B9")
                {
                    button9.Text = Cm;
                }
            }
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }

            else if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            

        }
    }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((button4.Text == "O") || (button4.Text == "X"))
            {
                MessageBox.Show("Select another button.");
            }
            else
            {
                button4.Text = Pl;
                if (button1.Text == "B1")
                {
                    button1.Text = Cm;
                }

                else if (button3.Text == "B3")
                {
                    button3.Text = Cm;
                }
                else if (button2.Text == "B2")
                {
                    button2.Text = Cm;
                }
                else if (button5.Text == "B5")
                {
                    button5.Text = Cm;
                }
                else if (button6.Text == "B6")
                {
                    button6.Text = Cm;
                }
                else if (button7.Text == "B7")
                {
                    button7.Text = Cm;
                }
                else if (button8.Text == "B8")
                {
                    button8.Text = Cm;
                }
                else if (button9.Text == "B9")
                {
                    button9.Text = Cm;
                }
            }
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }

            else if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            

        }
    }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((button5.Text == "O") || (button5.Text == "X"))
            {
                MessageBox.Show("Select another button.");
            }
            else
            {
                button5.Text = Pl;
                if (button1.Text == "B1")
                {
                    button1.Text = Cm;
                }

                else if (button3.Text == "B3")
                {
                    button3.Text = Cm;
                }
                else if (button4.Text == "B4")
                {
                    button4.Text = Cm;
                }
                else if (button2.Text == "B2")
                {
                    button2.Text = Cm;
                }
                else if (button6.Text == "B6")
                {
                    button6.Text = Cm;
                }
                else if (button7.Text == "B7")
                {
                    button7.Text = Cm;
                }
                else if (button8.Text == "B8")
                {
                    button8.Text = Cm;
                }
                else if (button9.Text == "B9")
                {
                    button9.Text = Cm;
                }
            }
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }

            else if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            

        }
    }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((button6.Text == "O") || (button6.Text == "X"))
            {
                MessageBox.Show("Select another button.");
            }
            else
            {
                button6.Text = Pl;
                if (button1.Text == "B1")
                {
                    button1.Text = Cm;
                }

                else if (button3.Text == "B3")
                {
                    button3.Text = Cm;
                }
                else if (button4.Text == "B4")
                {
                    button4.Text = Cm;
                }
                else if (button5.Text == "B5")
                {
                    button5.Text = Cm;
                }
                else if (button2.Text == "B2")
                {
                    button2.Text = Cm;
                }
                else if (button7.Text == "B7")
                {
                    button7.Text = Cm;
                }
                else if (button8.Text == "B8")
                {
                    button8.Text = Cm;
                }
                else if (button9.Text == "B9")
                {
                    button9.Text = Cm;
                }
            }
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }

            else if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            

        }
    }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((button7.Text == "O") || (button7.Text == "X"))
            {
                MessageBox.Show("Select another button.");
            }
            else
            {
                button7.Text = Pl;
                if (button1.Text == "B1")
                {
                    button1.Text = Cm;
                }

                else if (button3.Text == "B3")
                {
                    button3.Text = Cm;
                }
                else if (button4.Text == "B4")
                {
                    button4.Text = Cm;
                }
                else if (button5.Text == "B5")
                {
                    button5.Text = Cm;
                }
                else if (button6.Text == "B6")
                {
                    button6.Text = Cm;
                }
                else if (button2.Text == "B2")
                {
                    button2.Text = Cm;
                }
                else if (button8.Text == "B8")
                {
                    button8.Text = Cm;
                }
                else if (button9.Text == "B9")
                {
                    button9.Text = Cm;
                }
            }
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }

            else if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            

        }
    }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((button8.Text == "O") || (button8.Text == "X"))
            {
                MessageBox.Show("Select another button.");
            }
            else
            {
                button8.Text = Pl;
                if (button1.Text == "B1")
                {
                    button1.Text = Cm;
                }

                else if (button3.Text == "B3")
                {
                    button3.Text = Cm;
                }
                else if (button4.Text == "B4")
                {
                    button4.Text = Cm;
                }
                else if (button5.Text == "B5")
                {
                    button5.Text = Cm;
                }
                else if (button6.Text == "B6")
                {
                    button6.Text = Cm;
                }
                else if (button7.Text == "B7")
                {
                    button7.Text = Cm;
                }
                else if (button2.Text == "B2")
                {
                    button2.Text = Cm;
                }
                else if (button9.Text == "B9")
                {
                    button9.Text = Cm;
                }
            }
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }

            else if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
                else
                {
                    MessageBox.Show("You have lost");
                    button1.Text = "B1";
                    button2.Text = "B2";
                    button3.Text = "B3";
                    button4.Text = "B4";
                    button5.Text = "B5";
                    button6.Text = "B6";
                    button7.Text = "B7";
                    button8.Text = "B8";
                    button9.Text = "B9";
                }
            }

        
    }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((button9.Text == "O") || (button9.Text == "X"))
            {
                MessageBox.Show("Select another button.");
            }
            else
            {
                button9.Text = Pl;
                if (button1.Text == "B1")
                {
                    button1.Text = Cm;
                }

                else if (button3.Text == "B3")
                {
                    button3.Text = Cm;
                }
                else if (button4.Text == "B4")
                {
                    button4.Text = Cm;
                }
                else if (button5.Text == "B5")
                {
                    button5.Text = Cm;
                }
                else if (button6.Text == "B6")
                {
                    button6.Text = Cm;
                }
                else if (button7.Text == "B7")
                {
                    button7.Text = Cm;
                }
                else if (button8.Text == "B8")
                {
                    button8.Text = Cm;
                }
                else if (button2.Text == "B2")
                {
                    button2.Text = Cm;
                }
            }
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }

            else if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text == Pl)
                {
                    MessageBox.Show("You have won");
                }
                else
                {
                    MessageBox.Show("You have lost");
                }
            

        }
    }

        private void Selectmarker_Click(object sender, EventArgs e)
        {
            if(comboBox_marker.Text == "O")
            {
                Pl="O";
                Cm = "X";
            }
            else if (comboBox_marker.Text == "X")
            {
                Pl = "X";
                Cm = "O";
            }
            if (comboBox_Move.Text == "Player")
            {
               flag_Pl=true;
                MessageBox.Show("You will Play first and your marker is " + Pl.ToString());
            }
            else if(comboBox_Move.Text == "Computer")
            {
                flag_Cm = true;
                MessageBox.Show("Computer will Play first and your marker is" + Pl.ToString());
                
            }
            if (flag_Cm == true)
            {
                button1.Text = Cm;
                a++;
            }
          
        }
    }
}
