using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected oddbContext OddbContext;
        public RepositoryBase(oddbContext oddbContext)
        {
            OddbContext = oddbContext;
        }
        public void Create(T entity) => OddbContext.Set<T>().Add(entity);


        public void Delete(T entity) => OddbContext.Set<T>().Remove(entity);
        

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
            OddbContext.Set<T>()
            .AsNoTracking() :
            OddbContext.Set<T>();


        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ?
            OddbContext.Set<T>()
            .Where(expression)
            .AsNoTracking() :
            OddbContext.Set<T>()
            .Where(expression);


        public void Update(T entity) => OddbContext.Set<T>().Update(entity);
        
    }
}
