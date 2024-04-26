using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа через пробел: ");
        string nums = Console.ReadLine();
        string[] numsArray = nums.Split(' '); //разделение чисел пробелом
        
        bool repeatNum = false;
        foreach (var num in numsArray)
        {
            int count = 0;
            foreach (var innerNum in numsArray)
            {
                if (num == innerNum)
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                repeatNum = true;
                break; // Если значение повторяется больше или равно дважды, завершаем цикл
            }
        }

        if (repeatNum)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false"); 
        }
    }
}