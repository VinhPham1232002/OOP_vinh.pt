using OOP_vinh.pt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_vinh.pt.Demo
{
    internal class ProductDemo
    {
        public void CreateProductTest()
        {
            Product product = new Product();
        }

        public void PrintProduct(Product product)
        {
            Console.WriteLine(product);
        }
    }
}
