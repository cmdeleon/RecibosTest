using Service.Layer.Interface;
using System.Collections.Generic;
using System.Linq;
using Entity.Layer;
using Data.Layer.Data;
using System;

namespace Service.Layer.Service
{
    public class ReciboService : IReciboService
    {
        private ReciboData _data;

        public ReciboService(string connectionString)
        {
            _data = new ReciboData(connectionString);
        }

        public void Delete(long id)
        {
            if (id == 0L)
                return;

            _data.Delete(_data.Get(id));
        }

        public Recibo Get(long id)
        {
            return _data.Get(id);
        }

        public List<Recibo> GetAll()
        {
            return _data.GetAll().ToList();
        }

        public void Save(Recibo entity)
        {
            if (entity.Id == 0L)
            {
                entity.Estado = true;
                entity.FechaReg = DateTime.Now;
                _data.Add(entity);
            }
            else
            {
                var entityBase = this._data.Get(entity.Id);
                entityBase.Comentario = entity.Comentario;
                entityBase.Monto = entity.Monto;
                entityBase.Fecha = entity.Fecha;
                entityBase.ProveedorId = entity.ProveedorId;
                entityBase.MonedaId = entity.MonedaId;
                entityBase.FechaMod = DateTime.Now;
                entityBase.UserMod = entity.UserMod;
                _data.Update(entity);
            }
        }
    }
}
