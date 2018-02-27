using System;

namespace Composite
{
    public class Rectangle: Shape
    {
        public override string Name { get; set; } = "Rectangle";

        public override void Draw() => Console.WriteLine("Rectangle object's draw method\n");
    }
}
