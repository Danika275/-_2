using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первую строку:");
        string J = Console.ReadLine();

        Console.WriteLine("Введите вторую строку:");
        string S = Console.ReadLine();

        int count = 0;
        foreach (char i in S)
        {
            if (J.Contains(i))
            {
                count++;
            }
        }

        Console.WriteLine($"Камней, являющихся драгоценностями: {count}");
    }
}