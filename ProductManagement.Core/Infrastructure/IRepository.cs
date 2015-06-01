using System;
using System.Collections.Generic;
using ProductManagement.Data;

namespace ProductManagement.Core.Infrastructure
{
    public interface IRepository<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(Func<T, bool> predicate);
        T GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
