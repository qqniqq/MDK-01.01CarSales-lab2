using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSales
{
    public class SalesManager
    {
        // Приватное поле для хранения записей о продажах
        private List<SaleRecord> _salesRecords;

        public SalesManager()
        {
            _salesRecords = new List<SaleRecord>();
        }

        // Метод для добавления записи о продаже
        public void AddSaleRecord(SaleRecord record)
        {
            _salesRecords.Add(record);
        }

        // Метод для подсчета суммы проданного по товарной группе
        public decimal CalculateTotalSalesByCategory(CarCategory category)
        {
            return _salesRecords
                .Where(record => record.Car.Category == category)
                .Sum(record => record.Car.Price * record.Quantity);
        }
    }
}