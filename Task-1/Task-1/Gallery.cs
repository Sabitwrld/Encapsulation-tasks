using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Gallery
    {
        public Car[] Cars = new Car[0];

        public void AddCar(Car cars)
        {
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[^1] = cars;
        }

        public void ShowAllCars(Car[] cars)
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Id}, {car.Name}, {car.Speed}, {car.CarCode} ");
            }
        }
        public Car FindCarById(int id)
        {
            foreach (var car in Cars)
            {
                if (car.Id == id)
                {
                    return car;
                }
            }
            return null;

        }

        public Car FindCarByCarCode(string carCode)
        {
            foreach (var car in Cars)
            {
                if (car.CarCode.ToUpper().Contains(carCode.ToUpper()))
                {

                    return car;
                }

            }
            return null;
        }

        public Car[] FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
        {
            Car[] wantedCars = new Car[0];
            foreach (var car in wantedCars)
            {
                if (car.Speed > minSpeed && car.Speed < maxSpeed)
                {
                    Array.Resize(ref wantedCars, wantedCars.Length + 1);
                    wantedCars[^1] = car;
                }
            }

            return wantedCars;
        }

    }
}
