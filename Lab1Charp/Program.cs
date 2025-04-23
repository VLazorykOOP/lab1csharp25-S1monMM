using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Меню
            Console.WriteLine("\nОберіть завдання:");
            Console.WriteLine("1. Обчислення площі рівностороннього трикутника");
            Console.WriteLine("2. Перевірка, чи є число парним");
            Console.WriteLine("3. Перевірка точки на належність до заштрихованої області");
            Console.WriteLine("4. Визначення масті за номером");
            Console.WriteLine("5. Обчислення куба суми двох чисел");
            Console.WriteLine("6. Обчислення заданого виразу");
            Console.WriteLine("0. Вийти з програми");
            Console.Write("Ваш вибір: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalculateTriangleArea();
                    break;
                case 2:
                    CheckEvenNumber();
                    break;
                case 3:
                    CheckPointInShadedArea();
                    break;
                case 4:
                    DetermineSuit();
                    break;
                case 5:
                    CubeOfSum();
                    break;
                case 6:
                    CalculateExpression();
                    break;
                case 0:
                    Console.WriteLine("Вихід з програми...");
                    return;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }

    // 1. Обчислення площі рівностороннього трикутника
    static void CalculateTriangleArea()
    {
        Console.Write("Введіть периметр рівностороннього трикутника (p): ");
        double p = Convert.ToDouble(Console.ReadLine());
        double side = p / 3;
        double area = (Math.Sqrt(3) / 4) * Math.Pow(side, 2);
        Console.WriteLine($"Площа рівностороннього трикутника: {area:F2}");
    }

    // 2. Перевірка парності числа
    static void CheckEvenNumber()
    {
        Console.Write("Введіть ціле число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Число є парним.");
        }
        else
        {
            Console.WriteLine("Число є непарним.");
        }
    }

    // 3. Перевірка точки в області
    static void CheckPointInShadedArea()
    {
        Console.Write("Введіть координату x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть координату y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        double radius = 9;
        double distanceSquared = x * x + y * y;
        if (distanceSquared < radius * radius && x >= 0 && y >= 0)
        {
            Console.WriteLine("Так");
        }
        else if (Math.Abs(distanceSquared - radius * radius) < 1e-9 || (x == 0 && y >= 0) || (y == 0 && x >= 0))
        {
            Console.WriteLine("На межі");
        }
        else
        {
            Console.WriteLine("Ні");
        }
    }

    // 4. Визначення масті
    static void DetermineSuit()
    {
        Console.Write("Введіть номер масті (1-4): ");
        int m = Convert.ToInt32(Console.ReadLine());
        string suit = m switch
        {
            1 => "піки",
            2 => "трефи",
            3 => "бубни",
            4 => "черви",
            _ => "Невідомий номер масті"
        };
        Console.WriteLine($"Назва масті: {suit}");
    }

    // 5. Куб суми двох чисел
    static void CubeOfSum()
    {
        Console.Write("Введіть перше число: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double result = Math.Pow(a + b, 3);
        Console.WriteLine($"Куб суми чисел {a} і {b} дорівнює: {result}");
    }

    // 6. Обчислення виразу
    static void CalculateExpression()
    {
        Console.Write("Введіть ціле число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть ціле число m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        int denominator = n + m * m + 1;
        if (denominator == 0)
        {
            Console.WriteLine("Помилка: знаменник дорівнює нулю.");
            return;
        }
        double result = (3.0 / denominator + 1) * (m - n);
        Console.WriteLine($"Результат виразу: {result}");
    }
}
