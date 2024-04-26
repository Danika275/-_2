class Program
{
    // римская цифра = арабская цифраа
    static int TranslatingNumbers(char roman)
    {
        switch (roman)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }

    static void Main()
    {
        Console.WriteLine("Введите римское число (английский алф): "); 
        string line = Console.ReadLine(); // число на римском
        char[] romanNum = line.ToCharArray(); // переводим это в массив
        int arabicNum = 0; // арабское число
        
        for (int i = 0; i < romanNum.Length; i++) // перебераем
        {
            int Value = TranslatingNumbers(romanNum[i]); // переменная это число (по индексу)
            
            if (i + 1 < romanNum.Length && TranslatingNumbers(romanNum[i + 1]) > Value)
            {
                arabicNum -= Value;
            }
            else
            {
                arabicNum += Value; 
            }
        }
        Console.WriteLine($"Арабское число получилось: {arabicNum}");
    }
}
