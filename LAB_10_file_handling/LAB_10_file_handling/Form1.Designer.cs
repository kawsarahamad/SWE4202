namespace LAB_10_file_handling
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.Zip = new System.Windows.Forms.Label();
            this.County = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 16;
            this.ListBox.Location = new System.Drawing.Point(74, 95);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(637, 340);
            this.ListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(799, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(890, 55);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(263, 22);
            this.textBox_email.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(950, 95);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(96, 44);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.searchUserOnclick);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(794, 166);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(97, 20);
            this.firstName.TabIndex = 4;
            this.firstName.Text = "First Name:";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(794, 291);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(76, 20);
            this.Address.TabIndex = 6;
            this.Address.Text = "Address:";
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.Location = new System.Drawing.Point(794, 252);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(133, 20);
            this.companyName.TabIndex = 7;
            this.companyName.Text = "Company Name:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(794, 210);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(96, 20);
            this.lastName.TabIndex = 8;
            this.lastName.Text = "Last Name:";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(794, 332);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(61, 20);
            this.Phone.TabIndex = 9;
            this.Phone.Text = "Phone:";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.Location = new System.Drawing.Point(794, 380);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(53, 20);
            this.State.TabIndex = 14;
            this.State.Text = "State:";
            // 
            // Zip
            // 
            this.Zip.AutoSize = true;
            this.Zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zip.Location = new System.Drawing.Point(794, 415);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(36, 20);
            this.Zip.TabIndex = 15;
            this.Zip.Text = "Zip:";
            // 
            // County
            // 
            this.County.AutoSize = true;
            this.County.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.County.Location = new System.Drawing.Point(794, 455);
            this.County.Name = "County";
            this.County.Size = new System.Drawing.Size(66, 20);
            this.County.TabIndex = 16;
            this.County.Text = "County:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 510);
            this.Controls.Add(this.County);
            this.Controls.Add(this.Zip);
            this.Controls.Add(this.State);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label companyName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Label Zip;
        private System.Windows.Forms.Label County;
    }
}

