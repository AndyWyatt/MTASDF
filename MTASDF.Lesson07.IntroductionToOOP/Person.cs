using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF.Lesson07.IntroductionToOOP
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        private string bankPin;

        private double heightInCm;
        public double HeightInCm
        {
            get
            {
                return heightInCm;
            }
            set
            {
                if (value > 0.0)
                {
                    heightInCm = value;
                }
            }
        }
        private double weightInKg;
        public double WeightInKg
        {
            get
            {
                return weightInKg;
            }
            set
            {
                if (value > 0.0)
                {
                    weightInKg = value;
                }
            }
        }
        public double BMI
        {
            get
            {
                return WeightInKg / ((HeightInCm / 100.0) * (HeightInCm / 100.0));
            }
        }
        public string BMIDescription
        {
            get
            {
                string result = string.Empty;

                if (BMI < 18.5)
                {
                    result = "Underweight";
                }
                else if (BMI < 25)
                {
                    result = "Normal";
                }
                else if (BMI < 30)
                {
                    result = "Overweight";
                }
                else if (BMI < 40)
                {
                    result = "Obese";
                }
                else
                {
                    result = "Morbidly Obese";
                }

                return result;
            }
        }

        private DateTime createdOn;

        private Person()
        {
            createdOn = DateTime.Now;
        }

        public Person(string name, int age, string bankPin) 
            : this()
        {
            Name = name;
            Age = age;
            this.bankPin = bankPin;
        }

        public void Sleep()
        {
            Console.WriteLine("I'm sleeping! ZZzz..");
        }

        public void RunFor30Min()
        {
            Console.WriteLine("Puff puff!");
            WeightInKg -= 0.001;
        }
    }
}
