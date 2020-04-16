using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your message?");
            string input = Console.ReadLine();
            input = input.ToUpper();
            string message = null;
            int checksum = 0;

            foreach (char c in input.ToCharArray())
            {
                checksum += c;
                message += (c - 64) + "-";
            }

            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);
        }
    }
}
