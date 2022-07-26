using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            *
            * implement the required code here and within the methods below.
            *
            */
            //when you call a method, you call it with arguments. The args values are held in a variable.
          
            //Upper case
             Console.WriteLine("What is your name");
             string myString = Console.ReadLine();
             string upcase = StringToUpper(myString);
             Console.WriteLine(upcase);


             //Lower case
             Console.WriteLine("Where are you from?");
             string usersString = Console.ReadLine();
             string lowcase = StringToLower(usersString);
             Console.WriteLine(lowcase);


             //Trim
             Console.WriteLine("How would you describe yourself?---Pls leave a blank space before typing");
             string usersStringWithWhiteSpace = Console.ReadLine();
             string totrim = StringTrim(usersStringWithWhiteSpace);
             Console.WriteLine(totrim);


              //StringSubstring
              Console.WriteLine("Spell 'Goodness'");
              string x = Console.ReadLine();
              int firstElement = 0;
              int lengthOfSubsring = 4;
              string ss = StringSubstring(x, firstElement, lengthOfSubsring);
              Console.WriteLine(ss);


              //Index of a character in a string
              Console.Write( "Let's check for the index of the first ocurrance of 't' in 'mathematics'\n");
              string userInputString = "mathematics";
              char charUserWants = 't';
              int characterlocation = SearchChar(userInputString, charUserWants);
              Console.WriteLine(characterlocation);


              //Combine two strings
              Console.Write( "Let's combine two strings \n");
              string fName = "Great";
              string lName = "lecture";
              string combination = ConcatNames(fName, lName);
              Console.WriteLine(combination);
        }

        /// <summary>
        /// This method has one string parameter and will: 
        /// 1) change the string to all upper case and 
        /// 2) return the new string.
        /// </summary>
        /// <param name="usersString"></param>
        /// <returns></returns>
        public static string StringToUpper(string myString)// the method itself has 'parameters'
        {
            // throw new NotImplementedException("StringToUpper method not implemented.");
            return myString.ToUpper();
        }

        /// <summary>
        /// This method has one string parameter and will:
        /// 1) change the string to all lower case,
        /// 2) return the new string into the 'lowerCaseString' variable
        /// </summary>
        /// <param name="usersString"></param>
        /// <returns></returns>       
        public static string StringToLower(string usersString)
        {
            //throw new NotImplementedException("StringToUpper method not implemented.");
            return usersString.ToLower();
        }

        /// <summary>
        /// This method has one string parameter and will:
        /// 1) trim the whitespace from before and after the string, and
        /// 2) return the new string.
        /// HINT: When getting input from the user (you are the user), try inputting "   a string with whitespace   " to see how the whitespace is trimmed.
        /// </summary>
        /// <param name="usersStringWithWhiteSpace"></param>
        /// <returns></returns>
        public static string StringTrim(string usersStringWithWhiteSpace)
        {
            //throw new NotImplementedException("StringTrim method not implemented.");
             
             string tr = usersStringWithWhiteSpace.Trim();

             return tr;
        }

        /// <summary>
        /// This method has three parameters, one string and two integers. It will:
        /// 1) get the substring based on the first integer element and the length 
        /// of the substring desired.
        /// 2) return the substring.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="firstElement"></param>
        /// <param name="lastElement"></param>
        /// <returns></returns>
        public static string StringSubstring(string x, int firstElement, int lengthOfSubsring)
        {
           //throw new NotImplementedException("StringSubstring method not implemented.");

           string sst = x.Substring(firstElement, lengthOfSubsring);
           
           return sst;
        }

        /// <summary>
        /// This method has two parameters, one string and one char. It will:
        /// 1) search the string parameter for first occurrance of the char parameter and
        /// 2) return the index of the char.
        /// HINT: Think about how StringTrim() (above) would be useful in this situation
        /// when getting the char from the user. 
        /// </summary>
        /// <param name="userInputString"></param>
        /// <param name="charUserWants"></param>
        /// <returns></returns>
        
        public static int SearchChar(string userInputString, char charUserWants)
        {
            //hrow new NotImplementedException("SearchChar method not implemented.");

            int searchcha = userInputString.IndexOf(charUserWants);

            return searchcha;
           
        }


        /// <summary>
        /// This method has two string parameters. It will:
        /// 1) concatenate the two strings with a space between them.
        /// 2) return the new string.
        /// HINT: You will need to get the users first and last name in the 
        /// main method and send them as arguments.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <returns></returns>
        public static string ConcatNames(string fName, string lName)
        {
            //throw new NotImplementedException("ConcatNames method not implemented.");
             

             string comb = String.Concat(fName, lName);

            return comb;
        }
    }//end of program
}
