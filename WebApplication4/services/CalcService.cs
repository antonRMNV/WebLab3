namespace ASP3
{
    public class CalcService : ICalc
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Miltiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
