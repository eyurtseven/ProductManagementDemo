using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ProductManagement.Core.Infrastructure;
using ProductManagement.Data;

namespace ProductManagement.Core.Repository
{
    public class CategoryRepository : ProductManagementContext, IRepository<Category>
    {
        public IEnumerable<Category> GetAll()
        {
            return Entities.Category;
        }

        public IEnumerable<Category> Get(Func<Category, bool> predicate)
        {
            return Entities.Category.Where(predicate);
        }

        public Category GetById(int id)
        {
            return Entities.Category.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Category entity)
        {
            if (entity == null) return;

            Entities.Category.Add(entity);
            Entities.SaveChanges();
        }

        public void Delete(Category entity)
        {
            if (entity == null) return;

            Entities.Category.Remove(entity);
            Entities.SaveChanges();
        }

        public void Update(Category entity)
        {
            if (entity == null) return;

            Entities.Category.AddOrUpdate(entity);
            Entities.SaveChanges();
        }
    }
}
