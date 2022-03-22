using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_08_Employee_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        List<Manager> managerList = new List<Manager>();
        List<Salesman> salesmenList = new List<Salesman>();
        List<Typewriter> typewriterList = new List<Typewriter>();
        int num = 220000;

        private void addEmployeeonclick(object sender, EventArgs e)
        {
            if(comboBox_Designation.Text == "Manager")
            {
                Manager new_manager = new Manager();
                new_manager.setID(num);
                num++;
                textBox_ID.Text=new_manager.ID;
                new_manager.Name =textBox_Name.Text;
                new_manager.Designation=comboBox_Designation.Text;
                new_manager.Contact=textBox_contact.Text;
                new_manager.salary=Convert.ToDouble(textBox_Salary.Text);
                new_manager.calculateSalary(new_manager.salary, Convert.ToInt32(textBox_Age_of_service.Text));
                new_manager.Date_of_joining=textBox_Joining_Date.Text;
                new_manager.Leaves=Convert.ToDouble(textBox_Leaves.Text);

                managerList.Add(new_manager);
                MessageBox.Show("The Employee has been added successfully");
            }
            else if(comboBox_Designation.Text == "Salesman")
            {
                Salesman new_salesman = new Salesman();
                new_salesman.setID(num);
                num++;
                textBox_ID.Text = new_salesman.ID;
                new_salesman.Name = textBox_Name.Text;
                new_salesman.Designation = comboBox_Designation.Text;
                new_salesman.Contact = textBox_contact.Text;
                new_salesman.salary = Convert.ToDouble(textBox_Salary.Text);
                new_salesman.calculateSalary(new_salesman.salary, Convert.ToInt32(textBox_Age_of_service.Text));
                new_salesman.Date_of_joining = textBox_Joining_Date.Text;
                new_salesman.Leaves = Convert.ToDouble(textBox_Leaves.Text);

               salesmenList.Add(new_salesman);
                MessageBox.Show("The Employee has been added successfully");
            }
            else if(comboBox_Designation.Text== "Typewriter")
            {
                Typewriter new_typewriter = new Typewriter();
                new_typewriter.setID(num);
                textBox_ID.Text = new_typewriter.ID;
                num++;
                new_typewriter.Name = textBox_Name.Text;
                new_typewriter.Designation = comboBox_Designation.Text;
                new_typewriter.Contact = textBox_contact.Text;
                new_typewriter.salary = Convert.ToDouble(textBox_Salary.Text);
                new_typewriter.calculateSalary(new_typewriter.salary,Convert.ToInt32(textBox_Age_of_service.Text));
                new_typewriter.Date_of_joining = textBox_Joining_Date.Text;
                new_typewriter.Leaves = Convert.ToDouble(textBox_Leaves.Text);

                typewriterList.Add(new_typewriter);
                MessageBox.Show("The Employee has been added successfully");
            }
        }

        private void Leaves(object sender, EventArgs e)
        {

        }

        private void ShowDetailsonclick(object sender, EventArgs e)
        {
            bool flage=false;
            if (flage == false)
            {
                foreach(Manager mE in managerList)
                {
                    if (mE.ID == textBox_ID_show.Text)
                    {
                        flage = true;
                        Employee_info.Items.Clear();
                        Employee_info.Items.Add("Employee ID: "+mE.ID);
                        Employee_info.Items.Add("Name       : " + mE.Name);
                        Employee_info.Items.Add("Designation: " + mE.Designation);
                        Employee_info.Items.Add("Salary     : " + mE.salary);
                        Employee_info.Items.Add("Contact    : " + mE.Contact);
                        Employee_info.Items.Add("Joining Date: " + mE.Date_of_joining);
                        break;
                    }
                }
            }
            if (flage == false)
            {
                foreach (Salesman sE in salesmenList)
                {
                    if (sE.ID == textBox_ID_show.Text)
                    {
                        flage = true;
                        Employee_info.Items.Clear();
                        Employee_info.Items.Add("Employee ID: " + sE.ID);
                        Employee_info.Items.Add("Name       : " + sE.Name);
                        Employee_info.Items.Add("Designation: " + sE.Designation);
                        Employee_info.Items.Add("Salary     : " + sE.salary);
                        Employee_info.Items.Add("Contact    : " + sE.Contact);
                        Employee_info.Items.Add("Joining Date: " + sE.Date_of_joining);
                        break;
                    }
                }
            }
            if (flage == false)
            {
                foreach (Typewriter tE in typewriterList)
                {
                    if (tE.ID == textBox_ID_show.Text)
                    {
                        flage = true;
                        Employee_info.Items.Clear();
                        Employee_info.Items.Add("Employee ID: " + tE.ID);
                        Employee_info.Items.Add("Name       : " + tE.Name);
                        Employee_info.Items.Add("Designation: " + tE.Designation);
                        Employee_info.Items.Add("Salary     : " + tE.salary);
                        Employee_info.Items.Add("Contact    : " + tE.Contact);
                        Employee_info.Items.Add("Joining Date: " + tE.Date_of_joining);
                        break;
                    }
                }
            }
            if(flage == false)
            {
                try
                {
                    throw new ApplicationException("The account is not found");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



        }
    }
}
