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
    public partial class Menu : Form
    {
        Student objStudent = new Student(); //default student in menu
        Intake objIntake = new Intake(); //default intake in main menu
        Student[] studentlist = new Student[10];
        List<Student> ListofStudent = new List<Student>();
        int studentCount = 0;

        public List<Student> ListStudent
        { get { return ListofStudent; } }

        public Student[] StudentList //read only
        {
            // set { objStudentlist = value; }
            get { return studentlist; }
        }
        public Menu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Form1 frmstudent = new Form1(this); //frmstudent is selfmade name. 'THIS' is to use the 'saved' info.
            frmstudent.ShowDialog();  //showdialog means show the form.
        }

        private void btnIntake_Click(object sender, EventArgs e)
        {
            Intakedata frmintake = new Intakedata(this); //pass the main menu form object to the intake form, need to edit other form.
            frmintake.ShowDialog();
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            ModuleForm frmModule = new ModuleForm();
            frmModule.ShowDialog();
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objStudent.toString(), "Information: ");
            MessageBox.Show(objIntake.toString(), "Intake info: ");
        }
        public void UpdateStudent(Student s)
        {
           // objStudent.Update(s);
            studentlist[studentCount++] = s;
            ListofStudent.Add(s);
            /*foreach (Student individualstudent in studentlist)
            {
                if(individualstudent != null)
                Console.WriteLine(individualstudent.toString());
            }*/
            for (int i = 0; i < studentlist.Length; i++)
            {
                if (studentlist[i] != null)
                    Console.WriteLine(studentlist[i].toString());
            }
            foreach (Student inds in ListofStudent)
            { Console.WriteLine(inds.toString()); }
        }
        public void UpdateIntake(Intake intake) //another method without using 'update', can type it manually. Make sure ur class is Public
        {
            objIntake.IntakeCode = intake.IntakeCode;
            objIntake.IntakeName = intake.IntakeName;
            objIntake.IntakeProgramme = intake.IntakeProgramme;
        }

        private void btnAssignedStudent_Click(object sender, EventArgs e)
        {
            AssignedStudent objAssignedStudentForm = new AssignedStudent(objIntake,objStudent); //pass object into the form.
            objAssignedStudentForm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        
    }
}
