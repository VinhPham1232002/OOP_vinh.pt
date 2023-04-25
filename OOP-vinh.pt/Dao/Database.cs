using OOP_vinh.pt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_vinh.pt.Dao
{
    public class Database
    {
        public List<Product> productTable;
        private List<Category> categoryTable;
        private List<Accessotion> accessotionTable;
        public static Database instants = new Database();
        public Database()
        {
            productTable = new List<Product>();
            categoryTable = new List<Category>();
            accessotionTable = new List<Accessotion>();
        }
        public const string ProductTableNames = "producttable";
        public const string CategoryTableNames = "categorytable";
        public const string AccessotionTableNames = "accessotiontable";


        public int InsertTable(string name, Object row)
        {
            switch (name.ToLower())
            {
                case ProductTableNames:
                    {
                        productTable.Add((Product)row);
                        break;
                    }
                case CategoryTableNames:
                    {
                        categoryTable.Add((Category)row);
                        break;
                    }
                case AccessotionTableNames:
                    {
                        accessotionTable.Add((Accessotion)row);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return 0;
        }
        public List<object> SelectTable(string name)
        {
            switch (name.ToLower())
            {
                case ProductTableNames:
                    {
                        return ProductTableNames.Cast<object>().ToList();
                    }
                case CategoryTableNames:
                    {
                        return CategoryTableNames.Cast<object>().ToList();
                    }
                case AccessotionTableNames:
                    {
                        return AccessotionTableNames.Cast<object>().ToList();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
        public int UpdateTable(string name, Object row)
        {
            switch (name.ToLower())
            {
                case ProductTableNames:
                    {
                        Product newProduct  = (Product)row;
                        int index = productTable.FindIndex(product => product.Id == newProduct.Id);
                        productTable[index] = newProduct;
                        break;
                    }
                case CategoryTableNames:
                    {
                        Category newCategory = (Category)row;
                        int index = categoryTable.FindIndex(category => category.Id == newCategory.Id);
                        categoryTable[index] = newCategory;
                        break;
                    }
                case AccessotionTableNames:
                    {
                        Accessotion newAccessotion = (Accessotion)row;
                        int index = accessotionTable.FindIndex(accessotion => accessotion.Id == newAccessotion.Id);
                        accessotionTable[index] = newAccessotion;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return 0;
        }
        public bool DeleteTable(string name, int row)
        {
            switch (name.ToLower())
            {
                case ProductTableNames:
                    {
                        return productTable.RemoveAll(product => product.Id == row) > 0 ? true : false;
                    }
                case CategoryTableNames:
                    {
                        return categoryTable.RemoveAll(category => category.Id == row) > 0 ? true : false;
                    }
                case AccessotionTableNames:
                    {
                        return accessotionTable.RemoveAll(accessotion => accessotion.Id == row) > 0 ? true : false;
                    }
                default:
                    {
                        break;
                    }
            }
            return false;
        }
        public void TruncateTable(string name)
        {
            switch (name.ToLower())
            {
                case ProductTableNames:
                    {
                        productTable = new List<Product>();
                        break;
                    }
                case CategoryTableNames:
                    {
                        categoryTable = new List<Category>();
                        break;
                    }
                case AccessotionTableNames:
                    {
                        accessotionTable = new List<Accessotion>();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        public int UpdateTableById(string name, int id, Object row)
        {
            switch (name.ToLower())
            {
                case ProductTableNames:
                    {
                        Product newProduct = (Product)row;
                        int index = productTable.FindIndex(product => product.Id == newProduct.Id);
                        productTable[index] = newProduct;
                        break;
                    }
                case CategoryTableNames:
                    {
                        Category newCategory = (Category)row;
                        int index = categoryTable.FindIndex(category => category.Id == newCategory.Id);
                        categoryTable[index] = newCategory;
                        break;
                    }
                case AccessotionTableNames:
                    {
                        Accessotion newAccessotion = (Accessotion)row;
                        int index = accessotionTable.FindIndex(accessotion => accessotion.Id == newAccessotion.Id);
                        accessotionTable[index] = newAccessotion;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return 0;
        }

    }
}
