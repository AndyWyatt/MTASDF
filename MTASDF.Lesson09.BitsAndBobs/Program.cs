using MTASDF.Lesson09.BitsAndBobs.Vehicles;
using System;

namespace MTASDF.Lesson09.BitsAndBobs
{
    class Program
    {
        static void Main(string[] args)
        {
            //AndysCode();

            //EllipseFun();

            //ValueAndReferanceTypeDifferences();


        }

        private static void ValueAndReferanceTypeDifferences()
        {
            Rectangle r1 = new Rectangle(10.00, 10.00, 10.0, 10.0);
            Rectangle r2 = r1;

            Point p1 = new Point(10, 10);
            Point p2 = p1;

            Console.WriteLine("Rectangles");
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            bool isSame = r1 == r2;
            Console.WriteLine($"r1 & r2 is same? {isSame}");

            Console.WriteLine("Points");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            isSame = p1.Equals(p2);
            Console.WriteLine($"p1 & p2 is same? {isSame}");

            // Play with 2nd values
            Console.WriteLine("We're playing with 2nd value");
            r2.Height = 100;
            p2.Y = 100;

            Console.WriteLine("Rectangles");
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            isSame = r1 == r2;
            Console.WriteLine($"r1 & r2 is same? {isSame}");

            Console.WriteLine("Points");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            isSame = p1.Equals(p2);
            Console.WriteLine($"p1 & p2 is same? {isSame}");

            //Polygon poly = new Polygon(1, 1, 100, 100);
        }

        private static void EllipseFun()
        {
            Ellipse e1 = new Ellipse(10, 10, 10, 10);
            Ellipse e2 = new Ellipse(20, 20, 10, 10);
            Ellipse e3 = new Ellipse(30, 30, 10, 10);

            Ellipse[] ellipses =
            {
                e1, e2, e3
            };

            foreach (var item in ellipses)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"No of ellipses = {Ellipse.NoOfEliipses}");
        }

        private static void AndysCode()
        {
            Console.WriteLine("Hello world");

            Car car1 = new Car("Nissan", "Micra");
            Car car2 = new Car("Ford", "Fiesta");

            Console.WriteLine(car1);
            Console.WriteLine(car2);

            Student student1 = Student.Create("Carl", "Wilkins");
            Student student2 = Student.Create("Andy", "Toms");
            Student student3 = Student.Create("Tom", "Carolus");

            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);

            Console.WriteLine($"No of students = {Student.NumberOfStudents}");
            Console.WriteLine($"Carl's course leader = {Student.CourseLeader}");
            Student.CourseLeader = "Jacqui Maw";
            Console.WriteLine($"Carl's course leader = {Student.CourseLeader}");
        }
    }
}
