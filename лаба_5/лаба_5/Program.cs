namespace GarageConsoleApp;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Просмотреть типы машин - 1");
        Console.WriteLine("Добавить типы машин - 2");
        Console.WriteLine("Просмотреть водителей - 3");
        Console.WriteLine("Добавить водителей - 4");
        Console.WriteLine("Просмотреть права - 5");
        Console.WriteLine("Добавить права - 6");
        Console.WriteLine("Просмотреть машин - 7");
        Console.WriteLine("Добавить машин - 8");
        Console.WriteLine("Просмотреть маршруты - 9");
        Console.WriteLine("Добавить маршруты - 10");
        Console.WriteLine("Просмотреть рейсы - 11");
        Console.WriteLine("Добавить рейсы - 12");
        

        switch (Console.ReadLine())
        {
            case "1":
                DatabaseRequests.GetTypeCarQuery();
                break;
            
            case "2":
                DatabaseRequests.AddTypeCarQuery();
                break;
            
            case "3":
                DatabaseRequests.AddDriverQuery();
                break;
            
            case "4":
                DatabaseRequests.GetDriverQuery();
                break;
            
            case "5":
                DatabaseRequests.AddRightsCategoryQuery();
                break;
            
            case "6":
                DatabaseRequests.AddDriverRightsCategoryQuery();
                break;
            
            case "8":
                DatabaseRequests.GetDriverRightsCategoryQuery();
                break;
            
            case "9":
                DatabaseRequests.GetCarQuery();
                break;
            
            case "10":
                DatabaseRequests.AddCarQuery();
                break;
            
            case "11":
                Console.WriteLine("Введите название маршрута: ");
                DatabaseRequests.AddItinerary(Console.ReadLine());
                break;
            
            case "12":
                DatabaseRequests.GetRoute();
                break;
            
            case "13":
                int idDriver = int.Parse(Console.ReadLine());
                int idCar = int.Parse(Console.ReadLine()); 
                int idCar = int.Parse(Console.ReadLine()); 
                DatabaseRequests.AddRoute(idDriver, idCar, idItinerary, );
                break;
        }
    }
}