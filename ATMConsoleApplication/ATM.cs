using System;
using static System.Console;
namespace ATMConsoleApplication
{
    public class ATM
    {
        // Start of the Program //
        public static void Run()
        {

            ForegroundColor = ConsoleColor.DarkYellow;
            Printing.Title();
            Write("\n> Would You Like to Create a New Account? (Yes/No) ");
            string userResponse = Console.ReadLine().ToLower().Trim();

            switch (userResponse)
            {
                case "yes":
                    GetUserInformation();
                    break;
                case "no":
                    Exit();
                    break;
                default:
                    Error();
                    break;
            }
        }
        // Grabbing User Information //
        public static void GetUserInformation()
        {
            Printing.Title();

            Write("\n> Please Enter Your First Name: ");
            string firstName = ReadLine().ToLower().Trim() ?? "Unknown";
            Write("\n> Please Enter Your Last Name: ");
            string lastName = ReadLine().ToLower().Trim() ?? "Unknown";
            Write("\n> Please Enter Your Starting Balance: ");
            bool parse = double.TryParse(ReadLine(), out double balance);
            if (!parse)
            {
                Printing.InvalidSelection();
                GetUserInformation();
            }

            bool confirmed = false;
            int pin = 0;
            while (!confirmed)
            {
                Printing.Title();
                Write("\n> Please Create a Secret Pin: ");
                bool parse2 = int.TryParse(ReadLine(), out int num);
                if (!parse2)
                {
                    Printing.InvalidSelection();
                    GetUserInformation();
                }
                WriteLine($"\n> You entered * {num} *");
                Write("\n> Are you sure you want this as your pin? (Yes/No) ");
                string userResponse = ReadLine().ToLower().Trim();
                if (userResponse == "yes")
                {
                    WriteLine("\n> Loading Please Wait... ");
                    Thread.Sleep(1500);
                    WriteLine("\n> Your Secret Pin is Confirmed. ");
                    Write("\n> Press Enter to Continue. ");
                    pin = num;
                    confirmed = true;
                }
            }
            CreateUser(firstName, lastName, balance, pin);
        }

        // Creating the User Object //
        public static void CreateUser(string firstName, string lastName, double balance, int pin)
        {
            Printing.Title();
            BankAccounts bank = new BankAccounts();
            User newUser = new User(firstName, lastName, balance, pin);
            bank.AddNewUserToList(newUser);
            WriteLine("\n> We have automatically generated you an Account Number.");
            WriteLine("\n> Please Write this Down");
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"\n> Authentic Number: > {newUser.GetUserCardNum()} <");
            ForegroundColor = previousColor;
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

