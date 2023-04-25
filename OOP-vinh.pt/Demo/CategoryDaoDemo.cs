using OOP_vinh.pt.Dao;
using OOP_vinh.pt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_vinh.pt.Demo
{
    public class CategoryDaoDemo
    {
        CategoryDao category=new CategoryDao();
        public void insertTest()
        {
            category.Insert(new Category());
        }
        public void updateTest()
        {
            category.Update(new Category());
        }
        public void findAllTest()
        {
            category.FindAll(new Category());
        }
       
    }
}
