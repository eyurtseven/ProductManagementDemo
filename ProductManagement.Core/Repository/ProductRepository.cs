using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ProductManagement.Core.Infrastructure;
using ProductManagement.Data;

namespace ProductManagement.Core.Repository
{
    public class ProductRepository : ProductManagementContext, IRepository<Product>
    {
        public IEnumerable<Product> GetAll()
        {
            return Entities.Product;
        }

        public IEnumerable<Product> Get(Func<Product, bool> predicate)
        {
            return Entities.Product.Where(predicate);
        }

        public Product GetById(int id)
        {
            return Entities.Product.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Product entity)
        {
            if (entity == null) return;

            Entities.Product.Add(entity);
            Entities.SaveChanges();
        }

        public void Delete(Product entity)
        {
            if (entity == null) return;
            
            Entities.Product.Remove(entity);
            Entities.SaveChanges();
        }

        public void Update(Product entity)
        {
            if (entity == null) return;

            Entities.Product.AddOrUpdate(entity);
            Entities.SaveChanges();
        }
    }
}
