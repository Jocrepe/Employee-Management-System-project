namespace Employee_Management_Project
{
    partial class Home
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
            this.EmployeeTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureboxExit = new System.Windows.Forms.PictureBox();
            this.pictureboxLogout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboboxAddStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxAddSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxAddAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboboxAddPosition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxAddLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxAddFirstname = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtboxEditId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboboxEditStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxEditSalary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtboxEditAge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboboxEditPosition = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtboxEditLastname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtboxEditFirstname = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtboxRemoveId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogout)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeTable
            // 
            this.EmployeeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeTable.Location = new System.Drawing.Point(62, 104);
            this.EmployeeTable.Name = "EmployeeTable";
            this.EmployeeTable.ReadOnly = true;
            this.EmployeeTable.Size = new System.Drawing.Size(1047, 358);
            this.EmployeeTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureboxExit);
            this.panel1.Controls.Add(this.pictureboxLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 83);
            this.panel1.TabIndex = 1;
            // 
            // pictureboxExit
            // 
            this.pictureboxExit.Location = new System.Drawing.Point(1082, 26);
            this.pictureboxExit.Name = "pictureboxExit";
            this.pictureboxExit.Size = new System.Drawing.Size(45, 37);
            this.pictureboxExit.TabIndex = 2;
            this.pictureboxExit.TabStop = false;
            this.pictureboxExit.Click += new System.EventHandler(this.pictureboxExit_Click);
            // 
            // pictureboxLogout
            // 
            this.pictureboxLogout.Location = new System.Drawing.Point(977, 26);
            this.pictureboxLogout.Name = "pictureboxLogout";
            this.pictureboxLogout.Size = new System.Drawing.Size(45, 37);
            this.pictureboxLogout.TabIndex = 1;
            this.pictureboxLogout.TabStop = false;
            this.pictureboxLogout.Click += new System.EventHandler(this.pictureboxLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(375, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabControl1.Location = new System.Drawing.Point(62, 485);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1047, 366);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.comboboxAddStatus);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtboxAddSalary);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtboxAddAge);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboboxAddPosition);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtboxAddLastname);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtboxAddFirstname);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1039, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(453, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 45);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboboxAddStatus
            // 
            this.comboboxAddStatus.FormattingEnabled = true;
            this.comboboxAddStatus.Items.AddRange(new object[] {
            "Working",
            "Left"});
            this.comboboxAddStatus.Location = new System.Drawing.Point(672, 166);
            this.comboboxAddStatus.Name = "comboboxAddStatus";
            this.comboboxAddStatus.Size = new System.Drawing.Size(201, 38);
            this.comboboxAddStatus.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "สถานะ";
            // 
            // txtboxAddSalary
            // 
            this.txtboxAddSalary.Location = new System.Drawing.Point(225, 163);
            this.txtboxAddSalary.Name = "txtboxAddSalary";
            this.txtboxAddSalary.Size = new System.Drawing.Size(201, 35);
            this.txtboxAddSalary.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "เงินเดือน";
            // 
            // txtboxAddAge
            // 
            this.txtboxAddAge.Location = new System.Drawing.Point(672, 97);
            this.txtboxAddAge.Name = "txtboxAddAge";
            this.txtboxAddAge.Size = new System.Drawing.Size(201, 35);
            this.txtboxAddAge.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "อายุ";
            // 
            // comboboxAddPosition
            // 
            this.comboboxAddPosition.FormattingEnabled = true;
            this.comboboxAddPosition.Items.AddRange(new object[] {
            "Engineer",
            "Marketing Manager",
            "Accountant",
            "Product Manager",
            "CEO",
            "Boss",
            "Supervisor",
            "Security Guard",
            "Cleaning Staff",
            "Electician",
            ""});
            this.comboboxAddPosition.Location = new System.Drawing.Point(225, 92);
            this.comboboxAddPosition.Name = "comboboxAddPosition";
            this.comboboxAddPosition.Size = new System.Drawing.Size(201, 38);
            this.comboboxAddPosition.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "ตำแหน่ง";
            // 
            // txtboxAddLastname
            // 
            this.txtboxAddLastname.Location = new System.Drawing.Point(672, 23);
            this.txtboxAddLastname.Name = "txtboxAddLastname";
            this.txtboxAddLastname.Size = new System.Drawing.Size(201, 35);
            this.txtboxAddLastname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "นามสกุล";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ";
            // 
            // txtboxAddFirstname
            // 
            this.txtboxAddFirstname.Location = new System.Drawing.Point(225, 23);
            this.txtboxAddFirstname.Name = "txtboxAddFirstname";
            this.txtboxAddFirstname.Size = new System.Drawing.Size(201, 35);
            this.txtboxAddFirstname.TabIndex = 0;
            this.txtboxAddFirstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtboxEditId);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.comboboxEditStatus);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtboxEditSalary);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtboxEditAge);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.comboboxEditPosition);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtboxEditLastname);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtboxEditFirstname);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1039, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Employee";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtboxEditId
            // 
            this.txtboxEditId.Location = new System.Drawing.Point(479, 263);
            this.txtboxEditId.Name = "txtboxEditId";
            this.txtboxEditId.Size = new System.Drawing.Size(201, 35);
            this.txtboxEditId.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(232, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(203, 30);
            this.label14.TabIndex = 26;
            this.label14.Text = "กรอก id ที่ต้องการแก้ไข";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(735, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 45);
            this.button1.TabIndex = 25;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboboxEditStatus
            // 
            this.comboboxEditStatus.FormattingEnabled = true;
            this.comboboxEditStatus.Items.AddRange(new object[] {
            "Working",
            "Left"});
            this.comboboxEditStatus.Location = new System.Drawing.Point(681, 173);
            this.comboboxEditStatus.Name = "comboboxEditStatus";
            this.comboboxEditStatus.Size = new System.Drawing.Size(201, 38);
            this.comboboxEditStatus.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "สถานะ";
            // 
            // txtboxEditSalary
            // 
            this.txtboxEditSalary.Location = new System.Drawing.Point(234, 170);
            this.txtboxEditSalary.Name = "txtboxEditSalary";
            this.txtboxEditSalary.Size = new System.Drawing.Size(201, 35);
            this.txtboxEditSalary.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 30);
            this.label9.TabIndex = 21;
            this.label9.Text = "เงินเดือน";
            // 
            // txtboxEditAge
            // 
            this.txtboxEditAge.Location = new System.Drawing.Point(681, 104);
            this.txtboxEditAge.Name = "txtboxEditAge";
            this.txtboxEditAge.Size = new System.Drawing.Size(201, 35);
            this.txtboxEditAge.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(593, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 30);
            this.label10.TabIndex = 19;
            this.label10.Text = "อายุ";
            // 
            // comboboxEditPosition
            // 
            this.comboboxEditPosition.FormattingEnabled = true;
            this.comboboxEditPosition.Items.AddRange(new object[] {
            "Engineer",
            "Marketing Manager",
            "Accountant",
            "Product Manager",
            "CEO",
            "Boss",
            "Supervisor",
            "Security Guard",
            "Cleaning Staff",
            "Electician",
            ""});
            this.comboboxEditPosition.Location = new System.Drawing.Point(234, 99);
            this.comboboxEditPosition.Name = "comboboxEditPosition";
            this.comboboxEditPosition.Size = new System.Drawing.Size(201, 38);
            this.comboboxEditPosition.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(133, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 30);
            this.label11.TabIndex = 17;
            this.label11.Text = "ตำแหน่ง";
            // 
            // txtboxEditLastname
            // 
            this.txtboxEditLastname.Location = new System.Drawing.Point(681, 30);
            this.txtboxEditLastname.Name = "txtboxEditLastname";
            this.txtboxEditLastname.Size = new System.Drawing.Size(201, 35);
            this.txtboxEditLastname.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(557, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 30);
            this.label12.TabIndex = 15;
            this.label12.Text = "นามสกุล";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(173, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 30);
            this.label13.TabIndex = 14;
            this.label13.Text = "ชื่อ";
            // 
            // txtboxEditFirstname
            // 
            this.txtboxEditFirstname.Location = new System.Drawing.Point(234, 30);
            this.txtboxEditFirstname.Name = "txtboxEditFirstname";
            this.txtboxEditFirstname.Size = new System.Drawing.Size(201, 35);
            this.txtboxEditFirstname.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRemove);
            this.tabPage3.Controls.Add(this.txtboxRemoveId);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1039, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Remove Employee";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(436, 185);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(118, 45);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtboxRemoveId
            // 
            this.txtboxRemoveId.Location = new System.Drawing.Point(498, 78);
            this.txtboxRemoveId.Name = "txtboxRemoveId";
            this.txtboxRemoveId.Size = new System.Drawing.Size(212, 35);
            this.txtboxRemoveId.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(232, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(237, 30);
            this.label15.TabIndex = 0;
            this.label15.Text = "กรุณากรอก ID ที่ต้องการลบ";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 863);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EmployeeTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogout)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureboxLogout;
        private System.Windows.Forms.PictureBox pictureboxExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxAddFirstname;
        private System.Windows.Forms.TextBox txtboxAddLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboboxAddPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxAddAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxAddSalary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboboxAddStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxEditId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboboxEditStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxEditSalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtboxEditAge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboboxEditPosition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtboxEditLastname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtboxEditFirstname;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtboxRemoveId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}