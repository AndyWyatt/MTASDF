using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF.Lesson08.DelegatesAndEvents
{
    class Staff
    {
        public string Name { get; set; }

        private Staff()
        {

        }

        public Staff(string name) : this()
        {
            Name = name;
        }

        public void ReadNewsLetter(string newsLetter)
        {
            Console.WriteLine($"{Name} reading staff section of newsletter.");
            Console.WriteLine("Doing cross word!");
        }
    }
}
