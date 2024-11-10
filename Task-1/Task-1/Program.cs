using System.Security.Cryptography.X509Certificates;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(1, "BMW", 100, "bmw100");
            Car car2 = new Car(2, "Mercedes", 200, "mercedes200");
            Car car3 = new Car(3, "Kia", 300, "kia300");
            Car car4 = new Car(4, "Toyota", 400, "toyota400");


            Gallery gallery = new Gallery();

            gallery.AddCar(car1);
            gallery.AddCar(car2);
            gallery.AddCar(car3);
            gallery.AddCar(car4);

            Car wantedCar = gallery.FindCarByCarCode("me");

            if (wantedCar != null)
            {
                Console.WriteLine(wantedCar.Name);
            }
            else
            {
                Console.WriteLine("Nothing");
            }

            gallery.ShowAllCars(gallery.Cars);

           Car[] wantedCars = gallery.FindCarsBySpeedInterval(100,200);

            foreach (var cars in wantedCars)
            {
              Console.WriteLine(cars.Name);
            }

        }
    }
}
