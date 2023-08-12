namespace Student_enrollment
{
    partial class Menu
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
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnIntake = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnModule = new System.Windows.Forms.Button();
            this.btnStudentInfo = new System.Windows.Forms.Button();
            this.btnAssignedStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(85, 26);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(114, 23);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Student Form";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnIntake
            // 
            this.btnIntake.Location = new System.Drawing.Point(85, 68);
            this.btnIntake.Name = "btnIntake";
            this.btnIntake.Size = new System.Drawing.Size(114, 23);
            this.btnIntake.TabIndex = 1;
            this.btnIntake.Text = "Intake Form";
            this.btnIntake.UseVisualStyleBackColor = true;
            this.btnIntake.Click += new System.EventHandler(this.btnIntake_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(108, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnModule
            // 
            this.btnModule.Location = new System.Drawing.Point(85, 111);
            this.btnModule.Name = "btnModule";
            this.btnModule.Size = new System.Drawing.Size(114, 23);
            this.btnModule.TabIndex = 3;
            this.btnModule.Text = "Module Form";
            this.btnModule.UseVisualStyleBackColor = true;
            this.btnModule.Click += new System.EventHandler(this.btnModule_Click);
            // 
            // btnStudentInfo
            // 
            this.btnStudentInfo.Location = new System.Drawing.Point(85, 146);
            this.btnStudentInfo.Name = "btnStudentInfo";
            this.btnStudentInfo.Size = new System.Drawing.Size(114, 23);
            this.btnStudentInfo.TabIndex = 4;
            this.btnStudentInfo.Text = "Show Student Info";
            this.btnStudentInfo.UseVisualStyleBackColor = true;
            this.btnStudentInfo.Click += new System.EventHandler(this.btnStudentInfo_Click);
            // 
            // btnAssignedStudent
            // 
            this.btnAssignedStudent.Location = new System.Drawing.Point(85, 177);
            this.btnAssignedStudent.Name = "btnAssignedStudent";
            this.btnAssignedStudent.Size = new System.Drawing.Size(114, 23);
            this.btnAssignedStudent.TabIndex = 5;
            this.btnAssignedStudent.Text = "Assigned Student";
            this.btnAssignedStudent.UseVisualStyleBackColor = true;
            this.btnAssignedStudent.Click += new System.EventHandler(this.btnAssignedStudent_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAssignedStudent);
            this.Controls.Add(this.btnStudentInfo);
            this.Controls.Add(this.btnModule);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnIntake);
            this.Controls.Add(this.btnStudent);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnIntake;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnModule;
        private System.Windows.Forms.Button btnStudentInfo;
        private System.Windows.Forms.Button btnAssignedStudent;
    }
}