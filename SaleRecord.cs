using System;

namespace CarSales
{
    public class SaleRecord
    {
        private Car _car;
        private int _quantity;
        private DateTime _saleDate;

        public SaleRecord(Car car, int quantity, DateTime saleDate)
        {
            _car = car;
            _quantity = quantity;
            _saleDate = saleDate;
        }

        // Свойства для доступа к полям
        public Car Car
        {
            get { return _car; }
            set { _car = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public DateTime SaleDate
        {
            get { return _saleDate; }
            set { _saleDate = value; }
        }
    }
}