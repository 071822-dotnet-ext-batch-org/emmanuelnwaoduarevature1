using System.Data.SqlClient;
using System;
using Models;
using System.Data;
using System.Security.Cryptography;

namespace RepoLayer
{
    public class Adonetaccess
    {


        private static readonly SqlConnection conn = new SqlConnection("Server=tcp:emma1.database.windows.net,1433;Initial Catalog=Project1;Persist Security Info=False;User ID=nwaodec79;Password= Magnum_2279;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        Employee employee = new Employee();

        


            //This logs in new employee
            public async Task<List<Employee>> LoginExisitngUserAsync(string username, string password)
        {
            
            using (SqlCommand command = new SqlCommand($"SELECT * FROM [dbo].[Employee] WHERE UserName = @username AND Password = @password", conn))
            {
                command.Parameters.AddWithValue("@username", username);// add dynamic data like this to protect against SQL Injection.
                command.Parameters.AddWithValue("@password", password);
                conn.Open();
                SqlDataReader? ret = await command.ExecuteReaderAsync();
                List<Employee> LoginList = new List<Employee>();

                while (ret.Read())
                {
                    Employee newemploy = new Employee((Guid)ret[0], ret.GetString(1), ret.GetString(2), ret.GetString(3), ret.GetString(4), ret.GetString(5), ret.GetString(6), ret.GetString(7));

                    LoginList.Add(newemploy);

                }
                string UserName ="";
                string Password = "";

                if (username != UserName  && password != Password)
                {
                    Console.WriteLine("you entered a wrong user name or password");
                }
                else
                   Console.WriteLine("You have logged in");
                    return LoginList;
            }

        }//EoM



        //This method register a new employee  

        public async Task <int> RegisternewEmployeesAsync(Guid employeeID, string firstName, string lastName, string username, string password,  string manager_FirstName, string manager_lastName)
        {

            using (SqlCommand command = new SqlCommand($"INSERT INTO [dbo].[Employee] (EmployeeID, FirstName, LastName, UserName, Password, EmployeeRole, Manager_FirstName, Manager_LastName)  VALUES (@employeeID, @firstName, @lastName, @userName, @password, 'Sales Representative',  @manager_FirstName, @manager_lastName)", conn))
            {
                command.Parameters.AddWithValue("@employeeId", employeeID);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@userName", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@manager_FirstName", manager_FirstName);
                command.Parameters.AddWithValue("@manager_LastName", manager_lastName);

                conn.Open();
               int ret = await command.ExecuteNonQueryAsync();


                if (ret == 1)
                {
                    conn.Close();

                    Console.WriteLine("You have succesfully registered");
                    return ret;

                }
                else
                {
                    conn.Close();

                    Console.WriteLine("You are an existing user, please log in");
                    return ret;
                }
            }

        
            
        }//EoM



        //Employees can view previous and current reimbursement status
        public async Task<Decision> FilterForAllDecisionsAsync(Guid employeeID, string travel_Lodge_Decision, string food_Decision, string other_Decision)
        {
            SqlConnection conn = new SqlConnection("Server=tcp:emma1.database.windows.net,1433;Initial Catalog=Project1;Persist Security Info=False;User ID=nwaodec79;Password= Magnum_2279;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"Select * from [dbo].[ManagerDecision] LEFT join [dbo].[Reimbursement] on ManagerDecision.Reimbursement_DecisionID = Reimbursement.ReimbursementID LEFT join [dbo].[Employee] on Reimbursement.EmployeeReimbursementID = Employee.EmployeeID  WHERE EmployeeID = @employeeID AND Travel_Lodge_Decision = @travel_Lodge_Decision or Food_Decision = @food_Decision or Other_Decision = @other_Decision", conn))
            {
                command.Parameters.AddWithValue("@employeeID", employeeID);
                command.Parameters.AddWithValue("@travel_Lodge_Decision", travel_Lodge_Decision);// add dynamic data like this to protect against SQL Injection.
                command.Parameters.AddWithValue("@food_Decision", food_Decision);
                command.Parameters.AddWithValue("@other_Decision", other_Decision);

                conn.Open();
                SqlDataReader? ret = await command.ExecuteReaderAsync();

                if (ret.Read())
                {

                    Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}", (Guid)ret[0], ret.GetString(1), ret.GetString(2), ret.GetString(3));
                    Decision ft = new Decision((Guid)ret[0], ret.GetString(1), ret.GetString(2), ret.GetString(3));

                    conn.Close();
                    return ft;
                }


                conn.Close();
                return null;
            }

        }

        //This method allow managers to UPDATE decisions on employee reimbursement

