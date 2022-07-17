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
        public static void CheckEmail()
        {
            Console.WriteLine("Enter Email- ");
            string email = Console.ReadLine();
            string emailpattern = @"^([A-Za-z]{3,}([.a-z]*)@[a-z]{2,}[.][a-z]{2,3}([.a-z]*))$";

            //Validate the Email byusing Lambda Expression
            Func<string, bool> ValidEmail = p => Regex.IsMatch(email, emailpattern);

            bool result = ValidEmail(email);
            Console.WriteLine(result);



        }
    
    }  
}
