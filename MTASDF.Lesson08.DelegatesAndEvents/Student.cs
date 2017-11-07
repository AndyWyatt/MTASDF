using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF.Lesson08.DelegatesAndEvents
{
    public class Student
    {
        public string Name { get; set; }

        private Student()
        {

        }

        public Student(string name) : this()
        {
            Name = name;
        }

        internal void ReadCartoons(string newsletter)
        {
            Console.WriteLine($"{Name} is reading cartoons");
        }

        internal void ReadNewsLetter(string newsletter)
        {
            Console.WriteLine($"{Name} is reading the student section");
        }
    }
}
