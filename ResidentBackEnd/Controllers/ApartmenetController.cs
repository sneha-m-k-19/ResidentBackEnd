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
    }
}
