using System;
using static System.Console;
namespace ATMConsoleApplication
{
    public class Printing
    {
        public static void Title()
        {
            Clear();
            WriteLine("=================================");
            WriteLine("=================================");
            WriteLine("==== Welcome to No Money ATM ====");
            WriteLine("=================================");
            WriteLine("=================================");

        }

        public static void AtmSelection()
        {
            WriteLine("Please select one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        public static void InvalidSelection()
        {
            Title();
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Red;
            WriteLine("\n> Plesase Enter a Valid Selection! ");
            ForegroundColor = previousColor;
            Write("\n> Press Enter to Continue. ");
            ReadKey();
        }
    }
}

