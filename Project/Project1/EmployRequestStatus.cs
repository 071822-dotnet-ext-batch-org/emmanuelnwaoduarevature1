using System;

namespace Project1
{
    public class EmployRequestStatus : Manager
    {
        
        double Travel_Lodging;
        double Food;
        double others;
        public double employeerequestsum; 


      
      public double EmployeeRequest(){

         Console.WriteLine ("Enter the cost of travel and lodging");
         Travel_Lodging = Double.Parse(Console.ReadLine()); 
         Console.WriteLine("travel and lodging cost saved");

         Console.WriteLine ("Enter the cost of feeding");
         Food = Double.Parse(Console.ReadLine()); 
         Console.WriteLine("feeding cost saved");

         Console.WriteLine ("Enter the cost of others");
         others = Double.Parse(Console.ReadLine()); 

         if (others != 0){

            Console.WriteLine ("Describe others");
            string describeothers = Console.ReadLine(); 
         }
         else{

            return others;  
         }
         Console.WriteLine("others cost saved");
         
          
         double employeerequestsum = Travel_Lodging + Food + others;

          return employeerequestsum;

      }

      public void Employeeexpensetype(){

        

      }

        public void EmployeeRequeststatus(){

          string requeststatus = base.ManagerDecison();

        }



    }
}
