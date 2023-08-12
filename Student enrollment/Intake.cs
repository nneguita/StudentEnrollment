using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_enrollment
{
    public class Intake
    {
        private string strIntakeCode;
        private string strIntakeName;
        private string strIntakeProgramme;

        public Intake()
        {
            strIntakeCode = "UC0F0000XX";
            strIntakeName = "None";
            strIntakeProgramme = "None";
        }
        public Intake(string IntakeCode, string IntakeName, string IntakeProgramme)
        {
            strIntakeCode = IntakeCode;
            strIntakeName = IntakeName;
            strIntakeProgramme = IntakeProgramme;
        }
        public string IntakeCode
        {
            set
            {
                strIntakeCode = value;
            }
            get{
                return strIntakeCode;
            }
        }
        public string IntakeName
        {
            set
            {
                strIntakeName = value;
            }
            get{
                return strIntakeName;
            }
        }
        public string IntakeProgramme
        {
            set
            {
                strIntakeProgramme = value;
            }
            get{
                return strIntakeProgramme;
            }
        }
        public string toString(){
            return "\nIntake Code:"+IntakeCode+"\nIntake Name:"+IntakeName+"\nIntake Programme:"+IntakeProgramme;
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}

