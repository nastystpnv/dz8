using System;

namespace dz8
{
    internal class tumakov9
    {
        enum BankAccountType
        {
            Current,
            Saving
        }
        class BankAccount
        {
            private int Account_number;
            private double Balance;
            private BankAccountType Type;
            private int Number;
            private int Generic;
            static Random r = new Random();
            private static int generic_number = r.Next(999, 10000);
            public BankAccount(int account_number, double balance, BankAccountType type, int number)
            {
                this.Account_number = account_number;
                Balance = balance;
                Number = number;
                Type = type;
                Generic = generic_number++;
            }
            
            public double PutOnAccount(double balance)
            {
                Console.Write("Введите сумму для пополнения ");
                double temp = Convert.ToDouble(Console.ReadLine());
                return balance + temp;
            }
            public double WithdrawFromAccount(double balance)
            {
                Console.Write("Введите сумму для снятия ");
                double temp = Convert.ToDouble(Console.ReadLine());
                if (balance >= temp)
                { return balance - temp; }
                else
                { Console.WriteLine("На вашем счёте недостаточно средств!"); return balance; }
            }
            public void Transfer(BankAccount destinationAccount, double amount)
            {
                Console.Write("Введите сумму для перевода: ");
                double transferAmount = Convert.ToDouble(Console.ReadLine());

                if (this.Balance >= transferAmount)
                {
                    this.Balance -= transferAmount;
                    destinationAccount.Balance += transferAmount;
                    Console.WriteLine($"Перевод успешен! Сумма {transferAmount}$ переведена со счёта {this.Number} на счёт {destinationAccount.Number}");
                }
                else
                {
                    Console.WriteLine("На вашем счёте недостаточно средств для перевода.");
                }
                Console.ReadKey();
            }
        }
    }
}
