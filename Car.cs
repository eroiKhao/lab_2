using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Car_Rental_System
{
    internal class Car
    {
        public string CarModel { get; set; }
        public string Status { get; set; }

        public Car(string carModel, string status)
        {
            CarModel = carModel;
            Status = status;
        }

        public static List<Car> LoadCarsFromFile(string filePath)
        {
            var cars = new List<Car>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 2)
                    {
                        var car = new Car(parts[0].Trim(), parts[1].Trim());
                        cars.Add(car);
                    }
                }
            }

            return cars;
        }

        public static void SaveCarsToFile(string filePath, List<Car> cars)
        {
            var lines = cars.Select(car => $"{car.CarModel} | {car.Status}");
            File.WriteAllLines(filePath, lines);
        }
    }
}
