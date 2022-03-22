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
namespace Lab_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> studentList = new List<Student>();
                    
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("ID\n\n");
            listBox2.Items.Add("Name\n\n");
            listBox3.Items.Add("Percentage\n\n");
            listBox4.Items.Add("Grade\n\n");
            using (var reader = new StreamReader(@"D:\Swe 4202\SWE4201MarkSheet - SWE4201MarkSheet (2).csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var info = line.Split(',');
                    Student st = new Student();
                    st.id = info[0];               
                    st.name = info[1];
                    st.attendance = info[2];
                    st.mid = info[7];
                    st.final = info[8];
                    st.viva = info[9];
                    st.quiz[0] = Convert.ToDouble(info[3]);
                    st.quiz[1] = Convert.ToDouble(info[4]);
                    st.quiz[2] = Convert.ToDouble(info[5]);
                    st.quiz[3] = Convert.ToDouble(info[6]);
                    st.percentage = ((Convert.ToDouble(st.attendance)+st.calculateQuiz(st.quiz)+Convert.ToDouble(st.mid)+Convert.ToDouble(st.final)+Convert.ToDouble(st.viva))/300)*100;
                    st.getGrade(st.percentage);
                    studentList.Add(st);
                    
                    listBox1.Items.Add(st.id);
                    listBox2.Items.Add(st.name);
                    listBox3.Items.Add(Math.Round(st.percentage,2) + "%");
                    listBox4.Items.Add(st.grade);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                    var stu = from st3 in studentList
                           where st3.id == textBox1.Text
                           select st3;
                 Student st2 = stu.First();
                    label1.Text = "Id:    " + st2.id.ToString();
                    label2.Text = "Name:  " + st2.name;
                    label3.Text = "Quiz1: " + st2.quiz[0];
                    label4.Text = "Quiz2: " + st2.quiz[1];
                    label5.Text = "Quiz3: " + st2.quiz[2];
                    label6.Text = "Quiz4: " + st2.quiz[3];
                    label7.Text = "Mid:   " + st2.mid;
                    label8.Text = "Final: " + st2.final;
                    label9.Text = "Viva:  " + st2.viva;
                    label10.Text = "Attendance:" + st2.attendance;
                    label11.Text = "Grade: " + st2.grade;
                
        }
    }
}
