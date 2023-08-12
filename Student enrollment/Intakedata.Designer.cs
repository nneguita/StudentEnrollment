namespace Student_enrollment
{
    partial class Intakedata
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblIntakecode = new System.Windows.Forms.Label();
            this.lblintakeName = new System.Windows.Forms.Label();
            this.lblProgramme = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboIntakeProgramme = new System.Windows.Forms.ComboBox();
            this.listboxName = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(142, 49);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblIntakecode
            // 
            this.lblIntakecode.AutoSize = true;
            this.lblIntakecode.Location = new System.Drawing.Point(22, 49);
            this.lblIntakecode.Name = "lblIntakecode";
            this.lblIntakecode.Size = new System.Drawing.Size(65, 13);
            this.lblIntakecode.TabIndex = 3;
            this.lblIntakecode.Text = "Intake Code";
            // 
            // lblintakeName
            // 
            this.lblintakeName.AutoSize = true;
            this.lblintakeName.Location = new System.Drawing.Point(22, 101);
            this.lblintakeName.Name = "lblintakeName";
            this.lblintakeName.Size = new System.Drawing.Size(68, 13);
            this.lblintakeName.TabIndex = 4;
            this.lblintakeName.Text = "Intake Name";
            // 
            // lblProgramme
            // 
            this.lblProgramme.AutoSize = true;
            this.lblProgramme.Location = new System.Drawing.Point(22, 188);
            this.lblProgramme.Name = "lblProgramme";
            this.lblProgramme.Size = new System.Drawing.Size(93, 13);
            this.lblProgramme.TabIndex = 5;
            this.lblProgramme.Text = "Intake Programme";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(98, 275);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(188, 275);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboIntakeProgramme
            // 
            this.comboIntakeProgramme.FormattingEnabled = true;
            this.comboIntakeProgramme.Items.AddRange(new object[] {
            "Foundation",
            "Diploma",
            "Degree",
            "Master"});
            this.comboIntakeProgramme.Location = new System.Drawing.Point(142, 180);
            this.comboIntakeProgramme.Name = "comboIntakeProgramme";
            this.comboIntakeProgramme.Size = new System.Drawing.Size(121, 21);
            this.comboIntakeProgramme.TabIndex = 8;
            this.comboIntakeProgramme.SelectedIndexChanged += new System.EventHandler(this.comboIntakeProgramme_SelectedIndexChanged);
            // 
            // listboxName
            // 
            this.listboxName.FormattingEnabled = true;
            this.listboxName.Items.AddRange(new object[] {
            "Software Engineering",
            "Computer Science",
            "IT",
            "Games Development"});
            this.listboxName.Location = new System.Drawing.Point(292, 92);
            this.listboxName.Name = "listboxName";
            this.listboxName.Size = new System.Drawing.Size(120, 95);
            this.listboxName.TabIndex = 9;
            this.listboxName.SelectedIndexChanged += new System.EventHandler(this.listboxName_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Intakedata
            // 
            this.ClientSize = new System.Drawing.Size(448, 342);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listboxName);
            this.Controls.Add(this.comboIntakeProgramme);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblProgramme);
            this.Controls.Add(this.lblintakeName);
            this.Controls.Add(this.lblIntakecode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Name = "Intakedata";
            this.Text = "Intake";
            this.Load += new System.EventHandler(this.Intakedata_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblIntakecode;
        private System.Windows.Forms.Label lblintakeName;
        private System.Windows.Forms.Label lblProgramme;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboIntakeProgramme;
        private System.Windows.Forms.ListBox listboxName;
        private System.Windows.Forms.Button button2;
    }
}