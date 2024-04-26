using System;

class Program 
{ 
    public float age { get; set; } // возраст 
    public string name { get; set; } // имя

    // Конструктор с входными параметрами
    public Program(float age, string name)    
    {
        this.age = age; // присвоить age        
        this.name = name; // присвоить name
    }

    // Конструктор свойств по умолчанию    
    public Program()
    {
        this.age = 0; // присвоить age = 0
        this.name = "Null"; // присвоить name = Null
    }

    // Деструктор = специальная функция-член класса, которая автоматически вызывается при уничтожении объекта
    ~Program()    
    {
        Console.WriteLine("Удалено");
    }

    // вывод
    public void ConclusionInformation()    
    {
        Console.WriteLine($"Возраст: {age}, Имя: {name}"); // вывод
    }  
}

class Conclusion
{
    static void Main()    
    {
        Console.WriteLine("Введите возраст:");    
        float age1 = float.Parse(Console.ReadLine()); // данные
        Console.WriteLine("Введите имя: ");   
        string name1 = Console.ReadLine(); // данные
        
        Console.WriteLine("\nСоздание объекта с входными параметрами:");
        Program program1 = new Program(age1, name1); // принимающий Program        
        program1.ConclusionInformation(); // вывод
        
        Console.WriteLine("\nСоздание объекта, инициализирующего свойства по умолчанию");
        Program program2 = new Program(); // пустой Program        
        program2.ConclusionInformation(); // вывод
        
        GC.Collect(); // отчистка 
        Console.WriteLine("\nВведите enter");
        Console.Read(); // задержка через Enter

        Console.WriteLine("Удалено"); // вывод
    }
}