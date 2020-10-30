using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            double amountToChange;
            Console.WriteLine("Hello, would you like to make a deposit?");
            if (Console.ReadLine().ToLower() =="yes")
            {
                Console.WriteLine("How much would you like to deposit?");
                amountToChange = double.Parse(Console.ReadLine());
                account.Deposit(amountToChange);
                Console.WriteLine($"You deposited ${amountToChange}, which brings your total balance to ${account.GetBalance()}");

            }
            var michaelsInfo = new PersonalInformation();
            string number;
            long result;

            do
            {
                Console.WriteLine("What is your area code and telephone number?");
                Console.WriteLine("With the following format: 2051235555");
                number = Console.ReadLine();

            } while (number.Length != 10 || !long.TryParse(number, out result));
            michaelsInfo.NumberFormatted = number;

            michaelsInfo.NumberFormatted = Console.ReadLine();
            Console.WriteLine($"Your new phone number is {michaelsInfo.NumberFormatted}");

        }
    }
}
