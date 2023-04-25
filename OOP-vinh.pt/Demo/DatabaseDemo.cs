using OOP_vinh.pt.Dao;
using OOP_vinh.pt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_vinh.pt.Demo
{
    public class DatabaseDemo
    {
        public void InsertTableTest()
        {
            Database.instants.InsertTable("ProductTable", new Product());

        }
        public void UpdateTableTest()
        {
            Database.instants.UpdateTable("CategoryTable", new Category());
        }
        public void DeleteTableTest()
        {
            Database.instants.DeleteTable("AccessotionTable", 0);
        }
        public void TruncateTableTest()
        {
            Database.instants.TruncateTable("ProductTable");
            Database.instants.TruncateTable("CategoryTable");
            Database.instants.TruncateTable("AccessotionTable");
        }
        public void InitDatabase()
        {
            Database.instants = new Database();
        }
        public void PrintTableTest()
        {
            Console.WriteLine("------ProductTable");
            foreach (Product product in Database.instants.SelectTable("ProductTable"))
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("------CategoryTable");
            foreach (Category category in Database.instants.SelectTable("CategoryTable"))
            {
                Console.WriteLine(category);
            }
            Console.WriteLine("------AccessotionTable");
            foreach (Accessotion accessotion in Database.instants.SelectTable("AccessotionTable"))
            {
                Console.WriteLine(accessotion);
            }
        }
    }
}
