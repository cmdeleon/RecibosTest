using Service.Layer.Interface;
using System.Collections.Generic;
using System.Linq;
using Entity.Layer;
using Data.Layer.Data;
using System;

namespace Service.Layer.Service
{
    public class UsuarioService : IUsuarioService
    {
        private UsuarioData _data;

        public UsuarioService(string connectionString)
        {
            _data = new UsuarioData(connectionString);
        }

        public void Delete(long id)
        {
            if (id == 0L)
                return;

            _data.Delete(_data.Get(id));
        }

        public Usuario Get(long id)
        {
            return _data.Get(id);
        }

        public List<Usuario> GetAll()
        {
            return _data.GetAll().ToList();
        }

        public void Save(Usuario entity)
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
                entityBase.Password = entity.Password;
                entityBase.Nombre = entity.Nombre;
                entityBase.RolId = entity.RolId;
                entityBase.FechaMod = DateTime.Now;
                _data.Update(entity);
            }
        }
    }
}
