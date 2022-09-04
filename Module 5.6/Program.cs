using System;

class MainClass
{
    public static void Main(string[] args)
    {


    }

    static (string name_first, string name_last, int age, int pet_number, string[] pet_list, int color_number, string[] color_list) AddUser()
    {
        (string name_first, string name_last, int age, int pet_number, string[] pet_list, int color_number, string[] color_list) User;

        Console.WriteLine("Введите своё имя: ");
        User.name_first = Console.ReadLine();






        /*


        int number;

        bool success = int.TryParse(value, out number);
        if (success)
        {
            Console.WriteLine($"Converted '{value}' to {number}.");
        }
        else
        {
            Console.WriteLine($"Attempted conversion of '{value ?? "<null>"}' failed.");
        }
        */
        return User;
    }
}