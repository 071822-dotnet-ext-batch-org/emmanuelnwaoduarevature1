using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1
{
    public class Employee
    {
        protected string Fname;
        protected string Lname;
        protected string username;
        protected string password;
        protected string email;
        protected string phone;
        protected string address;


        public Employee(string Fname, string Lname, string username, string password, string email, string phone, string address){
          
          this.Fname = Fname;
          this.Lname = Lname;
          this.username = username;
          this.password = password;
          this.email = email;
          this.phone = phone;
          this.address = address;

        }

        

        

    }
}
