
namespace Lab02_Tests
{
    public class Lab02Test
    {
        [Fact]
        public void Withdraw_WithAmountGreaterThanBalance_ReturnsOriginalBalance()
        {
            decimal Balance = Lab02_ATM.ATM.Balance;
            decimal withdrawalAmount = Balance + 1;

            decimal newBalance = Lab02_ATM.ATM.Withdraw(withdrawalAmount);

            Assert.Equal(Balance, newBalance);
        }

        [Fact]
        public void Withdraw_WithNegativeAmount_ReturnsOriginalBalance()
        {
            decimal Balance = Lab02_ATM.ATM.Balance;
            decimal withdrawalAmount = -1;

            decimal newBalance = Lab02_ATM.ATM.Withdraw(withdrawalAmount);

            Assert.Equal(Balance, newBalance);
        }
        [Fact]

        public void Withdraw_WithValidAmount_ReturnsNewBalance()
        {
            decimal Balance = Lab02_ATM.ATM.Balance;
            decimal withdrawalAmount = Balance - 1;

            decimal newBalance = Lab02_ATM.ATM.Withdraw(withdrawalAmount);

            Assert.Equal(Balance - withdrawalAmount, newBalance);
        }

        [Fact]
        public void Deposit_WithNegativeAmount_ReturnsOriginalBalance()
        {
            decimal Balance = Lab02_ATM.ATM.Balance;
            decimal depositAmount = -1;
            decimal newBalance = Lab02_ATM.ATM.Deposit(depositAmount);

            Assert.Equal(Balance, newBalance);
        }

        [Fact]
        public void Deposit_WithValidAmount_ReturnsNewBalance()
        {
            decimal Balance = Lab02_ATM.ATM.Balance;
            decimal depositAmount = 1;
            decimal newBalance = Lab02_ATM.ATM.Deposit(depositAmount);

            Assert.Equal(Balance + depositAmount, newBalance);
        }

        [Fact]
        public void ViewBalance_ReturnsCurrentBalance()
        {
            decimal Balance = Lab02_ATM.ATM.Balance;
            decimal viewedBalance = Lab02_ATM.ATM.ViewBalance();

            Assert.Equal(Balance, viewedBalance);
        }

    }
}
