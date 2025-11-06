using System;

class QuadraticEquation
{
    // Властивості
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public QuadraticEquation(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    // Метод обчислення кількості дійсних коренів
    public int RealRootsCount()
    {
        // Випадок: a = 0 → рівняння стає лінійним
        if (A == 0)
        {
            if (B == 0)
            {
                // 0x + C = 0 → або коренів немає, або ∞ (не беремо ∞)
                return 0;
            }
            else
            {
                // Лінійне рівняння має один корінь
                return 1;
            }
        }

        double D = B * B - 4 * A * C;

        if (D > 0)
            return 2;
        else if (D == 0)
            return 1;
        else
            return 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть кількість квадратних рівнянь: ");
        int n;

        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Помилка! Введіть додатнє число: ");
        }

        QuadraticEquation[] arr = new QuadraticEquation[n];

        // Введення коефіцієнтів
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nВведіть коефіцієнти A, B, C для рівняння #{i + 1}:");

            double a, b, c;

            Console.Write("A = ");
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.Write("Некоректний ввід! A = ");

            Console.Write("B = ");
            while (!double.TryParse(Console.ReadLine(), out b))
                Console.Write("Некоректний ввід! B = ");

            Console.Write("C = ");
            while (!double.TryParse(Console.ReadLine(), out c))
                Console.Write("Некоректний ввід! C = ");

            arr[i] = new QuadraticEquation(a, b, c);
        }

        // Пошук рівняння з максимальною кількістю коренів
        int maxRoots = -1;
        int index = -1;

        for (int i = 0; i < n; i++)
        {
            int roots = arr[i].RealRootsCount();
            if (roots > maxRoots)
            {
                maxRoots = roots;
                index = i;
            }
        }

        // Виведення результату
        Console.WriteLine("\n==== РЕЗУЛЬТАТ ====");
        if (index != -1)
        {
            Console.WriteLine($"Рівняння #{index + 1} має найбільшу кількість дійсних коренів: {maxRoots}");
            Console.WriteLine($"Коефіцієнти: A={arr[index].A}, B={arr[index].B}, C={arr[index].C}");
        }
        else
        {
            Console.WriteLine("Не вдалося знайти коректних рівнянь.");
        }
    }
}
