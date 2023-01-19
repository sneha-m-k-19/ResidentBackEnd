using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidentBackEnd.Data;
using ResidentBackEnd.Models;

namespace ResidentBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PanelController : ControllerBase
    {
        public DataContextClass adminPanel { get; set; }
        public PanelController(DataContextClass adminPanelcontext)
        {
            this.adminPanel = adminPanelcontext;
        }
        [HttpPost("insertPanel")]
        public async Task<ActionResult> insertPanel(adminPanel ap)
        {
            adminPanel.tblPanel.Add(ap);
            await adminPanel.SaveChangesAsync();
            return Ok(ap);
        }
        [HttpGet("ViewPanel")]
        public async Task<List<adminPanel>> ViewPanel()
        {
            return adminPanel.tblPanel.ToList();
        }
        
    }
}
