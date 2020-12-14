using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your phone number: (for example: +7XXXXXXXXXXX)");
            string userPhoneNumber = Console.ReadLine();
            var randomCode = RandomCodeGenerator.Generate(4);

            // Find your Account Sid and Token at twilio.com/console
            // and set the environment variables. See http://twil.io/secure
            string accountSid = "AC9cf7e06038b71632ddfa89adfc6f7979";
            string authToken = "ea1511413469f19e002fe19104259220";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: $"Your 4-digits code is: {randomCode} ",
                from: new Twilio.Types.PhoneNumber("+16516153710"),
                to: new Twilio.Types.PhoneNumber(userPhoneNumber)
            );
            Console.WriteLine(message.Sid);
            bool checkUserCode = true;
            var SendedUserCode = " ";
            while (checkUserCode)
            {
                Console.WriteLine("Enter your 4-digits code: ");

                SendedUserCode = Console.ReadLine();
                if (SendedUserCode == randomCode)
                {
                    Console.WriteLine("Success!");
                    checkUserCode = false;
                }
                else
                {
                    Console.WriteLine("Incorrect 4-digits code, try again!");
                }
            }
        }
    }
}
