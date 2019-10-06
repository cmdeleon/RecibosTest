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
    public class MonedaController : ApiController
    {
        private readonly IMonedaService _service;

        public MonedaController(IMonedaService service)
        {
            _service = service;
        }

        // GET: api/Moneda
        public IEnumerable<Moneda> Get()
        {
            return Moneda.ToList(_service.GetAll());
        }

        // GET: api/Moneda/5
        public Moneda Get(int id)
        {
            return Moneda.ToModel(_service.Get(id));
        }

        // POST: api/Moneda
        public void Post([FromBody]Moneda value)
        {
            _service.Save(Moneda.ToOriginal(value));
        }

        // PUT: api/Moneda/5
        public void Put(int id, [FromBody]Moneda value)
        {
            _service.Save(Moneda.ToOriginal(value));
        }

        // DELETE: api/Moneda/5
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
