using System.Collections.Generic;
using System.Linq;

namespace RecibosTest.Models
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long RolId { get; set; }
        public bool Estado { get; set; }    

        public static Usuario ToModel(Entity.Layer.Usuario entity)
        {
            return new Usuario
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                Username = entity.Username,
                Password = entity.Password,
                RolId = entity.RolId,
                Estado = entity.Estado               
            };
        }

        public static List<Usuario> ToList(List<Entity.Layer.Usuario> list)
        {
            return list.Select(item => ToModel(item)).ToList();
        }

        public static Entity.Layer.Usuario ToOriginal(Usuario entity)
        {
            return new Entity.Layer.Usuario
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                Username = entity.Username,
                Password = entity.Password,
                RolId = entity.RolId,
                Estado = entity.Estado
            };
        }
    }
}