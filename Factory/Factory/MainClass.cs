using System;

namespace Factory
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            var p1 = new Point(2, 3);
            
            var p2 = PointFactory.NewPolarPoint(1.0, Math.PI/ 2);
            var p3 = PointFactory.NewCartesianPoint(1, 2);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            
        }

    }
}
