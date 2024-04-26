using System;

class Train
{
    public string[] nameOfTheDestination = { "Ялта", "Челябинск", "Тангберра" }; // города
    public int[] trainNumber = { 235, 767, 430 }; // номера поездов
    public TimeSpan[] departureTime = { TimeSpan.Parse("10:10:10"), TimeSpan.Parse("06:00:00"), TimeSpan.Parse("13:45:00") }; // время отправления

    public void ShowTrainInfo(int userInputTrainNumber)
    {
        int index = Array.IndexOf(trainNumber, userInputTrainNumber);
        if (index != -1)
        {
            Console.WriteLine($"Информация о поезде с номером {userInputTrainNumber}:");
            Console.WriteLine($"Название пункта назначения: {nameOfTheDestination[index]}");
            Console.WriteLine($"Номер поезда: {trainNumber[index]}");
            Console.WriteLine($"Время отправления вашего поезда: {departureTime[index]}");
        }
        else
        {
            Console.WriteLine(":(");
        }
    }
}

class Program
{
    static void Main()
    {
        Train train = new Train();
        Console.Write("Введите номер поезда, из предложенных (235, 767, 430) информацию о котором хотите узнать: ");
        int InputTrainNumber;
        if (int.TryParse(Console.ReadLine(), out InputTrainNumber))
        {
            train.ShowTrainInfo(InputTrainNumber);
            Console.WriteLine("Спасибо, что выбрали нашу компанию!");
        }
        else
        {
            Console.WriteLine("Такого поезда неть :(");
        }
    }
}