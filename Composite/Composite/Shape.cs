using System;

namespace Composite
{
    public abstract class Shape 
    {
        public virtual string Name { get; set; } = "Group";
        public string Color { get; set; }
        public virtual void Draw() => Console.WriteLine("Object's draw method\n");
    }
}
