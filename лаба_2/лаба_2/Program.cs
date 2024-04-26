using System;

class Program_1
{
    static void Main()
    {
        Student student = new Student(); // Вызывает конструктор по умолчанию и присваивает ссылку. Оператор создание объектса
        Console.Write("Введите фамилию студента: ");
        student.surName = Console.ReadLine(); // ввод фамилии. объект.свойство = (запись)
        Console.Write("Введите дату рождения учащегося (гггг-мм-дд): ");
        student.dateOfBirth = DateTime.Parse(Console.ReadLine()); // ввод даты
        Console.Write("Введите номер группы студента: ");
        student.groupNumber = int.Parse(Console.ReadLine()); // ввод группы
        Console.WriteLine("Введите оценки учащегося (5 цифр, разделенных пробелом): ");
        string[] gradesInputs = Console.ReadLine().Split(' '); // ввод оценок. переменная = берёт строку.Разбивает через(' ')
        for (int i = 0; i < 5; i++) // проходится по оценкам Grades
        {
            student.evaluations[i] = int.Parse(gradesInputs[i]); // Grades[i] = в int.преобразует(из gradesInputs[i])
        }
        student.Сonclusion(); // метод вывода информации
        // функция изменения
        while (true)
        {
            Console.WriteLine("Хотите изменить данные?(да, нет)"); // ввод
            string answer = Console.ReadLine(); // ответ
            if (answer == "да")
            {
                Console.WriteLine("Введите новую фамилию для студента: "); 
                student.surName = Console.ReadLine(); // ввод фамилии
                Console.WriteLine("Введите новую дату рождения учащегося (гггг-мм-дд): "); 
                student.dateOfBirth = DateTime.Parse(Console.ReadLine()); // ввод даты
                Console.WriteLine("Введите новый номер группы для учащегося: "); 
                student.groupNumber = int.Parse(Console.ReadLine()); // ввод группы
                student.Сonclusion(); // метод вывода информации
            }
            else
            {
                return; // возврат
            }
        }
    }
}

class Student // объектный класс
{
    // свойство
    public string surName { get; set; } // фамилия. {чтение, изменения}
    public DateTime dateOfBirth { get; set; } // дата рождения
    public int groupNumber { get; set; } // номер группы
    public int[] evaluations { get; set; } = new int[5]; // оценки

    public void Сonclusion() // вывод информации 
    {
        Console.WriteLine($"Фамилия: {surName}");
        Console.WriteLine($"Дата рождения: {dateOfBirth}");
        Console.WriteLine($"Номер группы: {groupNumber}");
        Console.Write("Успеваемость: ");
        foreach (int i in evaluations)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
