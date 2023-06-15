using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        Console.WriteLine("Введіть п'ять чисел:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        int max = numbers[0];
        int min = numbers[0];

        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }

            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        int product = 1;
        foreach (int num in numbers)
        {
            product *= num;
        }

        Console.WriteLine($"Сума чисел: {sum}");
        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Минимум: {min}");
        Console.WriteLine($"Добуток чисел: {product}");

        Console.ReadLine();
    }
}

