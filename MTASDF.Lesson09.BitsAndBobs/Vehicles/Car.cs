using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF.Lesson09.BitsAndBobs.Vehicles
{
    public class Car
    {
        public string Make { get; private set; }
        public string Model { get; private set; }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public override string ToString()
        {
            return $"Car - {Make} {Model}";
        }
    }
}
