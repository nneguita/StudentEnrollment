using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_enrollment
{
    public class StudentRecord
    {
        public Intake IntakeDetail;//no put str or int because the StudentRecord class take info from other class!
        public Student StudentInfo;

        //COMPOSITION
        StudentRecord()
        {
            IntakeDetail = new Intake(); //composition(if the student record is deleted, intake wil nt exist.)because data created inside 
            //~tgt with the student record.
            StudentInfo = new Student();
        }

        //Aggregation:: deleting the student record, intake and student will remain in the system because data passed inside stdrecord.
       public StudentRecord(Intake intake, Student std)
        { //Aggregation
            IntakeDetail = intake;
            StudentInfo = std;
        }
        public string toString()
        {
            return IntakeDetail.toString() + StudentInfo.toString();
        }

    }
}