namespace Student_enrollment
{
    partial class ModuleForm
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
            this.btnCocofrm = new System.Windows.Forms.Button();
            this.btnComputingsbj = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCocofrm
            // 
            this.btnCocofrm.Location = new System.Drawing.Point(76, 68);
            this.btnCocofrm.Name = "btnCocofrm";
            this.btnCocofrm.Size = new System.Drawing.Size(129, 23);
            this.btnCocofrm.TabIndex = 0;
            this.btnCocofrm.Text = "Coco Form";
            this.btnCocofrm.UseVisualStyleBackColor = true;
            this.btnCocofrm.Click += new System.EventHandler(this.btnCocofrm_Click);
            // 
            // btnComputingsbj
            // 
            this.btnComputingsbj.Location = new System.Drawing.Point(76, 132);
            this.btnComputingsbj.Name = "btnComputingsbj";
            this.btnComputingsbj.Size = new System.Drawing.Size(129, 23);
            this.btnComputingsbj.TabIndex = 1;
            this.btnComputingsbj.Text = "Computing Subject";
            this.btnComputingsbj.UseVisualStyleBackColor = true;
            this.btnComputingsbj.Click += new System.EventHandler(this.btnComputingsbj_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(109, 193);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnComputingsbj);
            this.Controls.Add(this.btnCocofrm);
            this.Name = "ModuleForm";
            this.Text = "Module";
            this.Load += new System.EventHandler(this.ModuleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCocofrm;
        private System.Windows.Forms.Button btnComputingsbj;
        private System.Windows.Forms.Button btnClose;

    }
}