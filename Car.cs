namespace CarSales
{
    public class Car
    {
        // Приватные поля
        private string _model;
        private CarCategory _category;
        private decimal _price;

        // Конструктор
        public Car(string model, CarCategory category, decimal price)
        {
            _model = model;
            _category = category;
            _price = price;
        }

        // Свойства для доступа к полям
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public CarCategory Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}