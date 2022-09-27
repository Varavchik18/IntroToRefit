using Microsoft.AspNetCore.Mvc;
using SimpleAPI.Controllers.Models;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private static List<GuestModel> guests = new()
        {
            new GuestModel{ Id = 1, FirstName = "Pavlo", LastName = "Varava"},
            new GuestModel{ Id = 2, FirstName = "Finik", LastName = "Nadushevich"},
            new GuestModel{ Id = 3, FirstName = "Tim", LastName = "Corey"},
        };
        // GET: api/<GuestsController>
        [HttpGet]
        public IEnumerable<GuestModel> Get()
        {
            return guests;
        }

        // GET api/<GuestsController>/5
        [HttpGet("{id}")]
        public GuestModel Get(int id)
        {
            return guests.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/<GuestsController>
        [HttpPost]
        public void Post([FromBody] GuestModel model)
        {
            guests.Add(model);
        }

        // PUT api/<GuestsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GuestModel model)
        {
            guests.Remove(guests.Where(x => x.Id == id).FirstOrDefault());
            guests.Add(model);
        }

        // DELETE api/<GuestsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            guests.Remove(guests.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}
