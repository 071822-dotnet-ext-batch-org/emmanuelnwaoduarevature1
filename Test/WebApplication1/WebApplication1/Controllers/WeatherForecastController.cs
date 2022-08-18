using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       
        private readonly Login _loginCheck;


        public WeatherForecastController()
        {
            this._loginCheck = new Login();
        }


        //Login existing employee
        [HttpGet("LoginExisitngUserAsyn")]
        [HttpGet("LoginExisitngUserAsyn/{UserName}/{Password}")]


        public async Task<ActionResult<List<Employee>>> LoginExisitngUserAsync(string username, string password)
        {
            List<Employee> LoginList = await this._loginCheck.LoginExisitngUserAsync(username, password);

            return Ok(LoginList);
        }





 
    }
}