using System;
using static System.Console;
namespace ATMConsoleApplication
{
    public class ATM
    {

        public static void Run()
        {
            BankAccounts bank = new BankAccounts();
            ForegroundColor = ConsoleColor.DarkYellow;
            Printing.Title();
            Write("\n>Would You Like to Create a New Account? (Yes/No) ");
            ReadKey();

        }


    }
}

