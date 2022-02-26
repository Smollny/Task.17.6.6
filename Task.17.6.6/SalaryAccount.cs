namespace Task._17._6._6
{
    public class SalaryAccount: ICalculator
    {
        // расчет процентной ставки зарплатного аккаунта по правилам банка
        public double CalculateInterest(double Balance) => Balance * 0.5;
    }
}
