using System;

namespace EX33
{
    class Program
    {
        static void Main(string[] args)
        {
            RectAngle rectAngle1 = new RectAngle(2, 3);
            RectAngle rectAngle2 = new RectAngle(1, 4);
            if (rectAngle1 == rectAngle2)
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しい");
            }
            else
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しくない");
            }
            RectAngle rectAngle3 = rectAngle1 + rectAngle2;
            Console.WriteLine(rectAngle3.width + " : " + rectAngle3.height);
        }
    }
}