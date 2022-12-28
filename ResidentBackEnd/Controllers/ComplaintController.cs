using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidentBackEnd.Data;
using ResidentBackEnd.Models;

namespace ResidentBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintController : ControllerBase
    {
        public DataContextClass Complaint { get; set; }
        public ComplaintController(DataContextClass complaintcontext)
        {
            this.Complaint = complaintcontext;
        }
        [HttpPost("insertComplaint")]
        public async Task<ActionResult> InsertComplaint(Complaint c)
        {
            Complaint.tblcomplaints.Add(c);
            await Complaint.SaveChangesAsync();
            return Ok(c);
        }
    }
}