        public async Task ManagerInsertNewDecisionAsync(Guid managerDecisionID, string travel_Lodge_Decision, string food_Decision, string other_Decision, Guid reimbursement_DecisionID)
        {

            using (SqlCommand command = new SqlCommand($"UPDATE [dbo].[ManagerDecision]\r\n SET \r\n\t[dbo].[ManagerDecision].ManagerDecisionID = @managerDecisionID, \r\n  [dbo].[ManagerDecision].Travel_Lodge_Decision = @travel_Lodge_Decision,  \r\n  [dbo].[ManagerDecision].Food_Decision = @food_Decision,\r\n    [dbo].[ManagerDecision].Other_Decision = @other_Decision,  [dbo].[ManagerDecision].Reimbursement_DecisionID = @reimbursement_DecisionID\r\n\r\n    WHERE [dbo].[ManagerDecision].Reimbursement_DecisionID = @reimbursement_DecisionID", conn))
            {

                command.Parameters.AddWithValue("@managerDecisionID", managerDecisionID);
                command.Parameters.AddWithValue("@travel_Lodge_Decision", travel_Lodge_Decision);// add dynamic data like this to protect against SQL Injection.
                command.Parameters.AddWithValue("@food_Decision", food_Decision);
                command.Parameters.AddWithValue("@other_Decision", other_Decision);
                command.Parameters.AddWithValue("@reimbursement_DecisionID", reimbursement_DecisionID);
                conn.Open();
                int ret = await command.ExecuteNonQueryAsync();

                if (ret == 1)
                {
                    conn.Close();
                    Console.WriteLine(ret);
                }
                else
                {
                    conn.Close();
                    Console.WriteLine(ret);
                }
            }



        }//EoM


        //This method allow managers to insert decisions on employee reimbursement

        public async Task InsertNewManagerDecisionAsync(Guid managerDecisionID, string travel_Lodge_Decision, string food_Decision, string other_Decision, Guid reimbursement_DecisionID)
        {

            using (SqlCommand command = new SqlCommand($"INSERT INTO [dbo].[ManagerDecision] (ManagerDecisionID, Travel_Lodge_Decision, Food_Decision, Other_Decision, Reimbursement_DecisionID ) VALUES (@managerDecisionID, @travel_Lodge_Decision, @food_Decision, @other_Decision, @reimbursement_DecisionID)", conn))
            {

                command.Parameters.AddWithValue("@managerDecisionID", managerDecisionID);
                command.Parameters.AddWithValue("@travel_Lodge_Decision", travel_Lodge_Decision);// add dynamic data like this to protect against SQL Injection.
                command.Parameters.AddWithValue("@food_Decision", food_Decision);
                command.Parameters.AddWithValue("@other_Decision", other_Decision);
                command.Parameters.AddWithValue("@reimbursement_DecisionID", reimbursement_DecisionID);
                conn.Open();
                int ret = await command.ExecuteNonQueryAsync();

                if (ret == 1)
                {
                    conn.Close();
                    Console.WriteLine(ret);
                }
                else
                {
                    conn.Close();
                    Console.WriteLine(ret);
                }
            }



        }//EoM



        //This method allow employees to submit new reimbursement tickets.
        public async Task<int> SubmitNewTicketAsync(Guid reimbursementID, double travel_Lodge_Cost, string travel_Lodge_Description, double food_Cost, string food_Description, double other_Cost, string other_Description, Guid employeeReimbursementID)
        {

            using (SqlCommand command = new SqlCommand($"INSERT INTO [dbo].[Reimbursement] (ReimbursementID, Travel_Lodge_Cost, Travel_Lodge_Description, Food_Cost, Food_Description, Other_Cost, Other_Description, EmployeeReimbursementID)  VALUES (@reimbursementID, @travel_Lodge_Cost, @travel_Lodge_Description, @food_Cost, @food_Description, @other_Cost, @other_Description, @employeeReimbursementID)", conn))
            {
                command.Parameters.AddWithValue("@reimbursementID", reimbursementID);
                command.Parameters.AddWithValue("@travel_Lodge_Cost", travel_Lodge_Cost);
                command.Parameters.AddWithValue("@travel_Lodge_Description", travel_Lodge_Description);
                command.Parameters.AddWithValue("@food_Cost", food_Cost);
                command.Parameters.AddWithValue("@food_Description", food_Description);
                command.Parameters.AddWithValue("@other_Cost", other_Cost);
                command.Parameters.AddWithValue("@other_Description", other_Description); 
                command.Parameters.AddWithValue("@employeeReimbursementID", employeeReimbursementID);
                conn.Open();
                int ret = await command.ExecuteNonQueryAsync();


                if (ret == 1)
                {
                    conn.Close();

                    Console.WriteLine("You have succesfully submited your reimbursement ticket");
                    return ret;

                }
                else
                {
                    conn.Close();

                    Console.WriteLine("Your submission was not successful");
                    return ret;
                }
            }



        }//EoM



    }//EoC


}//EoN
