using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_enrollment
{
    abstract class Module//cannot create an obj itself because it is ABSTRACT = IMCOMPLETE, but it helps to create coco and computing subject
    {
        private string strName;
        private string strCode;
        
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }
        public string Code
        {
            get{return strCode;}
            set { strCode = value; }
        }
        public virtual string toString() 
        {
            return "Name: " + Name + "\nCode: " + Code;
        }
        public abstract string ModuleAssignment(); 
    }
}
