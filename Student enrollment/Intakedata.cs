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
    public partial class Intakedata : Form
    {
        //create the main menu object 
        Menu objMainMenu;
        public Intakedata(Menu Menuform) //the menu is equal to 'this'
        {
            InitializeComponent();
            objMainMenu = Menuform;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //if structure
            /* if (condition)
             * {
             * action for true condition
             * }
             * else{
             * action for false condition
             * }
             */
            Intake objIntake; //creating a null object
            if (txtCode.Text == "" || txtName.Text == "" || comboIntakeProgramme.SelectedItem.ToString()=="") //if its empty, do tis
                objIntake = new Intake();
            else
                objIntake = new Intake(txtCode.Text, txtName.Text, comboIntakeProgramme.SelectedItem.ToString());//if not empty, use the value user enter.
            //v outside if and else
            objMainMenu.UpdateIntake(objIntake);
            //In the form of Array
            AssignedStudent frmAssignedStudent = new AssignedStudent(objIntake, objMainMenu.StudentList);
            // In the form of List
            // AssignedStudent frmAssignedStudent = new AssignedStudent(objIntake, objMainMenu.ListStudent);
            frmAssignedStudent.Show();
            this.Close();
        }
        private void Intakedata_Load(object sender, EventArgs e)
        { comboIntakeProgramme.Items.Add("Certificate"); }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text= listboxName.SelectedItem.ToString();
        }

        private void listboxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboIntakeProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Intakedata_Load_1(object sender, EventArgs e)
        {

        }
    }
}
