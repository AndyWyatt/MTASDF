using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF.Lesson08.DelegatesAndEvents
{
    class GearBox
    {
        public event EventHandler GearChanged;

        private int gearNo = 0;
        public int GetNo
        {
            get
            {
                return gearNo;
            }
            set
            {
                bool hasChanged = value != gearNo;
                gearNo = value;
                if (hasChanged)
                {
                    GearChanged(this, EventArgs.Empty); 
                }
            }
        }

        public static string GetFullname(string forename, string surname)
        {
            string result = string.Empty;

            result = forename + " " + surname;

            return result;
        }
    }
}
