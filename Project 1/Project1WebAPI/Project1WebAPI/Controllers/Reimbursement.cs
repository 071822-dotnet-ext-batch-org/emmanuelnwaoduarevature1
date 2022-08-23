using BusinessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using RepoLayer;
using System.Runtime.CompilerServices;

namespace Project1WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Reimbursement : ControllerBase
    {
        
        private readonly Login _loginCheck;
        private readonly RequestProcessing _DecisionFilter;
        private readonly Register _Register;
        Decision employeeData = new Decision();

        public Reimbursement()
        {
            this._loginCheck = new Login();

            this._DecisionFilter = new RequestProcessing();

            this._Register = new Register();

        }

        //This registers a new employee 
        [HttpPost("RegisternewEmployeesAsync")]

        public async Task RegisternewEmployeesAsync(Guid employeeID, string firstName, string lastName, string username, string password, string manager_FirstName, string manager_lastName)
        {
            

          await this._Register.RegisternewEmployeesAsync(employeeID, firstName, lastName, username, password, manager_FirstName, manager_lastName);

        }


        //Login existing employee
        [HttpGet("LoginExisitngUserAsyn")]
        
        public async Task<ActionResult<List<Employee>>> LoginExisitngUserAsync(string username, string password)
        {
            List<Employee> LoginList = await this._loginCheck.LoginExisitngUserAsync(username, password);

            return Ok(LoginList);
        }


        //Submit new reimbursement tickets 
        [HttpPost("SubmitNewTicketAsync")]
        public async Task SubmitNewTicketAsync(Guid reimbursementID, double travel_Lodge_Cost, string travel_Lodge_Description, double food_Cost, string food_Description, double other_Cost, string other_Description, Guid employeeReimbursementID)
        {

            await this._DecisionFilter.SubmitNewTicketAsync(reimbursementID, travel_Lodge_Cost, travel_Lodge_Description, food_Cost, food_Description, other_Cost, other_Description, employeeReimbursementID);
        }



        //Filter for employee to view previous reimbursement status 
        [HttpGet("FilterForAllDecisionsAsync")]
        
        public async Task<ActionResult<List<Decision>>> FilterForAllDecisionsAsync(Guid employeeID, string travel_Lodge_Decision, string food_Decision, string other_Decision)
        {

            if (ModelState.IsValid)
            {
                Decision employeeData = await this._DecisionFilter.FilterForAllDecisionsAsync(employeeID, travel_Lodge_Decision, food_Decision, other_Decision);

                return Ok(employeeData);

            }
            else return StatusCode(StatusCodes.Status409Conflict);

        }



        [HttpPost("InsertNewManagerDecisionAsync")]
        public async Task InsertNewManagerDecisionAsync(Guid managerDecisionID, string travel_Lodge_Decision, string food_Decision, string other_Decision, Guid reimbursement_DecisionID)
        {

            await this._DecisionFilter.InsertNewManagerDecisionAsync(managerDecisionID, travel_Lodge_Decision, food_Decision, other_Decision, reimbursement_DecisionID);

        }




        

    }
}
