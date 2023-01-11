using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidentBackEnd.Data;
using ResidentBackEnd.Models;

namespace ResidentBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        public DataContextClass EventRegcs { get; set; }
        public EventController(DataContextClass eventcontext)
        {
            this.EventRegcs = eventcontext;
        }
        [HttpPost("insertEvent")]
        public async Task<ActionResult> InsertEvents(EventRegcs c)
        {
            EventRegcs.tblEventReg.Add(c);
            await EventRegcs.SaveChangesAsync();
            return Ok(c);
        }
        [HttpGet("ViewEvent")]
        public async Task<List<EventRegcs>> ViewEvent()
        {
            return EventRegcs.tblEventReg.ToList();
        }
        [HttpGet("ApproveEvent/{id}")]
        public IActionResult ApproveEvent(int id)
        {
            return Ok(EventRegcs.tblEventReg.Find(id));
        }
        [HttpPost("UpdateEvent")]
        public async Task<ActionResult> UpdateEvent(EventRegcs c)
        {
            EventRegcs.tblEventReg.Update(c);
            await EventRegcs.SaveChangesAsync();
            return Ok(c);
        }
    }
}
