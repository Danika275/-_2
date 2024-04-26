using System; 

class NumberAndData 
{ 
    public int Num1 { get; set; } // первое число
    public int Num2 { get; set; } // и второе число

    public void Сonclusion() // вывод 
    { 
        Console.WriteLine($"Первое число: {Num1} \n Второе число: {Num2}"); 
        Console.WriteLine($"Сумма чисел: {SumNums()}"); // сумма чисел 
        Console.WriteLine($"Максимальное число: {MaxNum()}"); // max 
    }

    public void ChangeNumbers(int num1, int num2) // изменение чисел  
    { 
        Num1 = num1;
        Num2 = num2;
    }

    public int SumNums() // сумма
    { 
        return Num1 + Num2;
    }

    public int MaxNum() // максимальное
    { 
        return Math.Max(Num1, Num2);
    }
} 

class Program  
{ 
    static void Main() 
    { 
        NumberAndData numberAndData = new NumberAndData(); // ссылка 
        while(true)
        { 
            Console.WriteLine($" Чтобы ввести первый раз число или изменить, введите: 1 \n Чтобы вывести сумму чисел, введите: 2 \n Чтобы вывести максимальное число, введите: 3 \n Закончить: 0"); 
            int answer = int.Parse(Console.ReadLine()); // ответ 
             
            if(answer == 1) //вывод при 1
            { 
                Console.Write("Введите первое число: "); // вывод 
                int num1 = int.Parse(Console.ReadLine()); // ввод числа 
                Console.Write("Введите второе число: ");
                int num2 = int.Parse(Console.ReadLine()); 
                numberAndData.ChangeNumbers(num1, num2);
                Console.WriteLine(); // разделитель
            } 
            else if(answer == 2) 
            { 
                Console.WriteLine($"Сумма чисел: {numberAndData.SumNums()}"); //вывод при 2
            } 
            else if(answer == 3) 
            { 
                Console.WriteLine($"Максимальное число: {numberAndData.MaxNum()}"); //вывод при 3
            } 
            else 
            { 
                return; 
            } 

            numberAndData.Сonclusion(); // вывод и усе
        } 
    } 
}
