using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidentBackEnd.Data;
using ResidentBackEnd.Models;

namespace ResidentBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        public DataContextClass Announcement { get; set; }
        public AnnouncementController(DataContextClass Announcementcontext)
        {
            this.Announcement = Announcementcontext;
        }
        [HttpPost("insertAnnouncement")]
        public async Task<ActionResult> insertAnnouncement(Announcement f)
        {
            Announcement.tblNotice.Add(f);
            await Announcement.SaveChangesAsync();
            return Ok(f);
        }
        [HttpGet("ViewAnnouncement")]
        public async Task<List<Announcement>> ViewAnnouncement()
        {
            return Announcement.tblNotice.ToList();
        }
    }
}
