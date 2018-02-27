using System;

namespace Strategy_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var calculator = new Calculator(new Adding());
			Console.Writeline (calculator.Solve(4,5));
			Console.Readline ();
        }
            
    }        
}
    
    