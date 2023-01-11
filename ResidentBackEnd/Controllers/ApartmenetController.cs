using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidentBackEnd.Data;
using ResidentBackEnd.Models;

namespace ResidentBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmenetController : ControllerBase
    {

        public DataContextClass Apartment { get; set; }
        public ApartmenetController(DataContextClass apartmentcontext)
        {
            this.Apartment = apartmentcontext;
        }
        [HttpPost("insertApartment")]
        public async Task<ActionResult> InsertApartment(Apartment ap)
        {
            Apartment.tblApartments.Add(ap);
            await Apartment.SaveChangesAsync();
            return Ok(ap);
        }
        [HttpGet("GetUser")]
        public async Task<ActionResult> GetUser(string Username)
        {
            var apartment = Apartment.tblApartments.Where(c => c.UserName.Equals(Username)).First();
            return Ok(apartment);
        }
        [HttpGet("ViewApartment")]
        public async Task<List<Apartment>> ViewApartment()
        {
            return Apartment.tblApartments.ToList();
        }
        
    }
}
