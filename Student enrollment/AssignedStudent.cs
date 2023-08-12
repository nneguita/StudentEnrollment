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
    public partial class AssignedStudent : Form
    {
        Intake objIntake; //creating null object
        Student objStudent;
        Student[] objStudentlist;
        List<Student> ListofStudent;

        public AssignedStudent(Intake intake, Student student) //creation of the object
        {
            InitializeComponent();
            objIntake = intake; //update the null intake object
            objStudent = student; //update the null student obj
            //with the object from main menu
        }
        //In the form of Array
        public AssignedStudent(Intake intake, Student[] student) //Array
        {
            InitializeComponent();
            objIntake = intake; //update the null intake object
            objStudentlist = student; //create the array list
            //with the object from main menu
        }
        //In the form of LIst
        public AssignedStudent(Intake intake, List<Student>student) //List
        {
            InitializeComponent();
            objIntake = intake; //update the null intake object
            ListofStudent = student; //update the null student obj
            //with the object from main menu
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssignedStudent_Load(object sender, EventArgs e)
        {
            rchtxtIntakeInfo.Text = objIntake.toString();
         //   rchtxtStudentInfo.Text = objStudent.toString();
            foreach (Student listS in objStudentlist) { 
                if (listS != null)
                {
                    lstStudent.Items.Add(listS.Name + " : " + listS.StudentID);
                    Console.WriteLine(listS.Name);
                }
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            StudentRecord objStudentRecord = new StudentRecord(objIntake, objStudent);
            MessageBox.Show(objStudentRecord.toString(),"Record Created:");
        }

    }
}
