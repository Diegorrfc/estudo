using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tigre.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAllEntity();
        T GetEntityByID(int studentId);
        void Insert(T entity);
        void Delete(Func<T, bool> predicate);
        void Update(T entity);
        void Save();

    }
}
