using System;

class MainClass
{
    public static void Main(string[] args)
    {
        
        PrintUser(AddUser());
    }
    static int ReadNumber(bool zero_is_allow, string message)   // Чтения числа с клавиатуры, проверка корректности ввода
    {
        int result = 0;
        bool correct = false;
        
        do
        {
            Console.WriteLine(message);
            if (int.TryParse(Console.ReadLine(), out result))
            {
                if (result > 0)
                {
                    correct = true;
                }
                if ((zero_is_allow == true) && (result == 0))
                {
                    correct = true;
                }
            }
        } while (correct == false);
        return result;
    }
    static string ReadString(string message)                    // Чтения имени/названия с клавиатуры, проверка корректности ввода
    {
        string result;
        bool correct = false;

        do
        {
            Console.WriteLine(message);
            result = Console.ReadLine();
            if ((result != null) && (result != ""))
            {
                correct = true;
            }
        } while (correct == false);
        return result;
    }
    static string[] CollectNames(int size, string message)      // Сборка массива из имён/названий
    {
        string[] result = new string[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = ReadString(String.Format("{0}{1}",message, i + 1));
        }

        return result;
    }
    static (string name_first, string name_last, int age, string[] pet_list, string[] color_list) AddUser()              //Добавление нового пользователя
    {
        (string name_first, string name_last, int age, string[] pet_list, string[] color_list) User =
            ("", "", 0,new string[]{}, new string[] {});


        User.name_first = ReadString("Введите своё имя: ");
        User.name_last = ReadString("Введите свою фамилию: ");
        
        User.age = ReadNumber(false, "Введите свой возраст в годах цифрами: ");

        int number = ReadNumber(true, "Количество питомцев: ");
        if (number > 0)
        {
            User.pet_list = CollectNames(number, "Введите кличку питомца номер ");
        }

        number = ReadNumber(true, "Количество количество любимых цветов: ");
        if (number > 0)
        {
            User.color_list = CollectNames(number, "Введите любимый цвет номер ");
        }
        return User;
    }
    static void PrintUser((string name_first, string name_last, int age, string[] pet_list, string[] color_list) User)  //Вывод информации по пользователю
    {
        Console.WriteLine($"Имя пользователя: {User.name_first} {User.name_last}\n");
        Console.WriteLine($"Возраст пользователя: {User.age}\n");
        if(User.pet_list.Length > 0)
        {
            Console.WriteLine($"Всего у пользователя {User.pet_list.Length} домашних животных. Их клички приведены ниже");
            for (int i = 0; i < User.pet_list.Length; i++)
            {
                Console.WriteLine($"\t{User.pet_list[i]}");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"У пользователя нет домашних животных");
        }
        if (User.color_list.Length > 0)
        {
            Console.WriteLine($"Всего у пользователя {User.color_list.Length} любимых цветов. Их названия приведены ниже");
            for (int i = 0; i < User.color_list.Length; i++)
            {
                Console.WriteLine($"\t{User.color_list[i]}");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"У пользователя нет любимых цветов");
        }
    }
}