using System;

namespace Project1
{
    public class Manager
    {    

        
        public string ManagerDecison(){

          string [] requeststatus= { "Approved" , "Deny" , " Pending" };

          Console.WriteLine ("Manager, enter the decision on employee's request: Approved, Deny or Pending");

          string ReqStatus = Console.ReadLine(); 

         
           if(ReqStatus.Equals(requeststatus[0])){

               return requeststatus[0];

            }

            else if(ReqStatus.Equals(requeststatus[1])){

                return requeststatus[1];
            }
            else{

             return requeststatus[2];


            }

                
        }

       
    }
}
