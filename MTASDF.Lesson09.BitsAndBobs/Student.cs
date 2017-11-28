using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF.Lesson09.BitsAndBobs
{
    public class Student : Person
    {
        public int StudentId { get; set; }

        public static string CourseLeader { get; set; } = "Andy Wyatt";
        public static string BaseRoom { get; set; } = "MB319";
        public static int NumberOfStudents { get; set; }

        private Student(string forename, string surname)
            : base(forename, surname)
        {
            StudentId = NumberOfStudents + 30000000;
            NumberOfStudents++;
        }

        public override string ToString()
        {
            return $"Student {Forename} {Surname} ({StudentId})";
        }

        public static Student Create(string forename, string surname)
        {
            Student result = null;

            forename = forename.Trim();
            surname = surname.Trim();

            // Precondition checks.
            if (!string.IsNullOrWhiteSpace(forename) && forename.Length > 2 &&
                !string.IsNullOrWhiteSpace(surname) && surname.Length > 2)
            {
                result = new Student(forename, surname);
            }

            return result;
        }
    }
}
