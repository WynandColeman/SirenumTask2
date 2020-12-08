using System;
using System.Drawing;

namespace SirenumTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Source https://stackoverflow.com/questions/4243042/c-sharp-point-in-polygon


            Point pointer = new Point(3, 3);

            PointF[] points = new PointF[]
            {
                new Point { X = 3, Y = 4 },
                new Point { X = 5, Y = 3 },
                new Point { X = 4, Y = 2 },
                new Point { X = 5, Y = 1 },
                new Point { X = 1, Y = 2 },

            };

            Console.WriteLine(IsPointInPolygon(points, pointer));

            static bool IsPointInPolygon(PointF[] polygon, PointF testPoint)
            {
                bool result = false;
                int j = polygon.Length - 1; Console.WriteLine(polygon.Length);
                for (int i = 0; i < polygon.Length; i++)
                {
                    if (polygon[i].Y < testPoint.Y && polygon[j].Y >= testPoint.Y || polygon[j].Y < testPoint.Y && polygon[i].Y >= testPoint.Y)
                    {
                        if (polygon[i].X + (testPoint.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < testPoint.X)
                        {
                            result = !result;
                        }
                    }
                    j = i;
                }
                return result;
            }

        }
    }
}