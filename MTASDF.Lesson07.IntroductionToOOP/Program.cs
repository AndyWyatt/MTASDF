using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF.Lesson07.IntroductionToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Andy", 37, "****");
            person.WeightInKg = 91.0;
            person.HeightInCm = 179.0;
            Console.WriteLine($"New person is {person.Name}");

            int runTimes = 0;

            do
            {
                Console.WriteLine($"BMI = {person.BMI.ToString("N2")} ({person.BMIDescription})");
                person.RunFor30Min();
                runTimes++;
            } while (person.BMIDescription == "Overweight");

            Console.WriteLine($"I ran for {runTimes} times");
        }
    }
}
