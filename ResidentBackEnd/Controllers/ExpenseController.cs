using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidentBackEnd.Data;
using ResidentBackEnd.Models;

namespace ResidentBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        public DataContextClass Expense { get; set; }
        public ExpenseController(DataContextClass Expensecontext)
        {
            this.Expense = Expensecontext;
        }
        [HttpPost("insertExpense")]
        public async Task<ActionResult> insertExpense(Expense exp)
        {
            Expense.tblDeduction.Add(exp);
            await Expense.SaveChangesAsync();
            return Ok(exp);
        }
        [HttpGet("ViewAccounts")]
        public async Task<List<Expense>> ViewAccounts()
        {
            return Expense.tblDeduction.ToList();
        }
    }
}
