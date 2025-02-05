using System;

namespace CarSales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем менеджера продаж
            SalesManager manager = new SalesManager();

            // Создаем несколько автомобилей
            Car car1 = new Car("Toyota Camry", CarCategory.Sedan, 25000);
            Car car2 = new Car("Ford Explorer", CarCategory.SUV, 35000);
            Car car3 = new Car("Tesla Model S", CarCategory.Electric, 80000);

            // Добавляем записи о продажах
            manager.AddSaleRecord(new SaleRecord(car1, 2, DateTime.Now));
            manager.AddSaleRecord(new SaleRecord(car2, 1, DateTime.Now));
            manager.AddSaleRecord(new SaleRecord(car3, 3, DateTime.Now));

            // Подсчитываем сумму проданного по категориям
            decimal sedanSales = manager.CalculateTotalSalesByCategory(CarCategory.Sedan);
            decimal suvSales = manager.CalculateTotalSalesByCategory(CarCategory.SUV);
            decimal electricSales = manager.CalculateTotalSalesByCategory(CarCategory.Electric);

            // Выводим результаты
            Console.WriteLine($"Total sales for Sedan: {sedanSales:C}");
            Console.WriteLine($"Total sales for SUV: {suvSales:C}");
            Console.WriteLine($"Total sales for Electric: {electricSales:C}");
        }
    }
}