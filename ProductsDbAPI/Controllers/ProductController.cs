using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Contracts;
using Product.Data;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWorkService _service;
        public ProductController(IUnitOfWorkService service)
        {
            _service = service;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Productt> Get()
        {
            return _service.Products.GetAll().ToList();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Productt Get(int id)
        {
            return _service.Products.GetById(id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] Productt product)
        {
            _service.Products.Add(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void PostBatch([FromBody] List<Productt> products)
        {
            _service.Products.AddRange(products);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Productt product)
        {

        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var c = _service.Products.GetById(id);

            if (c != null)
            {
                _service.Products.Remove(c);
            }

        }
    }
}
