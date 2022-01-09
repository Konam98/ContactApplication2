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
    public class ContactController : ControllerBase
    {
        IRepository<Contact> repo = new ContactRepo();
        // GET: api/<ReservationController>
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return repo.Get();
        }

        // GET api/<ReservationController>/5
        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            return repo.Show(id);
        }

        // POST api/<ReservationController>
        [HttpPost]
        public void Post([FromBody] Contact value)
        {
            repo.Add(value);
        }

        // PUT api/<ReservationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Contact value)
        {
            repo.UpDate(id, value);
        }

        // DELETE api/<ReservationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Delete(id);
        }
    }
} 