using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 List<Lecturer> Lecturerlist = new List<Lecturer>();
 List<Professor> Professorlist = new List<Professor>();
 List<Student> Studentlist = new List<Student>();
 List<Course> Courselist = new List<Course>();
        private void addTeacher(object sender, EventArgs e)
        {
            if (comboBox_teacherType.Text == "Lecturer")
            {
                Lecturer new_Lecturer = new Lecturer(textBox_teacherName.Text, comboBox_teacherType.Text, textBox_teacherContact.Text);
                Lecturerlist.Add(new_Lecturer);
                comboBox_Teacher.Items.Add(new_Lecturer.Teacher_name);
                MessageBox.Show("You have added a lecturer");

            }
            else
            {
                Professor new_professor = new Professor(textBox_teacherName.Text, comboBox_teacherType.Text, textBox_teacherContact.Text);
                Professorlist.Add(new_professor);
                comboBox_Teacher.Items.Add(new_professor.Teacher_name);
                MessageBox.Show("You have added a Professor");
            }
        }

        private void addCourse(object sender, EventArgs e)
        { 
               Course new_course = new Course(textBox_code.Text,textBox_title.Text,comboBox_type.Text,comboBox_sem.Text,comboBox_Teacher.Text);
               Courselist.Add(new_course);
               comboBox_Course.Items.Add(new_course.course_title);
               comboBox_Teacher_Info.Items.Add(new_course.course_Teacher);
               
               MessageBox.Show("You have added a new course");

        }

        private void addStudent(object sender, EventArgs e)
        {
            Student new_Student = new Student(textBox_studentName.Text,comboBox_studentSem.Text,comboBox_Course.Text,textBox_studentContact.Text);
            Studentlist.Add(new_Student);
            comboBox_studentInfo.Items.Add(new_Student.Student_name);
           // Student_Info.Items.Add(new_Student);
            MessageBox.Show("You have enrolled in "+comboBox_Course.Text+" course successfuly.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string st_name = comboBox_studentInfo.Text;
            bool flag=false;
            foreach(Student enrolled_student in Studentlist)
            {
                if (st_name == enrolled_student.Student_name)
                {
                    flag=true;
                    Student_Info.Items.Add("Student name:" + enrolled_student.Student_name);
                    Student_Info.Items.Add("Enrolled course:" + enrolled_student.Student_course);
                    Student_Info.Items.Add("Semester: " + enrolled_student.Student_Sem);
                    Student_Info.Items.Add("Contact No: " +enrolled_student.Student_Contact_No);
                }
               
            }
            if (flag == false)
            {
                MessageBox.Show("The student is not found.");
            }

        }

        private void TeacherInfo(object sender, EventArgs e)
        {
            /*string Teacher_info =comboBox_Teacher_Info.Text;
            bool Flag = false;
            foreach(Lecturer enrolled_lecturer in Lecturerlist)
            {
                if (Teacher_info == enrolled_lecturer.Teacher_name)
                {
                    Flag=true;
                    listBox1.Items.Add("Teacher Name:"+enrolled_lecturer.Teacher_name);
                    listBox1.Items.Add("Credit:"+)
                }
            }*/

        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i=0; i<Professorlist.Count; i++)
            {
                comboBox_Teacher.Items.Add(Professorlist[i].Teacher_name);
            }
        }
    }
}
