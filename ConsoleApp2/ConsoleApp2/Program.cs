using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string role = "";
        bool isAuthenticated = false;

        while (!isAuthenticated)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Меню авторизации");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Войти");
            Console.WriteLine("2. Выход");
            Console.Write("Выберите опцию: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("dsada");
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }

        if (isAuthenticated)
        {
            switch (role)
            {
                case "admin":
                    ShowAdminMenu();
                    break;
                case "user":
                    ShowUserMenu();
                    break;
            }
        }
    }

    static string Login()
    {
        Console.Write("Введите имя пользователя: ");
        string username = Console.ReadLine();
        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        try
        {
            string[] lines = File.ReadAllLines("users.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');
                if (parts.Length == 3 && parts[0] == username && parts[1] == password)
                {
                    return parts[2]; // Возвращаем должность (роль)
                }
            }

            Console.WriteLine("Неверное имя пользователя или пароль.");
            return "";
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл с учетными данными не найден!");
            return "";
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
            return "";
        }
    }

    static void ShowAdminMenu()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("Меню администратора");
        Console.WriteLine("------------------------");
        Console.WriteLine("1. Добавить пользователя");
        Console.WriteLine("2. Удалить пользователя");
        Console.WriteLine("3. Выход");

        string command = Console.ReadLine();
        if (command =="3")
        {
            Environment.Exit(0); 
           
        }
        

        if (command == "1")
        {
            //command
        }


    }

    static void ShowUserMenu()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("Меню пользователя");
        Console.WriteLine("------------------------");
        Console.WriteLine("1. Просмотреть данные");
        Console.WriteLine("2. Изменить данные");
        Console.WriteLine("3. Выход");
        // ... Другие функции пользователя
    }
}
