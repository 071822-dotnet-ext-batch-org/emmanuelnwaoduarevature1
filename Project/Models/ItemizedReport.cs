using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ItemizedReport

    {
        public ItemizedReport(Guid reimbursementID, double travel_Lodge_Cost, string travel_Lodge_Description, double food_Cost, string food_Description, double other_Cost, string other_Description, Guid employeeReimbursementID)
        {
            ReimbursementID = reimbursementID; 
            Travel_Lodge_Cost = travel_Lodge_Cost;
            Travel_Lodge_Description = travel_Lodge_Description;
            Food_Cost = food_Cost;
            Food_Description = food_Description;
            Other_Cost = other_Cost;
            Other_Description = other_Description;
            EmployeeReimbursementID = employeeReimbursementID;

        }

        public Guid ReimbursementID { get; set; } = Guid.NewGuid();
        public double Travel_Lodge_Cost { get; set; }
        public string Travel_Lodge_Description { get; set; }
        public double Food_Cost { get; set; }
        public string Food_Description { get; set; }
        public double Other_Cost { get; set; }
        public string Other_Description { get; set; }
        public Guid EmployeeReimbursementID { get; set; } = Guid.NewGuid();


    }
}
