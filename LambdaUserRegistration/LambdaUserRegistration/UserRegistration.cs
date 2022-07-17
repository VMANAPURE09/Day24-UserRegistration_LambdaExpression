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

        //Creating method for checking password that have min 8 characters ,atleast 1 uppercase & 1 numeric number
        public static void CheckUserPassword()
        {
            Console.WriteLine("Enter Password- ");
            string password = Console.ReadLine();
            string passwordpattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-z]).{8,}$";

            //using lambda expression 
            Func<string, bool> Validfirstname = p => Regex.IsMatch(password, passwordpattern);

            bool result = Validfirstname(password);
            Console.WriteLine(result);
        }

    }  
}
