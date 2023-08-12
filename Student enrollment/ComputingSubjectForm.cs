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
    public partial class ComputingSubjectForm : Form
    {
        public ComputingSubjectForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool exam, incourse;
            if (cboExam.SelectedText == "Yes")
                exam = true;
            else exam = false;
            if (cboIncourse.SelectedText == "Yes")
                incourse = true;
            else incourse = false;
            ComputingSubject objcs = new ComputingSubject(txtSubCode.Text, txtSubName.Text, int.Parse(txtDuration.Text), exam, incourse);
            Console.WriteLine(objcs.toString());
            lstviewcs.Items.Add(objcs.Name);

            DataGridViewRow newRow = new DataGridViewRow();
            object[] cellvalues = { objcs.Code, objcs.Name, objcs.Assignment, objcs.Duration, objcs.Exam };
                                 
            newRow.CreateCells(dgdsubject,cellvalues);
            dgdsubject.Rows.Add(newRow);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {int countsubject=0;

            //Console.WriteLine(lstviewcs.Items.Count);
        for (int i = 0; i < lstviewcs.Items.Count; i++)
            Console.WriteLine(lstviewcs.Items[i].Text);
        countsubject++;
        Console.Write("Total subjects added:"+countsubject);
                this.Close();
        }

    }
}
