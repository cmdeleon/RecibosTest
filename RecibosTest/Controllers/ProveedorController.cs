using RecibosTest.Models;
using Service.Layer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RecibosTest.Controllers
{
    public class ProveedorController : ApiController
    {
        private readonly IProveedorService _service;

        public ProveedorController(IProveedorService service)
        {
            _service = service;
        }

        // GET: api/Proveedor
        public IEnumerable<Proveedor> Get()
        {
            return Proveedor.ToList(_service.GetAll());
        }

        // GET: api/Proveedor/5
        public Proveedor Get(int id)
        {
            return Proveedor.ToModel(_service.Get(id));
        }

        // POST: api/Proveedor
        public void Post([FromBody]Proveedor value)
        {
            _service.Save(Proveedor.ToOriginal(value));
        }

        // PUT: api/Proveedor/5
        public void Put(int id, [FromBody]Proveedor value)
        {
            _service.Save(Proveedor.ToOriginal(value));
        }

        // DELETE: api/Proveedor/5
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
