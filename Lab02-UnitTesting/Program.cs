namespace Lab02_ATM
{

    public class ATM
    {
        public static decimal Balance = 5;

        public static decimal Withdraw(decimal amount)
        {
            decimal newBalance = Balance - amount;

            if (newBalance < 0 || amount < 0)
            {
                return Balance;
            }
            else
            {
                Balance -= amount;
                return Balance;
            }
        }

        public static decimal Deposit(decimal amount)
        {
            if (amount < 0)
            {
                return Balance;
            }
            else
            {
                Balance += amount;
                return Balance;
            }
        }

        public static decimal ViewBalance()
        {
            return Balance;
        }

        static void UserInterface()
        {
            string userInput = "";

            Console.WriteLine("Welcome to the ATM");
            while (userInput != "exit")
            {
                Console.WriteLine("\nPlease select from the following: withdraw, deposit, view balance or type exit to quit");
                userInput = Console.ReadLine();

                decimal amount;
                decimal newBalance = ViewBalance();

                switch (userInput)
                {
                    case "withdraw":
                        Console.WriteLine("How much would you like to withdraw?");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        newBalance = Withdraw(amount);
                        Console.WriteLine($"Withdrawal successful! You withdrew ${amount}, and your new balance is {newBalance}");
                        break;

                    case "deposit":
                        Console.WriteLine("How much would you like to deposit?");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        newBalance = Deposit(amount);
                        Console.WriteLine($"Deposit successful! You deposited ${amount}, and your new balance is {newBalance}");
                        break;

                    case "view balance":
                        Console.WriteLine($"Your current balance is {newBalance}");
                        break;

                    default:
                        break;

                }
            }
            Console.WriteLine("\nThanks for banking with us. See you soon!");
        }

        static void Main()
        {
            UserInterface();
        }
    }
}
