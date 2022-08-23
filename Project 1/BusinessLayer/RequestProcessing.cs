using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using BusinessLayer;
using RepoLayer;


namespace BusinessLayer
{
    public class RequestProcessing
    {
        
        private readonly Adonetaccess _repoLayer;
        public RequestProcessing()
        {

            this._repoLayer = new Adonetaccess();
        }

        public async Task<Decision> FilterForAllDecisionsAsync(Guid employeeID,  string travel_Lodge_Decision, string food_Decision, string other_Decision)
        {

            Decision employeeData = await this._repoLayer.FilterForAllDecisionsAsync(employeeID, travel_Lodge_Decision, food_Decision, other_Decision);

            return employeeData;
        }

        public async Task InsertNewManagerDecisionAsync(Guid managerDecisionID, string travel_Lodge_Decision, string food_Decision, string other_Decision, Guid reimbursement_DecisionID)
        {

            await this._repoLayer.InsertNewManagerDecisionAsync(managerDecisionID, travel_Lodge_Decision, food_Decision, other_Decision, reimbursement_DecisionID);

        }

        public async Task SubmitNewTicketAsync(Guid reimbursementID, double travel_Lodge_Cost, string travel_Lodge_Description, double food_Cost, string food_Description, double other_Cost, string other_Description, Guid employeeReimbursementID) {

            await this._repoLayer.SubmitNewTicketAsync(reimbursementID, travel_Lodge_Cost, travel_Lodge_Description, food_Cost, food_Description, other_Cost, other_Description, employeeReimbursementID);
        }

    }//EoC

}//EoN
