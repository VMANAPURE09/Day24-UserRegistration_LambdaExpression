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

        //Creating method for checking Mobile Format
        public static void CheckMobileNumber()
        {
            Console.WriteLine("Enter Mobile Number- ");
            string mobnum = Console.ReadLine();
            string MobNumpattern = @"^[1-9]{2,}[' '][7-9]{1}[0-9]{9}$";

            //using lambda expression to validate the Mobile Number
            Func<string, bool> Validfirstname = p => Regex.IsMatch(mobnum, MobNumpattern);

            bool result = Validfirstname(mobnum);
            Console.WriteLine(result);





        }

    }  
}
