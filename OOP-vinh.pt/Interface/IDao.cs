using OOP_vinh.pt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_vinh.pt.Interface
{
    public interface IDao<T> where T : BaseRow
    {
        public List<T> FindAll(T row);
        public BaseRow FindById(int id);
        public BaseRow FindByName(string name);
        public int Insert(T row);
        public int Update(T row);
        public bool Delete(T row);
        public void PrintAll();
    }
}
