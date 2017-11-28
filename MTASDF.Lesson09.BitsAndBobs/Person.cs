using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF.Lesson09.BitsAndBobs
{
    public class Person
    {
        public string Forename { get; set; }
        public string Surname { get; set; }

        private Person()
        {

        }

        public Person(string forename, string surname)
            : this()
        {
            Forename = forename;
            Surname = surname;
        }
    }
}
