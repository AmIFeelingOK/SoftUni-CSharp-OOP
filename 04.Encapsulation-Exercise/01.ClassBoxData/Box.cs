using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length 
        {
            get
            {
                return this.length;   
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public double SurfaceArea(double length, double width, double height)
        {
            double surfaceArea = 2 * (height * width + length * height + length * width);
            return surfaceArea;
        }

        public double LateralSurfaceArea(double length, double width, double height)
        {
            double lateralSurfaceArea = 2 * height * (width + length);
            return lateralSurfaceArea;
        }

        public double Volume(double length, double width, double height)
        {
            double volume = length * width * height;
            return volume;
        }
    }
}
