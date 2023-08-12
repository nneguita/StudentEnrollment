namespace Student_enrollment
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIc = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnCreatePerson = new System.Windows.Forms.Button();
            this.radioBtnPerson = new System.Windows.Forms.RadioButton();
            this.radiobtnStudent = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkCertificate = new System.Windows.Forms.CheckBox();
            this.chkIC = new System.Windows.Forms.CheckBox();
            this.chkIniPay = new System.Windows.Forms.CheckBox();
            this.btnAdStudent = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(139, 51);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtIc
            // 
            this.txtIc.Location = new System.Drawing.Point(139, 117);
            this.txtIc.Name = "txtIc";
            this.txtIc.Size = new System.Drawing.Size(100, 20);
            this.txtIc.TabIndex = 2;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(139, 143);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 20);
            this.txtContact.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(139, 174);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "APU Student Enrollment";
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(139, 281);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(75, 23);
            this.btncreate.TabIndex = 6;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(361, 280);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 7;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnCreatePerson
            // 
            this.btnCreatePerson.Location = new System.Drawing.Point(12, 281);
            this.btnCreatePerson.Name = "btnCreatePerson";
            this.btnCreatePerson.Size = new System.Drawing.Size(104, 23);
            this.btnCreatePerson.TabIndex = 5;
            this.btnCreatePerson.Text = "CreatePerson";
            this.btnCreatePerson.UseVisualStyleBackColor = true;
            this.btnCreatePerson.Click += new System.EventHandler(this.btnCreatePerson_Click);
            // 
            // radioBtnPerson
            // 
            this.radioBtnPerson.AutoSize = true;
            this.radioBtnPerson.Location = new System.Drawing.Point(302, 73);
            this.radioBtnPerson.Name = "radioBtnPerson";
            this.radioBtnPerson.Size = new System.Drawing.Size(58, 17);
            this.radioBtnPerson.TabIndex = 14;
            this.radioBtnPerson.Text = "Person";
            this.radioBtnPerson.UseVisualStyleBackColor = true;
            this.radioBtnPerson.CheckedChanged += new System.EventHandler(this.radioBtnPerson_CheckedChanged);
            // 
            // radiobtnStudent
            // 
            this.radiobtnStudent.AutoSize = true;
            this.radiobtnStudent.Checked = true;
            this.radiobtnStudent.Location = new System.Drawing.Point(302, 96);
            this.radiobtnStudent.Name = "radiobtnStudent";
            this.radiobtnStudent.Size = new System.Drawing.Size(62, 17);
            this.radiobtnStudent.TabIndex = 15;
            this.radiobtnStudent.TabStop = true;
            this.radiobtnStudent.Text = "Student";
            this.radiobtnStudent.UseVisualStyleBackColor = true;
            this.radiobtnStudent.CheckedChanged += new System.EventHandler(this.radiobtnStudent_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(245, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 73);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Document";
            // 
            // chkCertificate
            // 
            this.chkCertificate.AutoSize = true;
            this.chkCertificate.Location = new System.Drawing.Point(302, 154);
            this.chkCertificate.Name = "chkCertificate";
            this.chkCertificate.Size = new System.Drawing.Size(73, 17);
            this.chkCertificate.TabIndex = 19;
            this.chkCertificate.Text = "Certificate";
            this.chkCertificate.UseVisualStyleBackColor = true;
            // 
            // chkIC
            // 
            this.chkIC.AutoSize = true;
            this.chkIC.Location = new System.Drawing.Point(302, 174);
            this.chkIC.Name = "chkIC";
            this.chkIC.Size = new System.Drawing.Size(102, 17);
            this.chkIC.TabIndex = 20;
            this.chkIC.Text = "Photocopy of IC";
            this.chkIC.UseVisualStyleBackColor = true;
            // 
            // chkIniPay
            // 
            this.chkIniPay.AutoSize = true;
            this.chkIniPay.Location = new System.Drawing.Point(302, 198);
            this.chkIniPay.Name = "chkIniPay";
            this.chkIniPay.Size = new System.Drawing.Size(94, 17);
            this.chkIniPay.TabIndex = 21;
            this.chkIniPay.Text = "Initial Payment";
            this.chkIniPay.UseVisualStyleBackColor = true;
            // 
            // btnAdStudent
            // 
            this.btnAdStudent.Location = new System.Drawing.Point(248, 280);
            this.btnAdStudent.Name = "btnAdStudent";
            this.btnAdStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAdStudent.TabIndex = 22;
            this.btnAdStudent.Text = "Add Student";
            this.btnAdStudent.UseVisualStyleBackColor = true;
            this.btnAdStudent.Click += new System.EventHandler(this.btnAdStudent_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(361, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(139, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(40, 217);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(248, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 316);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdStudent);
            this.Controls.Add(this.chkIniPay);
            this.Controls.Add(this.chkIC);
            this.Controls.Add(this.chkCertificate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radiobtnStudent);
            this.Controls.Add(this.radioBtnPerson);
            this.Controls.Add(this.btnCreatePerson);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtIc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIc;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnCreatePerson;
        private System.Windows.Forms.RadioButton radioBtnPerson;
        private System.Windows.Forms.RadioButton radiobtnStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkCertificate;
        private System.Windows.Forms.CheckBox chkIC;
        private System.Windows.Forms.CheckBox chkIniPay;
        private System.Windows.Forms.Button btnAdStudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

