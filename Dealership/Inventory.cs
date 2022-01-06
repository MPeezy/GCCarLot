using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership
{
    public class Inventory
    {
        public List<Car> Cars { get; set; } = new List<Car>();

        public Inventory()

        {

            Cars.Add(new Car("Ford", "Taurus", "1998", "black"));
            Cars.Add(new Car("Ford", "F-150", "2021", "red"));
            Cars.Add(new Car("Jeep", "Cherokee", "2010", "silver"));
            Cars.Add(new Car("Chevy", "Malibu", "2015", "pink"));
            Cars.Add(new Car("Toyota", "Camry", "2011", "grey"));
            Cars.Add(new Car("Cadillac", "Escalade", "2020", "white"));




        }
    }
}
