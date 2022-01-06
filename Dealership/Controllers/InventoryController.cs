using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        Inventory cl = new Inventory();

        [HttpGet]
        public List<Car> GetAllCars()
        {
            return cl.Cars;
        }


        [HttpGet("SearchMake/{make}")]

        public List<Car> SearchMake(string make)
        {
        
                List<Car> cars = new List<Car>();
                foreach (Car c in cl.Cars)
                {
                    if (c.Make.Contains(make)|| c.Make.ToLower() == make.ToLower())
                    {
                        cars.Add(c);
                    }
                       
                }
            return cars;

        }

        public List<Car> SearchModel(string model)
        {

            List<Car> cars = new List<Car>();
            foreach (Car c in cl.Cars)
            {
                if (c.Make.Contains(model) || c.Make.ToLower() == model.ToLower())
                {
                    cars.Add(c);
                }

            }
            return cars;

        }


        public List<Car> SearchYear(string year)
        {

            List<Car> cars = new List<Car>();
            foreach (Car c in cl.Cars)
            {
                if (c.Make.Contains(year) || c.Make.ToLower() == year.ToLower())
                {
                    cars.Add(c);
                }

            }
            return cars;

        }

        public List<Car> SearchColor(string color)
        {

            List<Car> cars = new List<Car>();
            foreach (Car c in cl.Cars)
            {
                if (c.Make.Contains(color) || c.Make.ToLower() == color.ToLower())
                {
                    cars.Add(c);
                }

            }
            return cars;

        }


        [HttpGet("SearchIndex/{index}")]

        public Car SearchIndex (int index)
        {
            Car errorCar = new Car("Error", "Index", "Is Invalid.", "Please use a valid index");
            try
            {
                return cl.Cars[index];
            }
            catch (ArgumentOutOfRangeException)
            {
                return errorCar;
            }
            catch (IndexOutOfRangeException)
            {
                return errorCar;
            }
        }

    }
}




