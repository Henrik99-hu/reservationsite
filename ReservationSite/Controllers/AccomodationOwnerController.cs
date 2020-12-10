using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationSite.Models;
using ReservationSite.Models.Data_Transfer_Objects;
using ReservationSite.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReservationSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccomodationOwnerController : ControllerBase
    {
        private readonly AccomodationOwnerService _accomodationOwnerService;

        public AccomodationOwnerController(AccomodationOwnerService accomodationOwnerService)
        {
            _accomodationOwnerService = accomodationOwnerService;
        }


        // GET: api/<AccomodationOwnerController>
        [HttpGet]
        public IEnumerable<AccomodationOwner> Get()
        {
            return _accomodationOwnerService.ListAccomodationOwners();
        }

        // GET api/<AccomodationOwnerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AccomodationOwnerController>
        [HttpPost]
        public async Task<int> Post([FromBody] AccomodationOwnerDto accomodationOwnerDto)
        {
            await _accomodationOwnerService.AddAccomodationOwner(accomodationOwnerDto);
            return StatusCodes.Status200OK;
        }

        // PUT api/<AccomodationOwnerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccomodationOwnerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
