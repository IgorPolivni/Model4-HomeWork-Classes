using System;

namespace Model4_HomeWork_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sizeMas = 5;
            Car[] cars = new Car[sizeMas] {   new Car("Priora", 4, "Russia", false, 3000), 
                                        new Car("Lexus NX", 4 ,"Japan", true, 40475),
                                        new Car("Skoda Kodiaq", 6,"Czech",true,35713),
                                        new Car("BMW X4",4,"Germany",true,47618),
                                        new Car ("Lada Largus Cross",6,"Russia",false,13380)
            };

            foreach(Car car in cars)
            {
                car.GetCarInfo();
            }

            Car.PrintCountCars();
        }
    }

    public partial class Car
    {
        public static void PrintCountCars()
        {
            Console.WriteLine($"\nCount of Cars {_countCars}");
        }
    }
}
