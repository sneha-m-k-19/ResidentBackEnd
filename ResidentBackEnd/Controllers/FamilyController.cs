using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidentBackEnd.Data;
using ResidentBackEnd.Models;

namespace ResidentBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyController : ControllerBase
    {
        public DataContextClass family { get; set; }
        public FamilyController(DataContextClass eventcontext)
        {
            this.family = eventcontext;
        }
        [HttpPost("insertFamily")]
        public async Task<ActionResult> insertFamily(family f)
        {
            family.tblFamily.Add(f);
            await family.SaveChangesAsync();
            return Ok(f);
        }
        [HttpGet("ViewFamily")]
        public async Task<List<family>> ViewFamily()
        {
            return family.tblFamily.ToList();
        }
        
    }
}
