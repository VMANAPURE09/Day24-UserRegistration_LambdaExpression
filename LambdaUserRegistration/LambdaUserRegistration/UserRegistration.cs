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
        public static void CheckLastName()
        {
            Console.WriteLine("Enter your Last Name- ");
            string lastname = Console.ReadLine();
            string lastnamepattern = @"^[A-Z]{1}[a-z]{2,}$";

            //Validate the Lastname byusing Lambda Expression  
            Func<string, bool> Validfirstname = p => Regex.IsMatch(lastname, lastnamepattern);

            bool result = Validfirstname(lastname);
            Console.WriteLine(result);


            
        }
    }
}
