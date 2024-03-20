namespace ShopV2.Model
{
    public class Product
    {
        public Product(string name, string description, double price, string pythImg)
        {
            Name = name;
            Description = description;
            Price = price;
            PythImg = pythImg;
        }
        public Product() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// себестоимость продукта
        /// </summary>
        public double Price { get; set; }
        public string PythImg { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Price:{Price} \n Путь к изображению:{PythImg} \n {Description}";
        }

    }
}
