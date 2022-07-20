using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int height;
        private int width;

        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public int Height 
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        public int Width 
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public void Draw()
        {
            for (int i = 0; i < this.Height; i++)
            {
                for (int j = 0; j < this.Width; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
