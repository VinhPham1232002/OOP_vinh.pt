using OOP_vinh.pt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_vinh.pt.Dao
{
    public abstract class BaseDao<T> where T : BaseRow
    {
        public List<T> FindAll(T row)
        {
            string tableName = "";
            if (row is Accessotion)
            {
                tableName = Database.ACCESSOTION_TABLE_NAMES;
            }
            else if (row is Category)
            {
                tableName = Database.CATEGORY_TABLE_NAMES;
            }
            else if (row is Product)
            {
                tableName = Database.PRODUCT_TABLE_NAMES;
            }
            return Database.Instance.SelectTable(tableName).FindAll(p => p.Name == row.Name)
                .Cast<T>().ToList();
        }
        public T FindById(int id)
        {
            string tableName = "";
            if (typeof(T) == typeof(Accessotion))
            {
                tableName = Database.ACCESSOTION_TABLE_NAMES;
            }
            else if (typeof(T) == typeof(Category))
            {
                tableName = Database.CATEGORY_TABLE_NAMES;
            }
            else if (typeof(T) == typeof(Product))
            {
                tableName = Database.PRODUCT_TABLE_NAMES;
            }
            return Database.Instance.SelectTable(tableName)
                .Cast<T>().ToList().Find(p => p.Id == id);
        }
        public T FindByName(string name)
        {
            string tableName = "";
            if (typeof(T).Equals(typeof(Accessotion)))
            {
                tableName = Database.ACCESSOTION_TABLE_NAMES;
            }
            else if (typeof(T).Equals(typeof(Category)))
            {
                tableName = Database.CATEGORY_TABLE_NAMES;
            }
            else if (typeof(T).Equals(typeof(Product)))
            {
                tableName = Database.PRODUCT_TABLE_NAMES;
            }
            return Database.Instance.SelectTable(tableName).Cast<T>().ToList().Find(p => p.Name.Equals(name));
        }
        public int Insert(T row)
        {
            string tableName = "";
            if (typeof(T) == typeof(Accessotion))
            {
                tableName = Database.ACCESSOTION_TABLE_NAMES;
            }
            else if (typeof(T) == typeof(Category))
            {
                tableName = Database.CATEGORY_TABLE_NAMES;
            }
            else if (typeof(T) == typeof(Product))
            {
                tableName = Database.PRODUCT_TABLE_NAMES;
            }
            return Database.Instance.InsertTable(tableName, row);
        }
        public bool Delete(T row)
        {
            if (typeof(T).Equals(typeof(Accessotion)))
            {
                return Database.Instance.DeleteTable(Database.ACCESSOTION_TABLE_NAMES, row);
            }
            else if (typeof(T).Equals(typeof(Category)))
            {
                return Database.Instance.DeleteTable(Database.CATEGORY_TABLE_NAMES, row);
            }
            else if (typeof(T).Equals(typeof(Product)))
            {
                return Database.Instance.DeleteTable(Database.PRODUCT_TABLE_NAMES, row);
            }
            return false;
        }
        public int Update(T row)
        {
            string tableName = "";
            if (typeof(T) == typeof(Accessotion))
            {
                tableName = Database.ACCESSOTION_TABLE_NAMES;
            }
            else if (typeof(T) == typeof(Category))
            {
                tableName = Database.CATEGORY_TABLE_NAMES;
            }
            else if (typeof(T) == typeof(Product))
            {
                tableName = Database.PRODUCT_TABLE_NAMES;
            }
            return Database.Instance.UpdateTable(tableName, row);
        }
        public void PrintAll()
        {
            string tableName = "";
            if (typeof(T) == typeof(Accessotion))
            {
                tableName = Database.ACCESSOTION_TABLE_NAMES;
            }
            else if (typeof(T) == typeof(Category))
            {
                tableName = Database.CATEGORY_TABLE_NAMES;
            }
            else if (typeof(T) == typeof(Product))
            {
                tableName = Database.PRODUCT_TABLE_NAMES;
            }
            foreach (T obj in Database.Instance.SelectTable(tableName).Cast<T>().ToList())
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}

