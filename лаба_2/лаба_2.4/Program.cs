using System;

class Program
{
    // метод на +1
    static void plus()
    {
        num++;
    }

    // метод на -1
    static void minus()
    {
        num  --;
    }

    static int absoluteNumber = 0; // начальное число = 0 (мы его заменим)
    static int num; // запоминающая переменная

    static void Main()
    {
        Console.WriteLine("Хотите ввести первый раз число или изменить(да, не): ");
        string changingNumber = Console.ReadLine();
        Random range = new Random(); // какое-то число
        if (changingNumber == "да")
        {
            absoluteNumber = range.Next(1, 50); // absoluteNumber = от 1 до 50
        }
        num = absoluteNumber; // запоминающая переменная

        Console.WriteLine(" Увеличить значение на 1 (введите +1) \n Уменьшить значение на 1 (введите -1) \n Получить ответ (введите 0) \n"); // вывод
        
        while (true)
        {
            Console.WriteLine("Операция: ");
            string operation = Console.ReadLine(); // ответ
            switch (operation)
            {
                case "+1":
                    plus(); //  +1
                    break;
                case "-1":
                    minus(); // -1
                    break;
                default:
                    Console.WriteLine($" Начальная переменная: {absoluteNumber}  \n Получившееся значение: {num}"); // вывод что получилось
                    Environment.Exit(0); // завершение
                    break;
            }
        }
    }
}