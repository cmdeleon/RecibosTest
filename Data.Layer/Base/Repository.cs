using Entity.Layer;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Data.Layer.Base
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private string _connString;

        public Repository(string connectionString)
        {
            _connString = connectionString;
        }

        public void Add(T entity)
        {
            using (var context = new ProveedoresConnection(_connString))
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public object Create(T entity, string propName)
        {
            using (var context = new ProveedoresConnection(_connString))
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
                return entity.GetType().GetProperty(propName).GetValue(entity, null);
            }
        }

        public void Update(T entity)
        {
            using (var context = new ProveedoresConnection(_connString))
            {
                context.Entry<T>(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new ProveedoresConnection(_connString))
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public T Get(long Id)
        {
            using (var context = new ProveedoresConnection(_connString))
                return context.Set<T>().Find((object)Id);
        }

        public IEnumerable<T> GetAll()
        {
            return (IEnumerable<T>)new ProveedoresConnection(_connString).Set<T>().ToList<T>();
        }
    }
}
