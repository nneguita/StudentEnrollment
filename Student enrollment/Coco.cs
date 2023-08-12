using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_enrollment
{
    class Coco:Module
    {
        private string strAssignmentName;

        public Coco()
        {
            strAssignmentName = "Organize an event";
        }
        public string AssignmentName
        {
            set { strAssignmentName = value; }
            get { return strAssignmentName; }
        }
        public override string toString() //polymorphism
        {
            return base.toString() + "\nAssignment Name: " + AssignmentName+"\nMode of Assignment: "+ ModuleAssignment(); //base means it will go bck to the module and use the parent!!
        }
        public override string ModuleAssignment()
        {
            return "1 group project";
        }
    }
}
