using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHongAnh_SuDungLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cau2 
            Console.WriteLine("2a");
            var CarPrice = cars.Where(car => car.GiaTien >= 100000f && car.GiaTien <= 250000f).ToList();
            Console.WriteLine("Cac xe co gia tien trong khoang 100000 - 250000 la: ");
            foreach (var car in CarPrice)
            {
                Console.WriteLine($"Ten phuong tien: {car.TenPT}, Gia tien: {car.GiaTien}");
            }

            Console.WriteLine("2b");
            var CarYear = cars.Where(car => car.NamSX > 1990).ToList();
            Console.WriteLine("Cac xe san xuat sau nam 1990 la: ");
            foreach (var car in CarYear)
            {
                Console.WriteLine($"Ten phuong tien: {car.TenPT}, Nam san xuat: {car.NamSX}");
            }

            Console.WriteLine("2c");
            var CarGroup = cars.GroupBy(car => car.NhaSX).Select(group => new
            {
                NhaSanXuat = group.Key,
                TongSoLuong = group.Count(),
                TongGiaTri = group.Sum(car => car.GiaTien)
            }).ToList();

            Console.WriteLine("2c - Car by manufacturer:");
            CarGroup.ForEach(group => Console.WriteLine($"Manufacturer: {group.NhaSanXuat}, Count: {group.TongSoLuong}, Total Price: {group.TongGiaTri}"));

            //Cau 3
            Console.WriteLine("3a");
            var TruckYear = trucks.OrderByDescending(truck => truck.NamSX).ToList();
            Console.WriteLine("Danh sach Truck theo thu tu nam san xuat: ");
            foreach (var truck in TruckYear)
            {
                Console.WriteLine($"Ten Truck:  {truck.TenPT}, Nam san xuat: {truck.NamSX}");
            }

            Console.WriteLine("3b");
            var

            Console.ReadLine();
        }

        //danh sách các Car
        private static List<Car> cars = new List<Car>
        {
            new Car("Toyota Camry", 1970, 150000, "Toyota"),
            new Car("Toyota Corolla Altis", 2000, 120000, "Toyota"),
            new Car("Toyota Vios", 1980, 180000, "Toyota"),
            new Car("Ford Ranger", 2022, 200000, "Ford"),
            new Car("Ford Explorer", 2023, 300000, "Ford"),
            new Car("Ford Transit", 2020, 270000, "Ford"),
            new Car("Ford Territory", 1985, 290000, "Ford"),
            new Car("Honda Brio", 2024, 70000, "Honda"),
            new Car("Honda Civic", 2020, 350000, "Honda"),
            new Car("Honda Accord", 2019, 200000, "Honda"),
        };

        //danh sách các Truck
        private static List<Truck> trucks = new List<Truck>
        {
            new Truck("Toyota Hilux Champ", 2024, 300000, "Toyota"),
            new Truck("Toyota IMV", 2022, 150000, "Toyota"),
            new Truck("Chevrolet Colorado", 2017, 100000, "Chevrolet"),
            new Truck("Ford WildTrack", 2019, 250000, "Ford"),
        };
    }
}
