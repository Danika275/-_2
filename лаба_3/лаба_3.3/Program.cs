class Program
{
    static void Main()
    {
        Calculation calculation = new Calculation(); // Создаем Calculation
        
        calculation.SetCalculationLine("Мишка барни"); //  Исходное значение для CalculationLine
        Console.WriteLine($"Начальная строка: {calculation.GetCalculationLine()}");
        
        calculation.SetLastSymbolCalculationLine('*'); // Добавляем символ звездочки в конец
        Console.WriteLine($"Строка и символ: {calculation.GetCalculationLine()}");
        
        char symbolLast = calculation.GetLastSymbol(); //  Последниц символ 
        Console.WriteLine($"Последний символ: {symbolLast}");
        
        calculation.DeleteLastSymbol(); // Удаляем последний символ 
        Console.WriteLine($"Строка - символ: {calculation.GetCalculationLine()}");
    }
}

public class Calculation
{
    private string _calculationLine;

    // Свойство CalculationLine для доступа к _calculationLine
    public string CalculationLine
    {
        get { return _calculationLine; }
        set { _calculationLine = value; }
    }

    // Метод устанавливает новое значение для CalculationLine
    public void SetCalculationLine(string newCalculationLine)
    {
        CalculationLine = newCalculationLine;
    }

    //методы
    
    // SetLastSymbolCalculationLine добавляет новый символ в конец 
    public void SetLastSymbolCalculationLine(char symbol)
    {
        CalculationLine += symbol;
    }

    // GetCalculationLine возвращает текущее значение
    public string GetCalculationLine()
    {
        return CalculationLine;
    }

    // GetLastSymbol возвращает последний символ
    public char GetLastSymbol()
    {
        return CalculationLine[CalculationLine.Length - 1];
    }

    // DeleteLastSymbol удаляет последний символ (звездочку__)
    public void DeleteLastSymbol()
    {
        CalculationLine = CalculationLine.Substring(0, CalculationLine.Length - 1);
    }
}