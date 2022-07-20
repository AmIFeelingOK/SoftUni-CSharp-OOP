using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int radius = int.Parse(Console.ReadLine());

            IDrawable rect = new Rectangle(height, width);
            IDrawable circle = new Circle(radius);

            rect.Draw();
            circle.Draw();
        }
    }
}
