using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF.Lesson04.Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //WhileLoopExample();
            //IssueTickets();
            //DoWhileLoopExample();
            //AddUpTrollyContents();
            //ForLoopExample();
            //CountDownFrom10To0();
            ForEachExample();
        }

        private static void ForEachExample()
        {
            int[] numbers = { 5, 4, 3, 2, 1 };

            foreach (int item in numbers)
            {
                Console.WriteLine("item is " + item);
            }
        }

        private static void CountDownFrom10To0()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Value of i is {0}", i);
            }
        }

        private static void ForLoopExample()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("The value of i is {0}", i);
            }
        }

        private static void AddUpTrollyContents()
        {
            decimal inputValue;
            decimal totalCost = 0.0m;

            do
            {
                Console.Write("-1 to exit.  Value of product is £");
                inputValue = decimal.Parse(Console.ReadLine());
                if (inputValue != -1.0m)
                {
                    totalCost += inputValue;
                }
            } while (inputValue != -1.0m);

            Console.WriteLine("Total cost = " + totalCost.ToString("C"));
        }

        private static void DoWhileLoopExample()
        {
            int i = 1;
            do
            {
                Console.WriteLine("The value of i is " + i);
                i++;
            } while (i <= 5);
        }

        private static void IssueTickets()
        {
            int ticketNumber = 0;

            Console.WriteLine("e - to exit.  Other key to issue ticket");
            char input = Console.ReadKey().KeyChar;
            while (input != 'e')
            {
                ticketNumber++;

                Console.WriteLine("e - to exit.  Other key to issue ticket");
                input = Console.ReadKey().KeyChar;
            }

            Console.WriteLine("Total tickets = " + ticketNumber);
        }

        private static void WhileLoopExample()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("The value of i is " + i);
                i++;
            }
        }
    }
}
