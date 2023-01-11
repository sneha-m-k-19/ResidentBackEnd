using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidentBackEnd.Data;
using ResidentBackEnd.Models;

namespace ResidentBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        public DataContextClass Payment { get; set; }
        public PaymentController(DataContextClass Paymentcontext)
        {
            this.Payment = Paymentcontext;
        }
        [HttpPost("insertPayment")]
        public async Task<ActionResult> insertPayment(Payment f)
        {
            Payment.tblIncome.Add(f);
            await Payment.SaveChangesAsync();
            return Ok(f);
        }
        [HttpGet("ViewAccounts")]
        public async Task<List<Payment>> ViewAccounts()
        {
            return Payment.tblIncome.ToList();
        }
    }
}
