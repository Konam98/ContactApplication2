using ContactApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        IRepository<Login> repo = new LoginRepo();
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<Login> Get()
        {
            return repo.Get();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public Login Get(int id)
        {
            return repo.Show(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] Login value)
        {
            repo.Add(value);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Login value)
        {
            repo.UpDate(id, value);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Delete(id);
        }
    }
}