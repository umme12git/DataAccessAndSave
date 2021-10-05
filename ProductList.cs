using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAndSave
{
    public class ProductList
    {
        public ProductList()
        {

        }
        public static void GetData()
        {
            Product productOne = new Product() { productName = "desk", productPrice = 300.00 };
            Product productTwo = new Product() { productName = "chair", productPrice = 120.80 };
            var currentList = new List<IProduct>();

            currentList.Add(productOne);
            currentList.Add(productTwo);
            Console.WriteLine();
            Console.WriteLine("*****Product List*****");
            Console.WriteLine();
            foreach(var product in currentList)
            {
                Console.WriteLine($"{product.productName}     {product.productPrice}");
            }
            Console.WriteLine();

        }
        
    }
}
