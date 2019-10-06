using System.Collections.Generic;
using System.Linq;

namespace RecibosTest.Models
{
    public class Proveedor
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public long UserReg { get; set; }
        public long? UserMod { get; set; }

        public static Proveedor ToModel(Entity.Layer.Proveedor entity)
        {
            return new Proveedor
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                Estado = entity.Estado,
                UserReg = entity.UserReg,
                UserMod = entity.UserMod
            };
        }

        public static List<Proveedor> ToList(List<Entity.Layer.Proveedor> list)
        {
            return list.Select(item => ToModel(item)).ToList();
        }

        public static Entity.Layer.Proveedor ToOriginal(Proveedor entity)
        {
            return new Entity.Layer.Proveedor
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                Estado = entity.Estado,
                UserReg = entity.UserReg,
                UserMod = entity.UserMod
            };
        }
    }
}