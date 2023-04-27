namespace Module17_Practice
{
    public class RegularAccount : Account
    {
        public RegularAccount(double balance, string name) : base(balance, name)
        {
        }

        public override void CalculateInterest()
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            this.Interest = this.Balance * 0.4;
            if (this.Balance < 1000)
                this.Interest -= this.Balance * 0.2;

            if (this.Balance < 50000)
                this.Interest -= this.Balance * 0.4;
        }
    }
}
