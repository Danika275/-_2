class Worker
{
    public string name;
    public string surname;
    public string rate; 
    public int days;

    // конструктор
    public Worker(string name, string surname, string rate, int days)
    {
        this.name = name;
        this.surname = surname;
        this.rate = rate;
        this.days = days;
    }

    // Зарплата
    public void GetSalary()
    {
        int money = 0;  // счётчик обнуляем
        switch (rate)
        {
            case "Репетитор":
                money = 1500; // любая зп
                break;
            case "Переводчик":
                money = 2000;
                break;
            case "Ведущий тревл шоу":
                money = 14000;
                break;
            default:
                break;
        }

        Console.WriteLine($"Зарплата {name} {surname} составляет {money * days}"); // произведение ставки rate на количество отработанных дней days
    }

    static void Main()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите фамилиюа: ");
        string surname = Console.ReadLine();

        Console.Write("Введите должность (Репетитор/Переводчик/Ведущий тревл шоу): ");
        string rate = Console.ReadLine();

        Console.Write("Введите количество отработанных дней: ");
        int days = int.Parse(Console.ReadLine());

        Worker worker = new Worker(name, surname, rate, days); // вызов конструктора
        worker.GetSalary(); // расчёт Зарплаты и вывод
    }
}