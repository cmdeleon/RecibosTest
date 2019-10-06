using System.Data.Entity;

namespace Entity.Layer
{
    public partial class ProveedoresConnection : DbContext
    {
        public ProveedoresConnection(string ConnectionString) : base(ConnectionString) { }
    }
}
