using Data.Layer.Base;
using Entity.Layer;

namespace Data.Layer.Data
{
    public class UsuarioData : Repository<Usuario>
    {
        public UsuarioData(string connectionString) : base(connectionString) { }
    }
}
