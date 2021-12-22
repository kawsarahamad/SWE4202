namespace LAB_05
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
            this.Add = new System.Windows.Forms.Button();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_companyName = new System.Windows.Forms.TextBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.textBox_expireDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Available_amount = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Sell = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_amount_sell = new System.Windows.Forms.TextBox();
            this.Expire_Date = new System.Windows.Forms.Label();
            this.comboBox_Name_sell = new System.Windows.Forms.ComboBox();
            this.comboBox_Name_show = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medicine Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medicine Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Company Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = " Amount";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(62, 346);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 45);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add Medicine";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Medicine_Onclick);
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(158, 260);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(100, 22);
            this.textBox_Price.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(158, 137);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Name.TabIndex = 8;
            // 
            // textBox_companyName
            // 
            this.textBox_companyName.Location = new System.Drawing.Point(158, 180);
            this.textBox_companyName.Name = "textBox_companyName";
            this.textBox_companyName.Size = new System.Drawing.Size(100, 22);
            this.textBox_companyName.TabIndex = 9;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(158, 223);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(100, 22);
            this.textBox_amount.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Show ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.show_avaibality_onclick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Expire Date";
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(158, 98);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(100, 22);
            this.textBox_type.TabIndex = 13;
            // 
            // textBox_expireDate
            // 
            this.textBox_expireDate.Location = new System.Drawing.Point(158, 302);
            this.textBox_expireDate.Name = "textBox_expireDate";
            this.textBox_expireDate.Size = new System.Drawing.Size(100, 22);
            this.textBox_expireDate.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(307, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Medicine Name";
            // 
            // Available_amount
            // 
            this.Available_amount.AutoSize = true;
            this.Available_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available_amount.Location = new System.Drawing.Point(307, 192);
            this.Available_amount.Name = "Available_amount";
            this.Available_amount.Size = new System.Drawing.Size(148, 20);
            this.Available_amount.TabIndex = 18;
            this.Available_amount.Text = "Available Amount :";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(307, 225);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(58, 20);
            this.Price.TabIndex = 19;
            this.Price.Text = "Price :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(597, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Medicine Name";
            // 
            // Sell
            // 
            this.Sell.Location = new System.Drawing.Point(618, 183);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(75, 41);
            this.Sell.TabIndex = 23;
            this.Sell.Text = "Sell";
            this.Sell.UseVisualStyleBackColor = true;
            this.Sell.Click += new System.EventHandler(this.sell_Onclick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(597, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = " Amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "Show Balance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showBalance_onclick);
            // 
            // textBox_amount_sell
            // 
            this.textBox_amount_sell.Location = new System.Drawing.Point(739, 139);
            this.textBox_amount_sell.Name = "textBox_amount_sell";
            this.textBox_amount_sell.Size = new System.Drawing.Size(100, 22);
            this.textBox_amount_sell.TabIndex = 27;
            // 
            // Expire_Date
            // 
            this.Expire_Date.AutoSize = true;
            this.Expire_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expire_Date.Location = new System.Drawing.Point(307, 260);
            this.Expire_Date.Name = "Expire_Date";
            this.Expire_Date.Size = new System.Drawing.Size(102, 20);
            this.Expire_Date.TabIndex = 28;
            this.Expire_Date.Text = "Expire Date:";
            // 
            // comboBox_Name_sell
            // 
            this.comboBox_Name_sell.FormattingEnabled = true;
            this.comboBox_Name_sell.Location = new System.Drawing.Point(739, 93);
            this.comboBox_Name_sell.Name = "comboBox_Name_sell";
            this.comboBox_Name_sell.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Name_sell.TabIndex = 29;
            // 
            // comboBox_Name_show
            // 
            this.comboBox_Name_show.FormattingEnabled = true;
            this.comboBox_Name_show.Location = new System.Drawing.Point(450, 100);
            this.comboBox_Name_show.Name = "comboBox_Name_show";
            this.comboBox_Name_show.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Name_show.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 504);
            this.Controls.Add(this.comboBox_Name_show);
            this.Controls.Add(this.comboBox_Name_sell);
            this.Controls.Add(this.Expire_Date);
            this.Controls.Add(this.textBox_amount_sell);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Available_amount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_expireDate);
            this.Controls.Add(this.textBox_type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.textBox_companyName);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.Add);
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
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_companyName;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.TextBox textBox_expireDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Available_amount;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Sell;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_amount_sell;
        private System.Windows.Forms.Label Expire_Date;
        private System.Windows.Forms.ComboBox comboBox_Name_sell;
        private System.Windows.Forms.ComboBox comboBox_Name_show;
    }
}

