namespace ExampleApp.Models
{
    /// <summary>
    /// Модель, описывающая продукт
    /// </summary>
    public class Product
    {   
        /// <summary>
        /// Идентификатор
        /// </summary>
        /// <returns></returns>
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        /// <returns></returns>
        public string Name { get; set; }

        /// <summary>
        /// Категория
        /// </summary>
        /// <returns></returns>
        public string Category { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        /// <returns></returns>
        public decimal Price { get; set; }

        public Product() {}

        public Product(string name = null, string category = null, decimal price = 0)
        {
            Name = name;
            Category = category;
            Price = price;
        }
    }
}