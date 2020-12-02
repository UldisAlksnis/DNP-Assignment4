using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DNP_Assignment3.Models;
using DNP_Assignment3.Data;

namespace DNP_Assignment3.Controllers
{
    [Route("api/Adults")]
    [ApiController]
    public class AdultsController : ControllerBase
    {
        private readonly IAdultService _adultService;

        public AdultsController(IAdultService adultService)
        {
            _adultService = adultService;
        }

        // GET: api/Adults/5
        [HttpGet]
        public async Task<ActionResult<IList<Adult>>>
            GetAdults([FromQuery] int? id, [FromQuery] String firstname, [FromQuery] String lastname)
        {
            IList<Adult> adults;
            try
            {
                IList<Adult> filteredAdults = await _adultService.GetAdultsAsync();
                if (id != null)
                {

                    adults = filteredAdults.Where(a => a.Id == id).ToList();
                }
                else if (firstname != null)
                {

                    adults = filteredAdults.Where(a => a.FirstName.Equals(firstname, StringComparison.OrdinalIgnoreCase)).ToList();
                }
                else if (lastname != null)
                {

                    adults = filteredAdults.Where(a => a.LastName.Equals(lastname, StringComparison.OrdinalIgnoreCase)).ToList();
                }
                else
                {
                    adults = await _adultService.GetAdultsAsync();
                }
                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);

            }
        }

        // PUT: api/Adults/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        /*[HttpPost("{id}")]
        public async Task<IActionResult> PostAdult(int id, Adult adult)
        {
            Adult adultToModify = await _adultService.ModifyAdult(int id, Adult adult);
            return Ok();
        }

        // POST: api/Adults
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut]
        public async Task<ActionResult<Adult>> PutAdult(Adult adult)
        {
            _adultService.Adults.Add(adult);
            await _adultService.SaveChangesAsync();

            //return CreatedAtAction("GetAdult", new { id = adult.Id }, adult);
            return CreatedAtAction(nameof(GetAdult), new { id = adult.Id }, adult);
        }

        // DELETE: api/Adults/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Adult>> DeleteAdult(int id)
        {
            var adult = await _adultService.Adults.FindAsync(id);
            if (adult == null)
            {
                return NotFound();
            }

            _adultService.Adults.Remove(adult);
            await _adultService.SaveChangesAsync();

            return adult;
        }

        private bool AdultExists(int id)
        {
            return _adultService.Adults.Any(e => e.Id == id);
        }*/
    }
}
