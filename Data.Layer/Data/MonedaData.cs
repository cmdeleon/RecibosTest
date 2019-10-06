using Data.Layer.Base;
using Entity.Layer;

namespace Data.Layer.Data
{
    public class MonedaData : Repository<Moneda>
    {
        public MonedaData(string connectionString) : base(connectionString) { }
    }
}
