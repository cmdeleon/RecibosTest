using Service.Layer.Interface;
using System.Collections.Generic;
using System.Linq;
using Entity.Layer;
using Data.Layer.Data;
using System;

namespace Service.Layer.Service
{
    public class ProveedorService : IProveedorService
    {
        private ProveedorData _data;

        public ProveedorService(string connectionString)
        {
            _data = new ProveedorData(connectionString);
        }

        public void Delete(long id)
        {
            if (id == 0L)
                return;

            _data.Delete(_data.Get(id));
        }

        public Proveedor Get(long id)
        {
            return _data.Get(id);
        }

        public List<Proveedor> GetAll()
        {
            return _data.GetAll().ToList();
        }

        public void Save(Proveedor entity)
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
                entityBase.Nombre = entity.Nombre;
                entityBase.FechaMod = DateTime.Now;
                entityBase.UserMod = entity.UserMod;
                _data.Update(entity);
            }
        }
    }
}
