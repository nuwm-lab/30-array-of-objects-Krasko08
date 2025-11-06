using System;

namespace Lab4
{
    // ===== КЛАС ТОЧКА =====
    class Point
    {
        public double X, Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    // ===== КЛАС ПРЯМА =====
    // Пряма задана коефіцієнтами A, B, C:  A*x + B*y + C = 0
    class Line
    {
        public double A, B, C;

        public Line(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        // метод: чи лежить точка на прямій
        public bool ContainsPoint(Point p)
        {
            return Math.Abs(A * p.X + B * p.Y + C) < 0.000001;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of lines: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Line[] lines = new Line[n];

            // введення прямих
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter A, B, C for line #{i + 1}:");
                double A = Convert.ToDouble(Console.ReadLine());
                double B = Convert.ToDouble(Console.ReadLine());
                double C = Convert.ToDouble(Console.ReadLine());

                lines[i] = new Line(A, B, C);
            }

            // введення двох точок
            Console.WriteLine("Enter coordinates of point 1 (x1, y1):");
            Point p1 = new Point(
                Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine())
            );

            Console.WriteLine("Enter coordinates of point 2 (x2, y2):");
            Point p2 = new Point(
                Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine())
            );

            Console.WriteLine("\nLines that contain at least one of the points:");

            bool found = false;

            for (int i = 0; i < n; i++)
            {
                if (lines[i].ContainsPoint(p1) || lines[i].ContainsPoint(p2))
                {
                    Console.WriteLine($"Line #{i + 1}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No line contains the entered points.");
            }
        }
    }
}
