using System;

class Program
{
    static void Main()
    {
        // Введення сторін трикутника
        Console.Write("Введіть сторону a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть сторону b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть сторону c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Обчислення периметра
        double perimeter = a + b + c;

        // Виведення результату
        Console.WriteLine("Периметр трикутника: " + perimeter);

        Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}
