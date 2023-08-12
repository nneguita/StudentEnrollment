using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_enrollment
{
    public partial class ModuleForm : Form
    {
        public ModuleForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComputingsbj_Click(object sender, EventArgs e)
        {
            //Module objcct = new ComputingSubject(); //polymorphism
            //MessageBox.Show(objcct.toString()); 
            ComputingSubjectForm frmCS = new ComputingSubjectForm();
            frmCS.ShowDialog();
        }

        private void btnCocofrm_Click(object sender, EventArgs e)
        {
            Module objcc = new Coco(); //polymorphism
            MessageBox.Show(objcc.toString()); 
        }

        private void ModuleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
