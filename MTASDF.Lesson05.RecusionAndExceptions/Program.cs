using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF.Lesson05.RecusionAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //RecapExercise();

            //Console.WriteLine("5! = " + Fractorial(5));

            //Console.WriteLine("SigDigs 12345 = " + SignificateDigits(12345));
            //Console.WriteLine("SigDigs 99 = " + SignificateDigits(99));
            //Console.WriteLine("SigDigs 2845 = " + SignificateDigits(2845));

            //ExceptionTestReadInAFile();

            FindAverageTempsFromFile();
        }

        private static void FindAverageTempsFromFile()
        {
            StreamReader sr = null;
            int totalTemps = 0;
            double averageTemps = 0.0;
            try
            {
                sr = File.OpenText("C:\\andy.wyatt\\temps.txt");
                while (!sr.EndOfStream)
                {
                    try
                    {
                        double temp = double.Parse(sr.ReadLine());
                        totalTemps++;
                        averageTemps += temp;
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine("Invalid value!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error - " + e.Message);
                    }
                }
            }
            catch (FileNotFoundException fne)
            {
                Console.WriteLine("Give me file temps.txt!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something bad " + e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close(); 
                }
            }

            averageTemps = averageTemps / totalTemps;

            Console.WriteLine("AVG TEMPS = " + averageTemps);
        }

        private static void ExceptionTestReadInAFile()
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText("C:\\andy.wyatt\\data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("Couldn't find the file!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oppps... " + ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        public static int SignificateDigits(int n)
        {
            if (n <= 9)
            {
                return 1; // Base case
            }
            else
            {
                return SignificateDigits(n / 10) + 1; // Recursive case
            }
        }

        public static int Fractorial(int n)
        {
            if (n == 0)
            {
                return 1; // Base case
            }
            else
            {
                return n * Fractorial(n - 1); // Recursive case
            }
        }

        private static void RecapExercise()
        {
            double[] values = {
                88.61479908,
                71.81723473,
                59.05933781,
                55.59426836,
                43.16881481,
                83.48967374,
                54.92045136,
                81.44063908,
                52.88159058,
                31.78288069
            };
            double average = 0.0;
            foreach (var item in values)
            {
                average += item;
            }
            average = average / values.Length;

            Console.WriteLine("Average = " + average);
        }
    }
}
