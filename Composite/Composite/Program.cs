namespace Composite
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle();
            circle.Draw();

            Rectangle rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}

