using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_enrollment
{
    class ComputingSubject:Module
    {
        private bool bexam; //bool (boolean) for false or true
        private bool bassignment;
        private int iduration;

        public ComputingSubject()
        {
            bexam = true;
            bassignment = true;
            iduration = 16;
            Code = "CT000";
            Name = "Unknown";
        }
        public ComputingSubject(string name,string code, int duration, bool exam, bool assignment)
        {
            Name = name;
            Code = code;
            iduration = duration;
            bexam = exam;
            bassignment = assignment;
        }
        public bool Exam
        {
            set { bexam = value; }
            get { return bexam; }
        }
        public bool Assignment
        {
            set { bassignment = value; }
            get { return bassignment; }
        }
        public int Duration
        {
            get { return 16; }
        }
        public override string toString()
        {
            return base.toString() + "\nExam: " + Exam + "\nAssignment: " + Assignment + "\nDuration: " + Duration + "\nMode of Assignment: " + ModuleAssignment();
        }
        public override string ModuleAssignment()
        {
            return "Individual/Group Assignment";

        }
    }
}
