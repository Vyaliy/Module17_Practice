namespace Module17_Practice
{
    public class SalaryAccount : Account
    {
        public SalaryAccount(double balance, string name) : base(balance, name)
        {
        }

        public override void CalculateInterest()
        {
            // расчет процентной ставки зарплатного аккаунта по правилам банка
            this.Interest = this.Balance * 0.5;
        }
    }
}
