
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Tigre.Models;

namespace Tigre.Repository
{
    public class Repository<T> : IRepository<T>, IDisposable where T : class
    {

        private readonly Context Context;
        protected Repository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseSqlServer("Data Source=WIN10-22Z4I0XY\\SQLEXPRESS;Initial Catalog=TigrePoc;Integrated Security=True");

            Context = new Context(optionsBuilder.Options);
        }
        public IEnumerable<T> GetAllEntity()
        {
            return Context.Set<T>();
        }

        public void Insert(T entity)
        {
            Context.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(Func<T, bool> predicate)
        {
            Context.Set<T>()
           .Where(predicate).ToList()
           .ForEach(del => Context.Set<T>().Remove(del));
        }
        public void Save()
        {
            Context.SaveChanges();
        }

        public T GetEntityByID(int studentId)
        {
            return Context.Set<T>().Find(studentId);           
           
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
