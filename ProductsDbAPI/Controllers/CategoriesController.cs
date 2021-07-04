using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Product.Contracts;
using Product.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private readonly IUnitOfWorkService _service;
        public CategoriesController(IUnitOfWorkService service)
        {
            _service = service;
        }

        // GET: api/<CategoriesController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _service.Categories.GetAll().ToList();
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _service.Categories.GetById(id);
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public void Post([FromBody] Category category)
        {
            _service.Categories.Add(category);
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public void PostBatch([FromBody] List<Category> categories)
        {
            _service.Categories.AddRange(categories);
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category Category)
        {

        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var c = _service.Categories.GetById(id);

            if (c != null)
            {
                _service.Categories.Remove(c);
            }

        }
    }
}
