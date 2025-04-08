using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSales
{
    public class SalesManager
    {

        private List<SaleRecord> _salesRecords;

        public SalesManager()
        {
            _salesRecords = new List<SaleRecord>();
        }

        public void AddSaleRecord(SaleRecord record)
        {
            _salesRecords.Add(record);
        }

        public decimal CalculateTotalSalesByCategory(CarCategory category)
        {
            return _salesRecords
                .Where(record => record.Car.Category == category)
                .Sum(record => record.Car.Price * record.Quantity);
        }
    }
}