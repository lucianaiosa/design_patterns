using System;

namespace Composite
{
    public class Circle : Shape
    {
        public override string Name { get; set; } = "Circle";

        public override void Draw()
        {
            Console.WriteLine("Circle object's draw method\n");
        }
    }
}
