using System;

namespace deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your message?");
            string input = Console.ReadLine().ToUpper();

            int checksum = 0;
            string message = "";

            foreach (char c in input)
            {
                int code = (int)c;
                checksum += code;
                code = code - 64;
                message += (code.ToString()) + "-";
            }

            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);
        }
    }
}
