using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Employee 
    {

        public Employee() { }

        public Employee(Guid employeeID, string firstName, string lastName, string username, string password, string employeeRole) { }

            public Employee(Guid employeeID, string firstName, string lastName, string username, string password, string employeeRole, string manager_FirstName, string manager_lastName)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            UserName = username;
            Password = password;
            EmployeeRole = employeeRole;
            Manager_FirstName = manager_FirstName;
            Manager_lastName = manager_lastName;
        }

        public Guid EmployeeID { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string UserName  { get; set; }
        public string Password { get; set; }
        public string EmployeeRole { get; set; } = "Sales Representative";
        public string Manager_FirstName { get; set; }
        public string Manager_lastName { get; set; }




           




       
    }//EoC


}//EoN
