



using System;

namespace _6_FlowControl
{
    public class Program
    {
        public static string username;
        public static string password;

        public static void Main(string[] args)
        {
            

            Console.WriteLine(GetValidTemperature());

            
            
        }

        /// <summary>
        /// This method gets a valid temperature between -40 asnd 135 inclusive from the user
        /// and returns the valid int. 
        /// </summary>
        /// <returns></returns>
        public static object GetValidTemperature()
        {
            //throw new NotImplementedException($"GetValidTemperature() has not been implemented.");
            
           int temp = -10;

           if(temp >=-40 && temp <=135){
            
            return temp;     
           }
           else{

            return null;

           }
           
            
            
        }

        /// <summary>
        /// This method has one int parameter
        /// It prints outdoor activity advice and temperature opinion to the console 
        /// based on 20 degree increments starting at -20 and ending at 135 
        /// n < -20, Console.Write("hella cold");
        /// -20 <= n < 0, Console.Write("pretty cold");
        ///  0 <= n < 20, Console.Write("cold");
        /// 20 <= n < 40, Console.Write("thawed out");
        /// 40 <= n < 60, Console.Write("feels like Autumn");
        /// 60 <= n < 80, Console.Write("perfect outdoor workout temperature");
        /// 80 <= n < 90, Console.Write("niiice");
        /// 90 <= n < 100, Console.Write("hella hot");
        /// 100 <= n < 135, Console.Write("hottest");
        /// </summary>
        /// <param name="temp"></param>
        public static void GiveActivityAdvice(int temp)
        {
            //throw new NotImplementedException($"GiveActivityAdvice() has not been implemented.");
            
          switch(temp){

            case < -20:
            Console.Write("hella cold");

            break;
             
            case < 0:
            Console.Write("pretty cold");

            break;

            case < 20:
            Console.Write("cold");

            break;

            case < 40:
            Console.Write("thawed out");

            break;

            case < 60:
            Console.Write("feels like Autumn");

            break;

            case < 80:
            Console.Write("perfect outdoor workout temperature");

            break;
            case < 90:
            Console.Write("niiice");

            break;

            case < 100:
            Console.Write("hella hot");

            break;
            case < 135:
            Console.Write("hottest");

            break;

          }
            
        }

        /// <summary>
        /// This method gets a username and password from the user
        /// and stores that data in the global variables of the 
        /// names in the method.
        /// </summary>
        public static void Register()
        {
            //throw new NotImplementedException($"Register() has not been implemented.");
            Console.WriteLine("Please enter a username and password");
            string username = Console.ReadLine();
            string password = Console.ReadLine();
        }

        /// <summary>
        /// This method gets username and password from the user and
        /// compares them with the username and password names provided in Register().
        /// If the password and username match, the method returns true. 
        /// If they do not match, the user is reprompted for the username and password
        /// until the exact matches are inputted.
        /// </summary>
        /// <returns></returns>
        public static bool Login()
        {
            //throw new NotImplementedException($"Login() has not been implemented.");
           
            string username1;
            string password1;
            do{

            Console.WriteLine("Please enter username and password");
            username1 = Console.ReadLine();
            password1 = Console.ReadLine();

            }

            while (Equals(username, username1) || Equals(password, password1));

                return true;
            
        }

        /// <summary>
        /// This method has one int parameter.
        /// It checks if the int is <=42, Console.WriteLine($"{temp} is too cold!");
        /// between 43 and 78 inclusive, Console.WriteLine($"{temp} is an ok temperature");
        /// or > 78, Console.WriteLine($"{temp} is too hot!");
        /// For each temperature range, a different advice is given. 
        /// </summary>
        /// <param name="temp"></param>
        public static void GetTemperatureTernary(int temp)
        {
            //throw new NotImplementedException($"GetTemperatureTernary() has not been implemented.");

            switch(temp){

            case <= 42:
            Console.WriteLine($"{temp} is too cold!");

            break;
             
            case <= 43:
            Console.WriteLine($"{temp} is an ok temperature");

            break;
            

            case > 78:
             Console.WriteLine($"{temp} is too hot!");

            break;

        }
        }
    }//EoP
}//EoN
