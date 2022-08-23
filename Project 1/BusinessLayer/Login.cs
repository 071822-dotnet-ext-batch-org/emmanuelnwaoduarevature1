using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using RepoLayer;


namespace BusinessLayer
{
    public class Login 
    {
        private readonly Adonetaccess _repoLayer;
        public Login()
        {

            this._repoLayer = new Adonetaccess();
        }

        public async Task<List<Employee>> LoginExisitngUserAsync(string username, string password)
        {

            List<Employee> LoginList = await this._repoLayer.LoginExisitngUserAsync(username, password);

            return LoginList;
        }



    }//EoC
   //

}//EOC
