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
            Write("\n> Would You Like to Create a New Account? (Yes/No) ");
            string userResponse = Console.ReadLine().ToLower().Trim();

            switch (userResponse)
            {
                case "yes":
                    CreateUser();
                    break;
                case "no":
                    Exit();
                    break;
                default:
                    Error();
                    break;
            }
        }

        public static void CreateUser()
        {
            Printing.Title();

            Write("\n> Please Enter Your First Name: ");
            string firstName = ReadLine().ToLower().Trim();
            Write("\n> Please Enter Your Last Name: ");
            string lastName = ReadLine().ToLower().Trim();
            Write("\n> Please Enter Your Starting Balance: ");
            bool parse = int.TryParse(ReadLine(), out int balance);
            if (!parse)
            {
                Printing.InvalidSelection();
                CreateUser();
            }
            Write("\n> Please Create a Secret Pin: ");
            bool parse2 = int.TryParse(ReadLine(), out int pin);
            if (!parse2)
            {
                Printing.InvalidSelection();
                CreateUser();
            }
            ReadKey();
        }



        public static void Exit()
        {
            WriteLine("\n> Thank you and Please Come Again!");
            Thread.Sleep(1300);
            Environment.Exit(0);
        }

        public static void Error()
        {
            Printing.InvalidSelection();
            Run();
        }


    }


}

