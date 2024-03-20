namespace ShopV2.Model
{
    public class ProductInform
    {
        public ProductInform(Product product, double price, DateOnly dateReceipt, DateOnly expireDate, int count)
        {
            Product = product;
            Price = price;
            DateReceipt = dateReceipt;
            ExpireDate = expireDate;
            Count = count;
        }
        public ProductInform() { }
        public int Id { get; set; }
        public Product Product { get; set; }
        /// <summary>
        /// Цена товара с учетом наценки
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Дата поступления товара
        /// </summary>
        public DateOnly DateReceipt { get; set; }
        /// <summary>
        /// Дата окончания срока годности товара
        /// </summary>
        public DateOnly ExpireDate { get; set; }
        public int Count { get; set; }
    }
}
