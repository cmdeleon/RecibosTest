using Data.Layer.Base;
using Entity.Layer;

namespace Data.Layer.Data
{
    public class ProveedorData : Repository<Proveedor>
    {
        public ProveedorData(string connectionString) : base(connectionString) { }
    }
}
