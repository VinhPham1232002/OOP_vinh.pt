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
        public static Database instants = new Database();

        private static List<BaseRow> productTable = new();
        private static List<BaseRow> categoryTable = new();
        private static List<BaseRow> accessotionTable = new();

        public const string PRODUCT_TABLE_NAMES = "producttable";
        public const string CATEGORY_TABLE_NAMES = "categorytable";
        public const string ACCESSOTION_TABLE_NAMES = "accessotiontable";
        private static Dictionary<string, List<BaseRow>> dictionary = new() {
            {PRODUCT_TABLE_NAMES,productTable},
            {CATEGORY_TABLE_NAMES,categoryTable},
            {ACCESSOTION_TABLE_NAMES,accessotionTable}
        };



        private static Database instance;
        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }
        private Database() { }
        public int InsertTable(string name, BaseRow row)
        {
            name = name.ToLower();
            if (dictionary.ContainsKey(name.ToLower()))
            {
                dictionary[name].Add(row);
            }
            return 0;
        }
        public int UpdateTable(string name, BaseRow row)
        {
            name = name.ToLower();
            if (dictionary.ContainsKey(name))
            {
                int index = dictionary[name].FindIndex(p => p.Id == row.Id);
                if (index == -1)
                    //throw new Exception(string.Format("Can't find {0} has value = {1}", row.GetType(), row.ToString()));
                    return -1;
                dictionary[name][index] = row;
                return index;
            }
            return -1;
        }
        public bool DeleteTable(string name, BaseRow row)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                return dictionary[name].RemoveAll(p => p.Id == row.Id) > 0 ? true : false;
            }
            return false;
        }
        public void TruncateTable(string name)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                dictionary[name].Clear();
            }
            return;
        }
        public List<BaseRow> SelectTable(string name)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                return dictionary[name].ToList();
            }
            return null;
        }
        public List<BaseRow> SelectTable(string name, Func<BaseRow, bool> where)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                return dictionary[name].ToList();
            }
            return null;
        }
        public bool Save(string name, List<BaseRow> data)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                dictionary[name] = data;
                return dictionary[name] == data;
            }
            return false;
        }

    }
}
