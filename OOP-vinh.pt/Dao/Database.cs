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
        public const string PRODUCT_TABLE_NAMES = "producttable";
        public const string CATEGORY_TABLE_NAMES = "categorytable";
        public const string ACCESSOTION_TABLE_NAMES = "accessotiontable";


        public int InsertTable(string name, Object row)
        {
            switch (name.ToLower())
            {
                case PRODUCT_TABLE_NAMES:
                    {
                        productTable.Add((Product)row);
                        break;
                    }
                case CATEGORY_TABLE_NAMES:
                    {
                        categoryTable.Add((Category)row);
                        break;
                    }
                case ACCESSOTION_TABLE_NAMES:
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
                case PRODUCT_TABLE_NAMES:
                    {
                        return PRODUCT_TABLE_NAMES.Cast<object>().ToList();
                    }
                case CATEGORY_TABLE_NAMES:
                    {
                        return CATEGORY_TABLE_NAMES.Cast<object>().ToList();
                    }
                case ACCESSOTION_TABLE_NAMES:
                    {
                        return ACCESSOTION_TABLE_NAMES.Cast<object>().ToList();
                    }
                default:
                    {
                        return null;
                    }
            }
            return null;

        }
        public int UpdateTable(string name, Object row)
        {
            switch (name.ToLower())
            {
                case PRODUCT_TABLE_NAMES:
                    {
                        Product newProduct = (Product)row;
                        int index = productTable.FindIndex(product => product.Id == newProduct.Id);
                        productTable[index] = newProduct;
                        break;
                    }
                case CATEGORY_TABLE_NAMES:
                    {
                        Category newCategory = (Category)row;
                        int index = categoryTable.FindIndex(category => category.Id == newCategory.Id);
                        categoryTable[index] = newCategory;
                        break;
                    }
                case ACCESSOTION_TABLE_NAMES:
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
                case PRODUCT_TABLE_NAMES:
                    {
                        return productTable.RemoveAll(product => product.Id == row) > 0 ? true : false;
                    }
                case CATEGORY_TABLE_NAMES:
                    {
                        return categoryTable.RemoveAll(category => category.Id == row) > 0 ? true : false;
                    }
                case ACCESSOTION_TABLE_NAMES:
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
                case PRODUCT_TABLE_NAMES:
                    {
                        productTable = new List<Product>();
                        break;
                    }
                case CATEGORY_TABLE_NAMES:
                    {
                        categoryTable = new List<Category>();
                        break;
                    }
                case ACCESSOTION_TABLE_NAMES:
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
                case PRODUCT_TABLE_NAMES:
                    {
                        Product newProduct = (Product)row;
                        int index = productTable.FindIndex(product => product.Id == newProduct.Id);
                        if (index == -1)
                            throw new Exception(string.Format("Can't not find Product has id = {0}", id));
                        productTable[index] = newProduct;
                        break;
                    }
                case CATEGORY_TABLE_NAMES:
                    {
                        Category newCategory = (Category)row;
                        int index = categoryTable.FindIndex(category => category.Id == newCategory.Id);
                        if (index == -1)
                        { 
                            string.Format("Can't not find Category has id = {0}", id); 
                        };
                        categoryTable[index] = newCategory;
                        break;
                    }
                case ACCESSOTION_TABLE_NAMES:
                    {
                        Accessotion newAccessotion = (Accessotion)row;
                        int index = accessotionTable.FindIndex(accessotion => accessotion.Id == newAccessotion.Id);
                        if (index == -1)
                        {
                            string.Format("Can't not find Accessotion has id = {0}", id);
                        };
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
