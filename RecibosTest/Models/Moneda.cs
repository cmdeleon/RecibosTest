using System.Collections.Generic;
using System.Linq;

namespace RecibosTest.Models
{
    public class Moneda
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public long UserReg { get; set; }
        public long? UserMod { get; set; }

        public static Moneda ToModel(Entity.Layer.Moneda entity)
        {
            return new Moneda
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                Estado = entity.Estado,
                UserReg = entity.UserReg,
                UserMod = entity.UserMod
            };
        }

        public static List<Moneda> ToList(List<Entity.Layer.Moneda> list)
        {
            return list.Select(item => ToModel(item)).ToList();
        }

        public static Entity.Layer.Moneda ToOriginal(Moneda entity)
        {
            return new Entity.Layer.Moneda
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