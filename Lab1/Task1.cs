using System;

namespace Lab1
{
    public static class Task1
    {
        static int[,] GetRandPoints(int count)
        {
            int[,] points = new int[count, 2];

            Random rand = new Random();
            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    points[i, j] = rand.Next(10);
                }
            }
            return points;
        }
        static void ShowPonts(int[,] points)
        {
            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    Console.Write(points[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static double GetDistance(int[,] m, int p1, int p2)
        {
            double dist = Math.Sqrt(Math.Pow((m[p1, 0] - m[p2, 0]), 2.0) + Math.Pow((m[p1, 1] - m[p2, 1]), 2.0));
            return dist;
        }
        static void GetFarthestPoints(int[,] m, out int point1, out int point2)
        {
            int p1 = 0, p2 = 0;
            double max = 0, dist = 0;
            for (int p = 0; p < m.GetLength(0) - 1; p++)
            {
                for (int q = p + 1; q < m.GetLength(0); q++)
                {
                    dist = GetDistance(m, p, q);
                    if (dist > max)
                    {
                        max = dist;
                        p1 = p;
                        p2 = q;
                    }
                }
            }
            point1 = p1;
            point2 = p2;
        }

        static public void Demo()
        {
            int[,] points = GetRandPoints(5);
            Console.WriteLine("Points:");
            ShowPonts(points);
            GetFarthestPoints(points, out int point1, out int point2);
            Console.WriteLine($"The farthest points are {point1 + 1} and {point2 + 1}.");
        }
    }
}