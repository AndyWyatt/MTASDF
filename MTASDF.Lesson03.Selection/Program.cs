using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF.Lesson03.Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExampleIfStatement();

            //ExampleOfIfElseIfElseStatement();

            SwtichExample();
        }

        private static void SwtichExample()
        {
            DateTime today = DateTime.Today;
            switch (today.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("I hate Mondays!");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Week day");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Weekend day");
                    break;
                default:
                    break;
            }
        }

        private static void ExampleOfIfElseIfElseStatement()
        {
            Console.WriteLine("Give me a number");
            int number = int.Parse(Console.ReadLine());
            TestIfElse(number);
        }

        private static void TestIfElse(int n)
        {
            if (n < 10)
            {
                Console.WriteLine("n is less than 10");
            }
            else if (n < 20)
            {
                Console.WriteLine("n is less than 20");
            }
            else if (n < 30)
            {
                Console.WriteLine("n is less than 30");
            }
            else
            {
                Console.WriteLine("n is equal to or more than 30");
            }
        }

        private static void ExampleIfStatement()
        {
            int number1 = 10;
            int number2 = 20;

            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }

            Console.WriteLine("END");
        }
    }
}
