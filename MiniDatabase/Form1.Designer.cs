namespace MiniDatabase
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.AccountEndDate = new System.Windows.Forms.DateTimePicker();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.PhoneAreaCode = new System.Windows.Forms.TextBox();
            this.PhoneCountryCode = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelSearchByName = new System.Windows.Forms.Panel();
            this.SearchBoxLastName = new System.Windows.Forms.TextBox();
            this.SearchBoxFirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelSearchByPhone = new System.Windows.Forms.Panel();
            this.SearchBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelSearchByDepartment = new System.Windows.Forms.Panel();
            this.SearchBoxDepartment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelSearchByDate = new System.Windows.Forms.Panel();
            this.SearchBoxdateIntervalEnd = new System.Windows.Forms.DateTimePicker();
            this.SearchBoxdateIntervalStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.grdUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdAccountEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelSearchByName.SuspendLayout();
            this.panelSearchByPhone.SuspendLayout();
            this.panelSearchByDepartment.SuspendLayout();
            this.panelSearchByDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 634);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.AccountEndDate);
            this.tabPage1.Controls.Add(this.PhoneNumber);
            this.tabPage1.Controls.Add(this.PhoneAreaCode);
            this.tabPage1.Controls.Add(this.PhoneCountryCode);
            this.tabPage1.Controls.Add(this.Department);
            this.tabPage1.Controls.Add(this.LastName);
            this.tabPage1.Controls.Add(this.FirstName);
            this.tabPage1.Controls.Add(this.UserName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(902, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountEndDate
            // 
            this.AccountEndDate.Location = new System.Drawing.Point(145, 184);
            this.AccountEndDate.Name = "AccountEndDate";
            this.AccountEndDate.Size = new System.Drawing.Size(175, 20);
            this.AccountEndDate.TabIndex = 5;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(221, 216);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(99, 20);
            this.PhoneNumber.TabIndex = 8;
            // 
            // PhoneAreaCode
            // 
            this.PhoneAreaCode.Location = new System.Drawing.Point(183, 216);
            this.PhoneAreaCode.Name = "PhoneAreaCode";
            this.PhoneAreaCode.Size = new System.Drawing.Size(32, 20);
            this.PhoneAreaCode.TabIndex = 7;
            // 
            // PhoneCountryCode
            // 
            this.PhoneCountryCode.Location = new System.Drawing.Point(145, 216);
            this.PhoneCountryCode.Name = "PhoneCountryCode";
            this.PhoneCountryCode.Size = new System.Drawing.Size(32, 20);
            this.PhoneCountryCode.TabIndex = 6;
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(145, 138);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(175, 20);
            this.Department.TabIndex = 4;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(145, 99);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(175, 20);
            this.LastName.TabIndex = 3;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(145, 64);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(175, 20);
            this.FirstName.TabIndex = 2;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(145, 28);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(175, 20);
            this.UserName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telephone Number: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Account End Date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelSearchByName);
            this.tabPage2.Controls.Add(this.panelSearchByPhone);
            this.tabPage2.Controls.Add(this.panelSearchByDepartment);
            this.tabPage2.Controls.Add(this.panelSearchByDate);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.grd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(902, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelSearchByName
            // 
            this.panelSearchByName.Controls.Add(this.SearchBoxLastName);
            this.panelSearchByName.Controls.Add(this.SearchBoxFirstName);
            this.panelSearchByName.Controls.Add(this.label10);
            this.panelSearchByName.Controls.Add(this.label7);
            this.panelSearchByName.Location = new System.Drawing.Point(16, 17);
            this.panelSearchByName.Name = "panelSearchByName";
            this.panelSearchByName.Size = new System.Drawing.Size(267, 50);
            this.panelSearchByName.TabIndex = 12;
            // 
            // SearchBoxLastName
            // 
            this.SearchBoxLastName.Location = new System.Drawing.Point(90, 26);
            this.SearchBoxLastName.Name = "SearchBoxLastName";
            this.SearchBoxLastName.Size = new System.Drawing.Size(170, 20);
            this.SearchBoxLastName.TabIndex = 8;
            // 
            // SearchBoxFirstName
            // 
            this.SearchBoxFirstName.Location = new System.Drawing.Point(90, 3);
            this.SearchBoxFirstName.Name = "SearchBoxFirstName";
            this.SearchBoxFirstName.Size = new System.Drawing.Size(170, 20);
            this.SearchBoxFirstName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(3, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name:";
            // 
            // panelSearchByPhone
            // 
            this.panelSearchByPhone.Controls.Add(this.SearchBoxPhoneNumber);
            this.panelSearchByPhone.Controls.Add(this.label12);
            this.panelSearchByPhone.Location = new System.Drawing.Point(310, 75);
            this.panelSearchByPhone.Name = "panelSearchByPhone";
            this.panelSearchByPhone.Size = new System.Drawing.Size(266, 28);
            this.panelSearchByPhone.TabIndex = 11;
            // 
            // SearchBoxPhoneNumber
            // 
            this.SearchBoxPhoneNumber.Location = new System.Drawing.Point(88, 0);
            this.SearchBoxPhoneNumber.Name = "SearchBoxPhoneNumber";
            this.SearchBoxPhoneNumber.Size = new System.Drawing.Size(170, 20);
            this.SearchBoxPhoneNumber.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(9, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Phone:";
            // 
            // panelSearchByDepartment
            // 
            this.panelSearchByDepartment.Controls.Add(this.SearchBoxDepartment);
            this.panelSearchByDepartment.Controls.Add(this.label11);
            this.panelSearchByDepartment.Location = new System.Drawing.Point(17, 73);
            this.panelSearchByDepartment.Name = "panelSearchByDepartment";
            this.panelSearchByDepartment.Size = new System.Drawing.Size(266, 28);
            this.panelSearchByDepartment.TabIndex = 11;
            // 
            // SearchBoxDepartment
            // 
            this.SearchBoxDepartment.Location = new System.Drawing.Point(88, 0);
            this.SearchBoxDepartment.Name = "SearchBoxDepartment";
            this.SearchBoxDepartment.Size = new System.Drawing.Size(170, 20);
            this.SearchBoxDepartment.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(1, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Department:";
            // 
            // panelSearchByDate
            // 
            this.panelSearchByDate.Controls.Add(this.SearchBoxdateIntervalEnd);
            this.panelSearchByDate.Controls.Add(this.SearchBoxdateIntervalStart);
            this.panelSearchByDate.Controls.Add(this.label8);
            this.panelSearchByDate.Controls.Add(this.label9);
            this.panelSearchByDate.Location = new System.Drawing.Point(310, 20);
            this.panelSearchByDate.Name = "panelSearchByDate";
            this.panelSearchByDate.Size = new System.Drawing.Size(259, 51);
            this.panelSearchByDate.TabIndex = 10;
            // 
            // SearchBoxdateIntervalEnd
            // 
            this.SearchBoxdateIntervalEnd.Location = new System.Drawing.Point(84, 28);
            this.SearchBoxdateIntervalEnd.Name = "SearchBoxdateIntervalEnd";
            this.SearchBoxdateIntervalEnd.Size = new System.Drawing.Size(170, 20);
            this.SearchBoxdateIntervalEnd.TabIndex = 7;
            // 
            // SearchBoxdateIntervalStart
            // 
            this.SearchBoxdateIntervalStart.Location = new System.Drawing.Point(84, 2);
            this.SearchBoxdateIntervalStart.Name = "SearchBoxdateIntervalStart";
            this.SearchBoxdateIntervalStart.Size = new System.Drawing.Size(170, 20);
            this.SearchBoxdateIntervalStart.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date Start:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(9, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Date End:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SearchFiled",
            "By Name",
            "By Department",
            "By Telephone Number",
            "By Account End Date",
            "Multiple"});
            this.comboBox1.Location = new System.Drawing.Point(16, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdUserName,
            this.grdName,
            this.grdLastName,
            this.grdDepartment,
            this.grdAccountEndDate,
            this.grdPhoneNumber});
            this.grd.Location = new System.Drawing.Point(16, 174);
            this.grd.Name = "grd";
            this.grd.ReadOnly = true;
            this.grd.Size = new System.Drawing.Size(687, 459);
            this.grd.TabIndex = 0;
            // 
            // grdUserName
            // 
            this.grdUserName.HeaderText = "Kullanıcı Adı";
            this.grdUserName.Name = "grdUserName";
            this.grdUserName.ReadOnly = true;
            // 
            // grdName
            // 
            this.grdName.HeaderText = "İsim";
            this.grdName.Name = "grdName";
            this.grdName.ReadOnly = true;
            // 
            // grdLastName
            // 
            this.grdLastName.HeaderText = "Soy İsim";
            this.grdLastName.Name = "grdLastName";
            this.grdLastName.ReadOnly = true;
            // 
            // grdDepartment
            // 
            this.grdDepartment.HeaderText = "Departman";
            this.grdDepartment.Name = "grdDepartment";
            this.grdDepartment.ReadOnly = true;
            this.grdDepartment.Width = 120;
            // 
            // grdAccountEndDate
            // 
            this.grdAccountEndDate.HeaderText = "Vade Sonu";
            this.grdAccountEndDate.Name = "grdAccountEndDate";
            this.grdAccountEndDate.ReadOnly = true;
            // 
            // grdPhoneNumber
            // 
            this.grdPhoneNumber.HeaderText = "Telefon Numarası";
            this.grdPhoneNumber.Name = "grdPhoneNumber";
            this.grdPhoneNumber.ReadOnly = true;
            this.grdPhoneNumber.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 647);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelSearchByName.ResumeLayout(false);
            this.panelSearchByName.PerformLayout();
            this.panelSearchByPhone.ResumeLayout(false);
            this.panelSearchByPhone.PerformLayout();
            this.panelSearchByDepartment.ResumeLayout(false);
            this.panelSearchByDepartment.PerformLayout();
            this.panelSearchByDate.ResumeLayout(false);
            this.panelSearchByDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker AccountEndDate;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox PhoneAreaCode;
        private System.Windows.Forms.TextBox PhoneCountryCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox SearchBoxFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdAccountEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPhoneNumber;
        private System.Windows.Forms.DateTimePicker SearchBoxdateIntervalStart;
        private System.Windows.Forms.DateTimePicker SearchBoxdateIntervalEnd;
        private System.Windows.Forms.TextBox SearchBoxLastName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelSearchByName;
        private System.Windows.Forms.Panel panelSearchByDepartment;
        private System.Windows.Forms.TextBox SearchBoxDepartment;
        private System.Windows.Forms.Panel panelSearchByDate;
        private System.Windows.Forms.Panel panelSearchByPhone;
        private System.Windows.Forms.TextBox SearchBoxPhoneNumber;
        private System.Windows.Forms.Label label12;
    }
}

