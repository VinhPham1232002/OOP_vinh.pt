﻿using OOP_vinh.pt.Dao;
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
        CategoryDao categoryDao = new CategoryDao();
        public CategoryDaoDemo()
        {

        }
        public void Init()
        {

        }
        public void InsertTest()
        {
            categoryDao.Insert(new Category());
        }

        public void UpdateTest()
        {
            categoryDao.Update(new Category());

        }
        public void DeleteTest()
        {
            categoryDao.Delete(new Category());
        }
        public void FindAllTest()
        {
            List<Category> categories = categoryDao.FindAll(new Category());
        }

        public void FindByNameTest()
        {
            Category category = categoryDao.FindByName("");
        }

        public void FindByIdTest()
        {
            Category category = categoryDao.FindById(1);
        }
    }
}
