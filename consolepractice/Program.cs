using System;

namespace consolepractice
{
    internal static class Program
    {
        private class BankAccount
        {
            private double _balance;

            public void Deposit(double n)
            {
                _balance += n;
            }

            public void Withdraw(double n)
            {
                _balance -= n;
            }

            public double GetBalance()
            {
                return _balance;
            }
        }

        private static void Deposit()
        {
            BankAccount account = new BankAccount();
            Console.Write("Enter amount to deposit: ");
            double value = Convert.ToDouble(Console.Read());
            account.Deposit(value);
            // ReSharper disable once HeapView.BoxingAllocation
            Console.WriteLine("Deposited. Balance is now {0}.", account.GetBalance());
            Menu();
        }

        private static void Withdraw()
        {
            BankAccount account = new BankAccount();
            Console.Write("Enter amount to withdraw: ");
            double value = Convert.ToDouble(Console.Read());
            if (account.GetBalance() > value)
            {
                account.Withdraw(value);
                // ReSharper disable once HeapView.BoxingAllocation
                Console.WriteLine("Deposited. Balance is now {0}.", account.GetBalance());
            }
            else
            {
                // ReSharper disable once HeapView.BoxingAllocation
                Console.WriteLine("Failed to withdraw. Balance too low: {0}.", account.GetBalance());
            }
            Menu();
        }

        private static void Menu()
        {
            while (true)
            {
                BankAccount account = new BankAccount();
                // ReSharper disable once AssignNullToNotNullAttribute
                var choice = Convert.ToChar(value: Console.Read());

                if (choice == 'D' || choice == 'd')
                {
                    Deposit();
                }
                else if (choice == 'W' || choice == 'w')
                {
                    Withdraw();
                }
                else if (choice == 'B' || choice == 'b')
                {
                    // ReSharper disable once HeapView.BoxingAllocation
                    Console.WriteLine("Balance is {0}", account.GetBalance());
                    continue;
                }

                break;
            }
        }

        public static void Main()
        {
            Console.WriteLine("Welcome to Bank of Camden!\n[D]eposit, [W]ithdraw, or check [B]alance? ");
            Menu();
        }
    }
}