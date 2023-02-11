using System;
using System.Runtime.CompilerServices;

class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("**************VIVO BANK***************");
        Console.WriteLine("\t\tLogin Page");

        Console.WriteLine("Enter Username");
        string userName = Console.ReadLine();

       if(userName != "")
        {
            Console.WriteLine("Password : use a strong password");
            string password = Console.ReadLine();
        }

    }
}
