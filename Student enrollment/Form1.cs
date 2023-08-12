using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_enrollment
{
    public partial class Form1 : Form
    {
        List<Student> option = new List<Student>();
        Menu fm;
        DatabaseManagement db = new DatabaseManagement();
        // db.OpenConnection(); //to check database connect or not
        Student objs;
        public Form1(Menu menuform)// wan to pass the student's detail into the menu, so we put Menu menuform into().
             
        {
            InitializeComponent();
            fm = menuform;
            
        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();  //close the dialog
           this.Dispose(); //do nt save the form.
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (chkCertificate.Checked && chkIC.Checked)
            {
                if (chkIniPay.Checked == false)
                    MessageBox.Show("Please make your payment before Sem started.");

            if (radioBtnPerson.Checked ==true)
            {
                CreatePerson();
            }
            else if (radiobtnStudent.Checked == true)
            {
                CreateStudent();
            }
            else
            {
                MessageBox.Show("Non selected");
            }
            }
            else
                MessageBox.Show("Insufficient Documents Provided! Not able to register.");
            
           
            }
        

        private void CreatePerson()//THis is a FUNCTion.
        {

            //Person objp = new Person();//objp is a cincai name, can rename objPerson, object Person
            //MessageBox.Show(obj.toString(), "Person Detail");
            Person objPerson;
            long lngcontact = 0;

            if (txtName.Text != "" && txtContact.Text != "" && txtIc.Text != "" && txtAddress.Text != "")
            {
                try
                {
                    lngcontact = long.Parse(txtContact.Text);

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Wrong format", "RunTime error");
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.ToString(), "RunTime error!");
                }
                             
                finally //anythng happen in try and catch wil nt affect/stop
                {
                    if (lngcontact == 0)
                        lngcontact = 999;

                    objPerson = new Person(txtName.Text, txtIc.Text, lngcontact, txtAddress.Text); //set the default object

                    //   MessageBox.Show("Created Student:" + objStudent.toString());
                }
            }

            else
            {
                objPerson = new Person();
                MessageBox.Show("Please fill in all the fields!");
            }

            MessageBox.Show("Created Person " + objPerson.toString());
        }

        private void CreateStudent()
        {
            Student objStudent;
            long lngcontact = 0;

            if (txtID.Text != "" && txtName.Text != "" && txtContact.Text != "" && txtIc.Text != "" && txtAddress.Text != "")
            {
                try
                {
                    lngcontact = long.Parse(txtContact.Text);//if its a number, it will update it.else will goto else.
                    //   objStudent = new Student(txtID.Text, txtName.Text, txtIc.Text, long.Parse(txtContact.Text), txtAddress.Text); //create object
                    //call  constructor with parameters

                    //To try the calculation
                    //int x = 10 / int.Parse(txtContact.Text);

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Wrong format", "RunTime error");
                }
                catch (ArithmeticException ex1)
                {
                    MessageBox.Show("Illegal Calculation", "RunTime error!");
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.ToString(), "RunTime error!");
                }
                             
                finally //anythng happen in try and catch wil nt affect/stop
                {
                    if (lngcontact == 0)
                        lngcontact = 999;

                    objStudent = new Student(txtID.Text, txtName.Text, txtIc.Text, lngcontact, txtAddress.Text); //set the default object

                    //   MessageBox.Show("Created Student:" + objStudent.toString());
                }
            }

            else
            {
                objStudent = new Student();
                MessageBox.Show("Please fill in all the fields!");
            }

            MessageBox.Show("Created Student " + objStudent.toString());
            fm.UpdateStudent(objStudent);//fm.objstudent belongs to menu, objstudent belongs to Student, TO update the menu!.

        }

        private void radioBtnPerson_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPerson.Checked == true)
            {
                txtID.Enabled = false;
            }
        }

        private void radiobtnStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnStudent.Checked == true)
                txtID.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreatePerson_Click(object sender, EventArgs e)
        {

        }

        private void btnAdStudent_Click(object sender, EventArgs e)
        {
            objs = new Student(txtID.Text, txtName.Text, txtIc.Text, long.Parse(txtContact.Text), txtAddress.Text);
            db.InsertRecord(objs);
            db.ViewAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            //db.ViewRecord(txtID.Text);
            objs = db.ViewRecord(txtID.Text);
            txtName.Text = objs.Name;
            txtContact.Text = objs.Contact.ToString();
            txtIc.Text = objs.Ic;
            txtAddress.Text = objs.Address;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            objs.Name = txtName.Text;
            objs.Contact= long.Parse(txtContact.Text);
             objs.Ic= txtIc.Text;
             objs.Address= txtAddress.Text;
             db.UpdateRecord(objs);
           db.ViewAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.DeleteRecord(txtID.Text);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            option = db.ViewAll();
            foreach (Student s in option)
                comboBox1.Items.Add(s.Name);
        }


    }
}
