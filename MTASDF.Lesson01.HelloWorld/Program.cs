using System;

namespace MTASDF.Lesson01.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicHelloWorldCode();

            //ArrayExample();

            RecapTask();
        }

        private static void RecapTask()
        {
            string[] horseParts =
            {
                "Poll",
                "Crest",
                "Back",
                "Dock",
                "Fetlock"
            };

            Console.WriteLine("Parts of horse");
            Console.WriteLine(horseParts[0]);
            Console.WriteLine(horseParts[1]);
            Console.WriteLine(horseParts[2]);
            Console.WriteLine(horseParts[3]);
            Console.WriteLine(horseParts[4]);
        }

        private static void ArrayExample()
        {
            int[] number = { 1, 2, 3, 4, 5 };
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);
            Console.WriteLine(number[3]);
            Console.WriteLine(number[4]);
            Console.WriteLine("length of array = " + number.Length);

            number[2] = 100;
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);
            Console.WriteLine(number[3]);
            Console.WriteLine(number[4]);
            Console.WriteLine("length of array = " + number.Length);

            int[] ages = new int[7];
            Console.WriteLine("Please enter " + ages.Length + " ages");
            ages[0] = int.Parse(Console.ReadLine());
            ages[1] = int.Parse(Console.ReadLine());
            ages[2] = int.Parse(Console.ReadLine());
            ages[3] = int.Parse(Console.ReadLine());
            ages[4] = int.Parse(Console.ReadLine());
            ages[5] = int.Parse(Console.ReadLine());
            ages[6] = int.Parse(Console.ReadLine());

            Console.WriteLine("Ages:-");
            Console.WriteLine(ages[0]);
            Console.WriteLine(ages[1]);
            Console.WriteLine(ages[2]);
            Console.WriteLine(ages[3]);
            Console.WriteLine(ages[4]);
            Console.WriteLine(ages[5]);
            Console.WriteLine(ages[6]);
        }

        private static void BasicHelloWorldCode()
        {
            Console.WriteLine("Hello World!");

            int age;

            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your age is " + age);

            // MTASDF.Lesson01.HelloWorld.Program <- This is FQN (Fully Qualified Name) for this class
        }
    }
}
