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
            public void insertTableTest()
            {
                Database.Instance.InsertTable("productTable", new Product());
                

                Database.Instance.InsertTable("categoryTable", new Category());
               

                Database.Instance.InsertTable("accessotionTable", new Accessotion());
                
            }

            public void updateTableTest()
            {
                Database.Instance.UpdateTable("categoryTable", new Category());
                Database.Instance.UpdateTable("accessotionTable", new Accessotion());
                Database.Instance.UpdateTable("productTable", new Product());
            }
            public void deleteTableTest()
            {
                Database.Instance.DeleteTable("categoryTable", new Category());
                Database.Instance.DeleteTable("productTable", new Category());
                Database.Instance.DeleteTable("accessotionTable", new Category());

            }
            public void truncateTableTest()
            {
                Database.Instance.TruncateTable("accessotionTable");
                Database.Instance.TruncateTable("productTable");
                Database.Instance.TruncateTable("categoryTable");
            }
            public void initDatabase()
            {

            }

            public void printTableTest()
            {
                Console.WriteLine("---------Category Table");
                foreach (Category category in Database.Instance.SelectTable("categoryTable").ToList())
                {
                    Console.WriteLine(category);
                }
                Console.WriteLine("---------Product Table");
                foreach (Product product in Database.Instance.SelectTable("productTable").ToList())
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine("---------Accessotion Table");
                foreach (Accessotion accessotion in Database.Instance.SelectTable("accessotionTable").ToList())
                {
                    Console.WriteLine(accessotion);
                }
                Console.WriteLine("---------Select Where");
            }

        }
    }

