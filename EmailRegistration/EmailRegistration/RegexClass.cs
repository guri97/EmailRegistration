using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexPattern
{
    public class RegexClass
    {
        public Regex EmailAddressRegex = new Regex(@"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})?$");
        public void ValidateEmailAddressRegex(string EmailAddress)
        {
            Console.WriteLine("\nemail address:" + EmailAddress);
            if (EmailAddressRegex.IsMatch(EmailAddress))
                Console.WriteLine("valid email address");
            else
                Console.WriteLine("invalid email address");

        }


    }



}