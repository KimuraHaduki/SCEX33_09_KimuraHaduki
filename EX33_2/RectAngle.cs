using System;
using System.Collections.Generic;
using System.Text;

namespace EX33
{
    class RectAngle : ISurface, ICircumference, IBounds
    {
        readonly public float width;
        readonly public float height;
        public RectAngle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public float GetSurface()
        {
            return width * height;
        }
        public float GetCircumference()
        {
            return (width + height) * 2;
        }
        public void GetBounds(out float width, out float height)
        {
            width = this.width;
            height = this.height;
        }
        public static bool operator ==(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width;
        }

        public static bool operator !=(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return !(rectAngle1 == rectAngle2);
        }
        public static RectAngle operator +(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            float newWidth;
            float newHeight;
            if (rectAngle1.width > rectAngle1.height)
            {
                rectAngle1 = new RectAngle(rectAngle1.height, rectAngle1.width);
            }
            if (rectAngle2.width > rectAngle2.height)
            {
                rectAngle2 = new RectAngle(rectAngle2.height, rectAngle2.width);
            }
            if (rectAngle1.width + rectAngle2.width < rectAngle1.height + rectAngle2.height)
            {
                newWidth = rectAngle1.width + rectAngle2.width;
                if (rectAngle1.height > rectAngle2.height)
                {
                    newHeight = rectAngle1.height;
                }
                else
                {
                    newHeight = rectAngle2.height;
                }
            }
            else
            {
                newHeight = rectAngle1.height + rectAngle2.height;
                if (rectAngle1.width > rectAngle2.width)
                {
                    newWidth = rectAngle1.width;
                }
                else
                {
                    newWidth = rectAngle2.width;
                }

            }
            return new RectAngle(newWidth, newHeight);
        }
    }
}