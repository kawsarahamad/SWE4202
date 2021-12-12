using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label36.Text = textBox4.Text;
            double Quiz1 = Convert.ToDouble(textBox5.Text);
            double Quiz2 = Convert.ToDouble(textBox6.Text);
            double Quiz3 = Convert.ToDouble(textBox7.Text);
            double Quiz4 = Convert.ToDouble(textBox8.Text);
            double[] Quiz = { Quiz1, Quiz2, Quiz3, Quiz4 };
            double min_value = Quiz[0];
            for(int i=0; i<4; i++) {
            if(Quiz[i]<min_value)
            min_value = Quiz[i];
            
            }
            double total_quiz_marks = Quiz1 + Quiz2 + Quiz3 + Quiz4 - min_value;
            label30.Text = total_quiz_marks.ToString();
            label34.Text = textBox9.Text;
            label32.Text = textBox10.Text;
            double attendance_marks = Convert.ToDouble(textBox4.Text);
            double mid_marks = Convert.ToDouble(textBox9.Text);
            double final_marks = Convert.ToDouble(textBox10.Text);
            double total_marks = attendance_marks + total_quiz_marks+ mid_marks+ final_marks;
            label33.Text = total_marks.ToString();
            double percentage = (total_marks / 300)*100;
           

            if (percentage >= 80)
                label35.Text = "A+";
            else if(percentage >=75 && percentage <80)
                label35.Text = "A";
            else if (percentage >= 70 && percentage < 75)
                label35.Text = "A-";
            else if (percentage >= 65 && percentage < 70)
                label35.Text = "B+";
            else if (percentage >= 60 && percentage < 65)
                label35.Text = "B";
            else if (percentage >= 55 && percentage < 60)
                label35.Text = "B-";
            else if (percentage >= 50 && percentage < 55)
                label35.Text = "C+";
            else if (percentage >= 45 && percentage < 50)
                label35.Text = "C";
            else if (percentage >= 40 && percentage < 45)
                label35.Text = "D";
            else if (percentage <40)
                label35.Text = "F";
            int percentage2=(int)percentage;
            label37.Text = textBox1.Text+ " obtained "+ percentage2.ToString()+ " % marks ";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox7.Clear();
            textBox10.Clear();

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }
    }
}
