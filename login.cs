using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace LoginSystem
{
    class LSystem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!");
            Console.Write("Write your username here: ");
            string strUsername = Console.ReadLine();
            string strTUsername = "testuser";
            if (strUsername == strTUsername)
            {
                Console.Write("Write your password here: ");
                Console.ForegroundColor = ConsoleColor.Black;
                string strPassword = Console.ReadLine();
                string strTPassword = "testpwd";
                if (strPassword == strTPassword)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You are logged in!");
                    Console.ReadLine();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Bad password for user: {0}", strUsername);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Bad username!");
                Console.ReadLine();
            }
        }
    }
}
c#
