using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.SRP.Bad
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static List<Product> ProductList = new List<Product>();
        public List<Product> GetProducts => ProductList;
        public Product()
        {
            ProductList = new()
            {
                new(){Id=1,Name="Product1"},
                new(){Id=2,Name="Product2"},
                new(){Id=3,Name="Product3"},
                new(){Id=4,Name="Product4"},
                new(){Id=5,Name="Product5"}
            };
        }

        public void SaveOrUpdate(Product product)
        {
            var hasProduct = ProductList.Any(m=>m.Id== product.Id);

            if(!hasProduct)
            {
                ProductList.Add(product);
            }
            else
            {
                var index = ProductList.FindIndex(m=>m.Id== product.Id);
                ProductList[index] = product;
            }
        }

        public void Delete(int id)
        {
            var hasProduct = ProductList.Find(m=>m.Id == id);

            if(hasProduct == null)
            {
                throw new Exception("Product Not Found !");

            }

            ProductList.Remove(hasProduct);
            
        }

        public void WriteToConsole()
        {
            ProductList.ForEach(m =>
            {
                Console.WriteLine($"{m.Id} , {m.Name}");
            });
        }
    }
}
