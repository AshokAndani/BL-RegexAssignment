using System;
using System.Text.RegularExpressions;

namespace RegexPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// for Pincode
            //Console.WriteLine("Enter PinCode:");
            //string pincode=Console.ReadLine();
            //Regex Pincoderegex = new Regex(Patterns.PinCodePattern);
            //var Pincodeflag= Pincoderegex.IsMatch(pincode);
            //Console.WriteLine(Pincodeflag);

            //// for phone number
            //Console.WriteLine("Enter Phone Number:");
            //string PhoneNumber = Console.ReadLine();
            //Regex phoneRegex = new Regex(Patterns.PhoneNumberPattern);
            //var phoneFlag = phoneRegex.IsMatch(PhoneNumber);
            //Console.WriteLine(phoneFlag);

            // for gmail
            Console.WriteLine("Enter mail id:");
            string MailId = Console.ReadLine();
            Regex mailRegex = new Regex(Patterns.EmailPattern);
            var mailFlag = mailRegex.IsMatch(MailId);
            Console.WriteLine(mailFlag);
        }
    }
}
