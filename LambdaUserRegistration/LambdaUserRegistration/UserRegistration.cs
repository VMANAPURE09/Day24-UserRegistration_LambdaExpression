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

        //Creating method for checking Email Sample
        public static void CheckEmailSample()
        {
            Console.WriteLine("Enter Email- ");
            string emailsample = Console.ReadLine();
            string emailsamplepattern = @"^([a-z]{3}([\.\+\-0-9]*)@[a-z0-9]{1,}.[a-z]{3,}[.a-z]*)";

            //using lambda expression 
            Func<string, bool> ValidEmail = p => Regex.IsMatch(emailsample, emailsamplepattern);

            bool result = ValidEmail(emailsample);
            Console.WriteLine(result);

        }
    }
}
