using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliSalmeh_ProjectWeek10_InventoryOfProducts
{
    public class Product<T>
    {
        public string Name { get; set; }
        public ProductCategory Category { get; set; }
        public T Details { get; set; }

        public Product(string name, ProductCategory category, T details)
        {
            Name = name;
            Category = category;
            Details = details;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(
                $"Name: {Name}\n" +
                $"Category: {Category}\n" +
                $"Details: {Details}");
        }
    }
}