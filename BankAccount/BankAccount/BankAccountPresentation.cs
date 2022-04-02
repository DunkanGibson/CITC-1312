using System;

namespace BankAccount
{
    class BankAccountPresentation
    {
        static void Main(string[] args)
        {
            CheckingAccount dunkanCheckingAccount = new("MyCheckingAccount", 1000123456, 098756565, "dollar", 5003.45);

            SavingsAccount dunkanSavingsAccount = new("MySavingsAccount", 100123545, 09234436, "pesos", 34454565.99);

            Console.WriteLine("You have this ammount left in your checking account " + dunkanCheckingAccount.Withdraw(44));
            Console.WriteLine("You have " + dunkanSavingsAccount.Deposit(44) + " pesos in you savings account");
            Console.WriteLine("Your bank account numbers are " + dunkanCheckingAccount.AccountNumber + " and " + dunkanSavingsAccount.AccountNumber);
            Console.WriteLine("Your total balance between both accounts is " + (dunkanSavingsAccount.Balance + dunkanSavingsAccount.Balance));



        }
    }
}
