using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using RepoLayer;

namespace BusinessLayer
{
    public class Register {

        private readonly Adonetaccess _repoLayer;
        public Register()
        {

            this._repoLayer = new Adonetaccess();
        }

        public async Task RegisternewEmployeesAsync(Guid employeeID, string firstName, string lastName, string username, string password, string manager_FirstName, string manager_lastName)
        {

            await _repoLayer.RegisternewEmployeesAsync(employeeID, firstName, lastName, username, password, manager_FirstName, manager_lastName);



        }



    }//EOC

}//EoN
