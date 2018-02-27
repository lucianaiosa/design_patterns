namespace Strategy_Pattern
{
    public class Calculator
    {
		private readonly ICalculate calculate;
        public Calculator(ICalculate calculate)
        {
			this.calculate = calculate;
        }
		public double Solve(double op1, double op2)
		{
			return this.calculate.Calculate (op1, op2);
		}
    }
}
