using OOP_vinh.pt.Dao;
using OOP_vinh.pt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_vinh.pt.Demo
{
    public class ProductDaoDemo
    {
        ProductDao productDao = new ProductDao();
        public ProductDaoDemo()
        {

        }
        public void Init()
        {
            
        }
        public void InsertTest()
        {
            productDao.Insert(new Product());
        }

        public void UpdateTest()
        {
            productDao.Update(new Product());
            
        }
        public void DeleteTest()
        {
            productDao.Delete(new Product());
        }
        public void FindAllTest()
        { 
            List<Product> products = productDao.FindAll(new Product());
        }

        public void FindByNameTest()
        {
            Product product = productDao.FindByName("");
        }

        public void FindByIdTest()
        {
            Product product = productDao.FindById(1);
        }
    }
}

