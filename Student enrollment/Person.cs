using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_enrollment
{
    public class Person
    {
            private string strName;
            private string strIc;
            private long lngContact;
            private string strAddress;

            /* default constructor, without parameters, compiler will create a default constructor if user dont define it*/
            public Person()
            {
                strName = "New Person";
                strIc = "IC00000000";
                lngContact = 1234567890;
                strAddress = "Unknown";
            }
            //Constructor with parameters.
            //Same name with the previous constructor but diff params => Constructor Overloading

            public Person(string Name, string IC, long Contact, string Address)
            {
                strName = Name;
                strIc = IC;
                lngContact = Contact;
                strAddress = Address;

            }
            //setting and getting data (set /get accessor)
            //1 property for each field

            public string Name
            {
                set
                {
                    strName = value;
                }
                get
                {
                    return strName;
                }

            }
            public string Ic
            {
                set
                {
                    strIc = value;
                }
                get
                {
                    return strIc;
                }

            }

            public long Contact
            {
                set
                {
                    lngContact = value;
                }
                get
                {
                    return lngContact;
                }

            }
            public string Address
            {
                set
                {
                    strAddress = value;
                }
                get
                {
                    return strAddress;
                }
            }
            public string toString()
            {
                return "\n Person Name: " + Name + "\nIC No: " + Ic + "\nTel No: " + Contact + "\nAddress :" + Address;
            }
        }
    }
