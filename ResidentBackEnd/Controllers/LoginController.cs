using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidentBackEnd.Data;
using ResidentBackEnd.Models;

namespace ResidentBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public DataContextClass UserLogin{get;set;}
        public LoginController(DataContextClass logincontext)
        {
            this.UserLogin = logincontext;
        }
        [HttpPost("LoginUser")]
        public IActionResult Login(Login user)
        {
            var userAvailable = UserLogin.tblApartments.Where(u => u.UserName == user.Username && u.Password == user.Password).FirstOrDefault();
            System.Console.WriteLine(userAvailable);
            if (userAvailable == null)
            {
                return Ok("Failure");
            }
           // HttpContext.Session.SetString("ApartmentNumber", userAvailable.ApartmentNumber);
           // HttpContext.Session.SetString("UserName", userAvailable.UserName);
            return Ok("Success");
        }
    }
}
