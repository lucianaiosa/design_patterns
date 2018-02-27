using System;

namespace Factory
{
    public class Point
    {
        private double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        //Instancia Singleton
        public static Point Origin = new Point(0, 0);

        public override string ToString() => $"{nameof(x)}: {x}, {nameof(y)}: {y}";
    }

}

