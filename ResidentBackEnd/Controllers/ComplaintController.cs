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
        public async Task<ActionResult> InsertComplaint(ComplaintView c)
        {
            Complaint.tblcomplaint.Add(c);
            await Complaint.SaveChangesAsync();
            return Ok(c);
        }

        [HttpGet("ViewComplaint")]
        public async Task<List<ComplaintView>>ViewComplaint()
        {
            return Complaint.tblcomplaint.ToList();
        }
        [HttpGet("ApproveComplaint/{id}")]
        public IActionResult ApproveComplaint(int id)
        {
            return Ok(Complaint.tblcomplaint.Find(id));
        }
        [HttpPost("UpdateComplaint")]
        public async Task<ActionResult> UpdateComplaint(ComplaintView c)
        {
            Complaint.tblcomplaint.Update(c);
            await Complaint.SaveChangesAsync();
            return Ok(c);
        }
        /*[HttpGet("ViewComplaint/{[UserName]}")]
        public IActionResult ViewComplaint(string username)
        {
            return Ok(Complaint.tblcomplaint.Find(username));
        }*/
    }
}
