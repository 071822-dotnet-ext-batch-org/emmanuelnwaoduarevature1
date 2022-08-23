using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Decision
    {
        public Decision(Guid managerDecisionID, string travel_Lodge_Decision, string food_Decision, string other_Decision,  Guid reimbursement_DecisionID)
        {
            ManagerDecisionID = managerDecisionID;
            Travel_Lodge_Decision = travel_Lodge_Decision;
            Food_Decision = food_Decision;
            Other_Decision = other_Decision;
            Reimbursement_DecisionID = reimbursement_DecisionID;
        }


        public Decision(Guid managerDecisionID, string travel_Lodge_Decision, string food_Decision, string other_Decision) { }

        public Decision() { }

        

        public Guid ManagerDecisionID { get; set; } = Guid.NewGuid();

      

        public string Travel_Lodge_Decision { get; set; }

        public string Food_Decision { get; set; }

        public string Other_Decision { get; set; }

        public string DateRegistered { get; set; }

        public Guid Reimbursement_DecisionID { get; set; } = Guid.NewGuid();


        

    }
}
