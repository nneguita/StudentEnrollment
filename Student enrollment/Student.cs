using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_enrollment
{
    public class Student : Person //inheritance(Student inherit from person), student is a person.
    {   //member of the class ->fields
        private string strStudentID;

        /* default constructor, without parameters, compiler will create a default constructor if user dont define it*/
        //Properties!!-Public everyone can access. str is a field!! u cant simply access to the child(TP00000).
        public Student(){
            strStudentID = "TP000000";
            Name = "New Student";
            Ic = "IC00000000";
            Contact = 1234567890;
            Address = "Unknown";
        }//if both parent class and child class gt put this, the system will auto use the child one. Child will overwrite parent!!
        //Constructor with parameters.
        //Same name with the previous constructor but diff params => Constructor Overloading

        public Student(string ID, string Name, string IC, long Contact, string Address)
            : base(Name, IC, Contact, Address)//base is refering to the parent class (Person class) it will look at the constructor and refer to the value.
        {
            strStudentID = ID;
        }
        //setting and getting data (set /get accessor)
        //1 property for each field
        public string StudentID {
            set{
                strStudentID=value;
            }
            get{
                return strStudentID;
            }

        }
        public void Update(Student newobj)
        {
            strStudentID = newobj.strStudentID;
            Name = newobj.Name;
            Ic = newobj.Ic;
            Contact = newobj.Contact;
            Address = newobj.Address;
        }

                      public string toString() {
                     return "\nStudent ID: " + StudentID +"\nStudent Name: "+Name+"\nStudent IC: "+Ic+"\nStudent Tel: "+Contact+"\nStudent Address: "+Address;
                     }
    }
    }

