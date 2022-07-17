using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdaUserRegistration
{
    public class UserRegistration
    {

        //Creating method for checking password that have min 8 characters
        public static void CheckUserPassword()
        {
            Console.WriteLine("Enter Password- ");
            string password = Console.ReadLine();
            string passwordpattern = @"^[a-zA-Z]{8,}$";

            //using lambda expression to validate the password 
            Func<string, bool> Validfirstname = p => Regex.IsMatch(password, passwordpattern);

            bool result = Validfirstname(password);
            Console.WriteLine(result);






        }

    }  
}
