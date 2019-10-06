using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Layer.Interface
{
    public interface Base<T> where T : class
    {
        void Save(T entity);
        void Delete(long id);
        T Get(long id);
        List<T> GetAll();        
    }
}
