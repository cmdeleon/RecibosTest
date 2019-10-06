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
    public class ReciboController : ApiController
    {
        private readonly IReciboService _service;

        public ReciboController(IReciboService service)
        {
            _service = service;
        }

        // GET: api/Recibo
        public IEnumerable<Recibo> Get()
        {
            return Recibo.ToList(_service.GetAll());
        }

        // GET: api/Recibo/5
        public Recibo Get(int id)
        {
            return Recibo.ToModel(_service.Get(id));
        }

        // POST: api/Recibo
        public bool Post([FromBody]Recibo value)
        {
            _service.Save(Recibo.ToOriginal(value));

            return true;
        }

        // PUT: api/Recibo/5
        public void Put(int id, [FromBody]Recibo value)
        {
            _service.Save(Recibo.ToOriginal(value));
        }

        // DELETE: api/Recibo/5
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
