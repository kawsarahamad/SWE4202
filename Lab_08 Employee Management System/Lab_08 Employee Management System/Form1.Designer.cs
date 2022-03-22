namespace Lab_08_Employee_Management_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.textBox_Joining_Date = new System.Windows.Forms.TextBox();
            this.comboBox_Designation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Age_of_service = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Leaves = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_ID_show = new System.Windows.Forms.TextBox();
            this.Employee_info = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Designation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Joining Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contact No.";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(294, 93);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(119, 22);
            this.textBox_Name.TabIndex = 7;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(294, 130);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(119, 22);
            this.textBox_ID.TabIndex = 8;
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Location = new System.Drawing.Point(294, 203);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(119, 22);
            this.textBox_Salary.TabIndex = 10;
            this.textBox_Salary.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox_contact
            // 
            this.textBox_contact.Location = new System.Drawing.Point(294, 240);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(119, 22);
            this.textBox_contact.TabIndex = 11;
            // 
            // textBox_Joining_Date
            // 
            this.textBox_Joining_Date.Location = new System.Drawing.Point(294, 281);
            this.textBox_Joining_Date.Name = "textBox_Joining_Date";
            this.textBox_Joining_Date.Size = new System.Drawing.Size(119, 22);
            this.textBox_Joining_Date.TabIndex = 12;
            // 
            // comboBox_Designation
            // 
            this.comboBox_Designation.FormattingEnabled = true;
            this.comboBox_Designation.Items.AddRange(new object[] {
            "Manager",
            "Salesman",
            "Typewriter"});
            this.comboBox_Designation.Location = new System.Drawing.Point(294, 166);
            this.comboBox_Designation.Name = "comboBox_Designation";
            this.comboBox_Designation.Size = new System.Drawing.Size(119, 24);
            this.comboBox_Designation.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Show Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowDetailsonclick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 40);
            this.label8.TabIndex = 15;
            this.label8.Text = "Age of service:\r\n  (in Days)";
            // 
            // textBox_Age_of_service
            // 
            this.textBox_Age_of_service.Location = new System.Drawing.Point(294, 367);
            this.textBox_Age_of_service.Name = "textBox_Age_of_service";
            this.textBox_Age_of_service.Size = new System.Drawing.Size(119, 22);
            this.textBox_Age_of_service.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 48);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addEmployeeonclick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(178, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Leaves:";
            this.label9.TextChanged += new System.EventHandler(this.Leaves);
            // 
            // textBox_Leaves
            // 
            this.textBox_Leaves.Location = new System.Drawing.Point(294, 320);
            this.textBox_Leaves.Name = "textBox_Leaves";
            this.textBox_Leaves.Size = new System.Drawing.Size(119, 22);
            this.textBox_Leaves.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(466, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Employee ID:";
            // 
            // textBox_ID_show
            // 
            this.textBox_ID_show.Location = new System.Drawing.Point(597, 95);
            this.textBox_ID_show.Name = "textBox_ID_show";
            this.textBox_ID_show.Size = new System.Drawing.Size(119, 22);
            this.textBox_ID_show.TabIndex = 21;
            // 
            // Employee_info
            // 
            this.Employee_info.FormattingEnabled = true;
            this.Employee_info.ItemHeight = 16;
            this.Employee_info.Location = new System.Drawing.Point(529, 206);
            this.Employee_info.Name = "Employee_info";
            this.Employee_info.Size = new System.Drawing.Size(417, 180);
            this.Employee_info.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 509);
            this.Controls.Add(this.Employee_info);
            this.Controls.Add(this.textBox_ID_show);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_Leaves);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_Age_of_service);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_Designation);
            this.Controls.Add(this.textBox_Joining_Date);
            this.Controls.Add(this.textBox_contact);
            this.Controls.Add(this.textBox_Salary);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.TextBox textBox_Joining_Date;
        private System.Windows.Forms.ComboBox comboBox_Designation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Age_of_service;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Leaves;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_ID_show;
        private System.Windows.Forms.ListBox Employee_info;
    }
}

