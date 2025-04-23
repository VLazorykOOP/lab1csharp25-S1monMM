using System;

class Program
{
    static void Main()
    {
        // Введення значень n і m
        Console.Write("Введіть ціле число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть ціле число m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        // Перевірка ділення на нуль
        int denominator = n + m * m + 1;
        if (denominator == 0)
        {
            Console.WriteLine("Помилка: знаменник дорівнює нулю.");
            return;
        }

        // Обчислення виразу
        double result = (3.0 / denominator + 1) * (m - n);

        // Виведення результату
        Console.WriteLine($"Результат виразу: {result}");
    }
}
