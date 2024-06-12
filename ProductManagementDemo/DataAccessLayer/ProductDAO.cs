/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Collections.Generic;
using System.Linq;
using BusinessObjects;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static List<Product> listProducts;

        static ProductDAO()
        {
            // Initializing the in-memory database
            listProducts = new List<Product>
            {
                new Product(1, "Chai", 3, 12, 18),
                new Product(2, "Chang", 1, 23, 19),
                new Product(3, "Aniseed Syrup", 2, 23, 10),
                new Product(4, "Chef Anton's Cajun Seasoning", 2, 34, 22),
                new Product(5, "Chef Anton's Gumbo Mix", 2, 45, 34),
                new Product(6, "Grandma's Boysenberry Spread", 2, 21, 25),
                new Product(7, "Uncle Bob's Organic Dried Pears", 7, 22, 30),
                new Product(8, "Northwoods Cranberry Sauce", 2, 10, 40),
                new Product(9, "Mishi Kobe Niku", 6, 12, 97),
                new Product(10, "Ikura", 8, 13, 32)
            };
        }

        public static List<Product> GetProducts()
        {

            return listProducts;
        }


        public static void SaveProduct(Product p)
        {
            listProducts.Add(p);
        }
        public static void UpdateProduct(Product product)
        {
            {
                foreach (Product p in listProducts.ToList())
                    if (p.ProductId == product.ProductId)
                    {
                        p.ProductId = product.ProductId;
                        p.ProductName = product.ProductName;
                        p.UnitPrice = product.UnitPrice;
                        p.UnitsInStock = product.UnitsInStock;
                        p.CategoryId = product.CategoryId;
                    }
            }
        }

        public static void DeleteProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == product.ProductId)
                {
                    listProducts.Remove(p);
                }
            }
        }
        public static Product GetProductById(int id)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == id)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
