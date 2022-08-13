using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Project1
{
    class Program
    {


        static void Main(string[] args)
        {
           
           //Created Instances of the following classes
           Login log = new Login();

           Register register = new Register();

           EmployeeRequest emploReq = new EmployeeRequest();

           Manager mandec = new Manager();


           //Call the method to register and/or sign in an employee
           
           log.HaveURegistered();

           //Call the method to check for existing employee

           log.Checkexistingemployee();


           //Call the method to promt the employee to submit a reimbursement now or log out

           log.submitReimbursementFormNow();


           //Call the method to enter the employees expenses

           emploReq.getemployeeexpense();
           

           //Call the method to show the manager's decision and expenses

           mandec.managerdecision();




            
        }   

    }//EoC
}//EoN
