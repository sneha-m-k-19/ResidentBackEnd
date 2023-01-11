using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidentBackEnd.Data;
using ResidentBackEnd.Models;

namespace ResidentBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public DataContextClass User { get; set; }
        public UserController(DataContextClass usercontext)
        {
            this.User = usercontext;
        }
        
    }
}
