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

namespace LAB_10_file_handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<user> UserList = new List<user>();
        private void Form1_Load(object sender, EventArgs e)
        {
            using(var reader = new StreamReader(@"D:\Swe 4202\LAB_10_file_handling\userInfo - userInfo.csv - userInfo - userInfo.csv.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var info = line.Split(',');
                    user new_user = new user();
                    new_user.first_name = info[0];
                    new_user.last_name = info[1];
                    new_user.company_name = info[2];
                    new_user.address = info[3];
                    new_user.city = info[4];
                    new_user.county = info[5];
                    new_user.state = info[6];
                    new_user.zip = info[7];
                    new_user.phone1 = info[8];
                    new_user.phone = info[9];
                    new_user.email = info[10];

                    UserList.Add(new_user);
                    ListBox.Items.Add(new_user.first_name+"\t\t"+new_user.last_name+"\t\t"+new_user.email+"\n");


                }
            }
        }
        string path = @"D:\Swe 4202\LAB_10_file_handling\Search Log.txt";
        private void searchUserOnclick(object sender, EventArgs e)
        {
            bool flag=false;
            foreach(user findUser in UserList)
            {
                if(findUser.email == textBox_email.Text)
                {
                    flag = true;
                    firstName.Text =   "First Name:   "+findUser.first_name+"\n";
                    lastName.Text =    "Last Name:    " + findUser.last_name + "\n";
                    companyName.Text = "Company Name: " + findUser.company_name+ "\n";
                    Address.Text =     "Address:      " + findUser.address + "\n";
                    Phone.Text =       "Phone:        " + findUser.phone + "\n";
                    State.Text =       "State:        " + findUser.state + "\n";
                    Zip.Text =         "Zip:          " + findUser.zip + "\n";
                    County.Text =      "County:       " + findUser.county + "\n";
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        string str = findUser.email + "\t" + System.DateTime.Now.ToString() + "  Found.";
                        sw.WriteLine(str);
                    }
                }

            }
            if (flag == false) {
                MessageBox.Show("User is not found");
                using (StreamWriter sw = File.AppendText(path))
                {
                    string str = textBox_email.Text + "\t" + System.DateTime.Now.ToString() + "  Not Found.";
                    sw.WriteLine(str);
                }
            }
        }
    }
}
