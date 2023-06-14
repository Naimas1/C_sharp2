using System.Drawing;
using System.Text;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть число:");
        double number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть відсоток:");
        double percentage = Convert.ToDouble(Console.ReadLine());

        double result = number * (percentage / 100);

        Console.WriteLine($"Результат: {result}");
    }
}

