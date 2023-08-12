namespace Student_enrollment
{
    partial class ComputingSubjectForm
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
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.txtSubCode = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboIncourse = new System.Windows.Forms.ComboBox();
            this.cboExam = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstviewcs = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgdsubject = new System.Windows.Forms.DataGridView();
            this.subName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdsubject)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Incourse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject Name";
            // 
            // txtSubName
            // 
            this.txtSubName.Location = new System.Drawing.Point(133, 51);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(100, 20);
            this.txtSubName.TabIndex = 0;
            // 
            // txtSubCode
            // 
            this.txtSubCode.Location = new System.Drawing.Point(133, 86);
            this.txtSubCode.Name = "txtSubCode";
            this.txtSubCode.Size = new System.Drawing.Size(100, 20);
            this.txtSubCode.TabIndex = 1;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(133, 152);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 20);
            this.txtDuration.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subject Code";
            // 
            // cboIncourse
            // 
            this.cboIncourse.FormattingEnabled = true;
            this.cboIncourse.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboIncourse.Location = new System.Drawing.Point(94, 92);
            this.cboIncourse.Name = "cboIncourse";
            this.cboIncourse.Size = new System.Drawing.Size(100, 21);
            this.cboIncourse.TabIndex = 2;
            // 
            // cboExam
            // 
            this.cboExam.FormattingEnabled = true;
            this.cboExam.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboExam.Location = new System.Drawing.Point(94, 161);
            this.cboExam.Name = "cboExam";
            this.cboExam.Size = new System.Drawing.Size(100, 21);
            this.cboExam.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboExam);
            this.groupBox1.Controls.Add(this.cboIncourse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(39, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 207);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Computing Subject";
            // 
            // lstviewcs
            // 
            this.lstviewcs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Code});
            this.lstviewcs.Location = new System.Drawing.Point(307, 160);
            this.lstviewcs.Name = "lstviewcs";
            this.lstviewcs.Size = new System.Drawing.Size(174, 84);
            this.lstviewcs.TabIndex = 11;
            this.lstviewcs.UseCompatibleStateImageBehavior = false;
            // 
            // dgdsubject
            // 
            this.dgdsubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdsubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subName,
            this.subcode,
            this.incourse,
            this.duration,
            this.exam});
            this.dgdsubject.Location = new System.Drawing.Point(307, 29);
            this.dgdsubject.Name = "dgdsubject";
            this.dgdsubject.Size = new System.Drawing.Size(540, 125);
            this.dgdsubject.TabIndex = 12;
            // 
            // subName
            // 
            this.subName.HeaderText = "Subject Name";
            this.subName.Name = "subName";
            // 
            // subcode
            // 
            this.subcode.HeaderText = "Subject Code";
            this.subcode.Name = "subcode";
            // 
            // incourse
            // 
            this.incourse.HeaderText = "Incourse";
            this.incourse.Name = "incourse";
            // 
            // duration
            // 
            this.duration.HeaderText = "Duration";
            this.duration.Name = "duration";
            // 
            // exam
            // 
            this.exam.HeaderText = "Exam";
            this.exam.Name = "exam";
            // 
            // ComputingSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 295);
            this.Controls.Add(this.dgdsubject);
            this.Controls.Add(this.lstviewcs);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtSubCode);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Text = "ComputingSubjectForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdsubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubName;
        private System.Windows.Forms.TextBox txtSubCode;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboIncourse;
        private System.Windows.Forms.ComboBox cboExam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstviewcs;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.DataGridView dgdsubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn subName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn incourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam;
    }
}