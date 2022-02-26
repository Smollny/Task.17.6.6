namespace Task._17._6._6
{
    public class UsualAccount : ICalculatorInterest
    {
        // расчет процентной ставки обычного аккаунта по правилам банка
        public double CalculateInterest(double Balance)
        {
            double interest = Balance * 0.4;

            if (Balance < 1000)
                interest -= Balance * 0.2;

            if (Balance < 50000)
                interest -= Balance * 0.4;
            return interest;
        }
    }
}

