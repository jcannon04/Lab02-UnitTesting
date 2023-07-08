class ATM
{
    static public decimal Balance;

    static decimal Withdraw(decimal amount)
    {
        return Balance - amount;
    }

    static decimal Deposit(decimal amount)
    {
        return Balance + amount;
    }

    static decimal ViewBalance()
    {
        return Balance;
    }

    static void UserInterface()
    {
        string userInput = "";

        while (userInput != "exit")
        {

            Console.WriteLine("Welcome to the ATM, please select from the following:\n\nwithdraw, deposit, view balance or type exit to quit\n");
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
                    Console.WriteLine("How much would you like to withdraw?");
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
    }

    static void Main()
    {
        UserInterface();
    }
}
