using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactApplication.Models;


namespace ContactApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegistrationController : ControllerBase
    {
        IRepository<Register> repo = new RegisterRepo();
        // GET: api/<PassengerController>
        [HttpGet]
        public IEnumerable<Register> Get()
        {
            return repo.Get();
        }

        // GET api/<PassengerController>/5
        [HttpGet("{id}")]
        public Register Get(int id)
        {
            return repo.Show(id);
        }

        // POST api/<PassengerController>
        [HttpPost]
        public void Post([FromBody] Register value)
        {
            repo.Add(value);
        }

        // PUT api/<PassengerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Register value)
        {
            repo.UpDate(id, value);
        }

        // DELETE api/<PassengerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Delete(id);
        }
    }
}