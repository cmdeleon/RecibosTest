using System.Collections.Generic;

namespace Data.Layer.Base
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        object Create(T entity, string propName);
        void Update(T entity);
        void Delete(T entity);
        T Get(long Id);
        IEnumerable<T> GetAll();
    }
}
