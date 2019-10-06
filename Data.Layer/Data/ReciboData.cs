using Data.Layer.Base;
using Entity.Layer;

namespace Data.Layer.Data
{
    public class ReciboData : Repository<Recibo>
    {
        public ReciboData(string connectionString) : base(connectionString) { }
    }
}
