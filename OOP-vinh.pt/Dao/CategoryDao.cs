using OOP_vinh.pt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_vinh.pt.Dao
{

    public class CategoryDao
    {
        private static List<Category> category = Database.instants.SelectTable(Database.ProductTableNames).Cast<Category>().ToList();
        
        public int Insert(Category row)
        {
            return Database.instants.InsertTable(Database.CategoryTableNames, row);
        }
        public int Update(Category row)
        {
            return Database.instants.UpdateTable(Database.CategoryTableNames, row);
        }
        public List<Category> FindAll(Category row)
        {
            return category.FindAll(p => p.Name == row.Name);
        }
        public Category FindById(int id)
        {
            return category.Find(p => p.Id == id);
        }
        public Category FindByName(string name)
        {
            return category.Find(p => p.Name == name);
        }
        

    }
}
