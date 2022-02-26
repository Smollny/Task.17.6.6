namespace Task._17._6._6
{
    public class Account
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public void CalculateInterest(ICalculator calculator)
        {
            Interest = calculator.CalculateInterest(Balance);
        }
    }
}
