using System;

namespace CarSales
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesManager manager = new SalesManager();

            Car car1 = new Car("Toyota Camry", CarCategory.Sedan, 25000);
            Car car2 = new Car("Ford Explorer", CarCategory.SUV, 35000);
            Car car3 = new Car("Tesla Model S", CarCategory.ElectricCar, 80000);

            manager.AddSaleRecord(new SaleRecord(car1, 900, DateTime.Now));
            manager.AddSaleRecord(new SaleRecord(car2, 700, DateTime.Now));
            manager.AddSaleRecord(new SaleRecord(car3, 200, DateTime.Now));

            decimal sedanSales = manager.CalculateTotalSalesByCategory(CarCategory.Sedan);
            decimal suvSales = manager.CalculateTotalSalesByCategory(CarCategory.SUV);
            decimal electricSales = manager.CalculateTotalSalesByCategory(CarCategory.ElectricCar);

            Console.WriteLine($"Общий объем продаж седана: {sedanSales}$");
            Console.WriteLine($"Общий объем продаж внедорожников: {suvSales}$");
            Console.WriteLine($"Общий объем продаж электромобилей: {electricSales}$");
        }
    }
}