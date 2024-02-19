namespace ASP3
{
    public class CalcController
    {
        public ICalc Service { get; set; }
        public CalcController(ICalc service)
        {
            Service = service;
        }
        public char RandomOperation()
        {
            return new Random().Next(0, 5) switch
            {
                1 => '+',
                2 => '-',
                3 => '*',
                4 => '/',
                _ => '+'
            };

        }
        public double CalculateRandomOperation(char op, double a, double b)
        {
            return op switch
            {
                '+' => Service.Add(a, b),
                '-' => Service.Subtract(a, b),
                '*' => Service.Miltiply(a, b),
                '/' => Service.Divide(a, b)
            };
        }
    }
}
