using System;
using Services;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your phone number: (for example: +7XXXXXXXXXXX)");
            string userPhoneNumber = Console.ReadLine();
            SmsSender.Send(userPhoneNumber);
        }
    }
}
