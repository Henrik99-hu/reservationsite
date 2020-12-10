using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationSite.Models;
using ReservationSite.Models.Data_Transfer_Objects;
using ReservationSite.Services;

namespace ReservationSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccomodationController : ControllerBase
    {
        private readonly AccomodationService _accomodationService;

        public AccomodationController(AccomodationService accomodationService)
        {
            _accomodationService = accomodationService;
        }

        // GET: api/<AccomodationController>
        [HttpGet]
        public IEnumerable<Accomodation> Get()
        {
            return _accomodationService.ListAccomodations();
        }

        // GET api/<AccomodationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AccomodationController>
        [HttpPost]
        public /*async Task<int>*/ void Post([FromBody] AccomodationDto accomodationDto)
        {
            /*await*/ _accomodationService.AddAccomodation(accomodationDto);
            //return StatusCodes.Status200OK;

        }

        // PUT api/<AccomodationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccomodationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
