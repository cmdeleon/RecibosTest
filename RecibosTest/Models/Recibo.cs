using System;
using System.Collections.Generic;
using System.Linq;

namespace RecibosTest.Models
{
    public class Recibo
    {
        public long Id { get; set; }
        public decimal Monto { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
        public string FechaStr { get; set; }
        public long MonedaId { get; set; }
        public string Moneda { get; set; }
        public long ProveedorId { get; set; }
        public string Proveedor { get; set; }
        public bool Estado { get; set; }
        public long UserReg { get; set; }
        public long? UserMod { get; set; }

        public static Recibo ToModel(Entity.Layer.Recibo entity)
        {
            return new Recibo
            {
                Id = entity.Id,
                Monto = entity.Monto,
                Comentario = entity.Comentario,
                Fecha = entity.Fecha,
                FechaStr = entity.Fecha.ToString("dd/MM/yyyy"),
                MonedaId = entity.MonedaId,
                Moneda = entity.Moneda.Nombre,
                ProveedorId = entity.ProveedorId,
                Proveedor = entity.Proveedor.Nombre,
                Estado = entity.Estado,
                UserReg = entity.UserReg,
                UserMod = entity.UserMod
            };
        }

        public static List<Recibo> ToList(List<Entity.Layer.Recibo> list)
        {
            return list.Select(item => ToModel(item)).ToList();
        }

        public static Entity.Layer.Recibo ToOriginal(Recibo entity)
        {
            return new Entity.Layer.Recibo
            {
                Id = entity.Id,
                Monto = entity.Monto,
                Comentario = entity.Comentario,
                Fecha = entity.Fecha,
                MonedaId = entity.MonedaId,
                ProveedorId = entity.ProveedorId,
                Estado = entity.Estado,
                UserReg = entity.UserReg,
                UserMod = entity.UserMod
            };
        }
    }
}