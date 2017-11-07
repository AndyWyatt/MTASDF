using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF.Lesson08.DelegatesAndEvents
{
    class Program
    {
        public delegate void ReadNewsletter(string newsletter);

        static void Main(string[] args)
        {
            Staff andy = new Staff("Andy");
            Staff jacqui = new Staff("Jacqui");
            Staff neil = new Staff("Neil");

            Student oliver = new Student("Oliver");
            Student kyle = new Student("Kyle");
            Student patrik = new Student("Partik");
            Student john = new Student("John");

            ReadNewsletter readNewsLetterList = delegate { };

            readNewsLetterList += jacqui.ReadNewsLetter;
            readNewsLetterList += neil.ReadNewsLetter;
            readNewsLetterList += oliver.ReadCartoons;
            readNewsLetterList += kyle.ReadNewsLetter;
            readNewsLetterList += patrik.ReadNewsLetter;
            readNewsLetterList += patrik.ReadCartoons;
            readNewsLetterList += john.ReadNewsLetter;

            readNewsLetterList -= john.ReadNewsLetter;

            string newsletter = "NEWS NOV 2017 - College is blown up";

            readNewsLetterList(newsletter);
        }
    }
}
