using System.Security.Principal;

namespace Module17_Practice
{
    public abstract class Account
    {
        // баланс учетной записи
        public double Balance { get; set; }
        // имя учетной записи
        public string Name { get; set; }
        // процентная ставка
        public double Interest { get; set; }

        public abstract void CalculateInterest();
        public Account(double balance, string name)
        {
            Balance = balance;
            Name = name;
        }
    }
}
