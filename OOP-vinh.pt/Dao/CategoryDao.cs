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
        private static List<Category> category = Database.instants.SelectTable(Database.CATEGORY_TABLE_NAMES).Cast<Category>().ToList();
        
        public int Insert(Category row)
        {
            return Database.instants.InsertTable(Database.CATEGORY_TABLE_NAMES, row);
        }
        public int Update(Category row)
        {
            return Database.instants.UpdateTable(Database.CATEGORY_TABLE_NAMES, row);
        }
        public List<Category> FindAll(Category row)
        {
            return category.FindAll(p => p.Id == row.Id);
        }
        public Category FindById(int id)
        {
            return category.Find(p => p.Id == id);
        }
        
    }
}
