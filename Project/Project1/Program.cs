using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;


namespace Project1
{
    class Program
    {


        static void Main(string[] args)
        {
           
           //Created Instances of the following classes
           Login log = new Login();

           Reimbursements mandec = new Reimbursements();


           //Call the method to register and/or sign in an employee//  
           
           log.HaveURegistered();


           //Call the method to enter the employees expenses

           mandec.getemployeeexpense();
           

           //Call the method to show the manager's decision and expenses

           mandec.managerdecision();




            
        }   

    }//EoC
}//EoN
