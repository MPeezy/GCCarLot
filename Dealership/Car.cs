using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership
{
    public class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }

        public string Year { get; set; }

        public string Color { get; set; }

       

        public Car(string make, string model, string year, string color)
        {
            Make = make;
            Model = model;
            Year =  year;
            Color = color;
           

        }

        public override string ToString()
        {
            return $"Make: {Make} \n Model: {Model} \nYear: {Year} \nColor: {Color}";
        }
    }
}
