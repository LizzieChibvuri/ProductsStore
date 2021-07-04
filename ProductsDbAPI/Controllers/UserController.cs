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
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWorkService _service;
        public UserController(IUnitOfWorkService service)
        {
            _service = service;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _service.Users.GetAll().ToList();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _service.Users.GetById(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] User User)
        {
            _service.Users.Add(User);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void PostBatch([FromBody] List<User> Users)
        {
            _service.Users.AddRange(Users);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User User)
        {

        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var c = _service.Users.GetById(id);

            if (c != null)
            {
                _service.Users.Remove(c);
            }

        }
    }
}
