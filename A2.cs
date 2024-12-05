using System;

class Programm
{
    static void Main()
    {
        Console.WriteLine("Введите свой год рождения")
        string answer = Console.ReadLine();
        int year = Convert.ToInt32(answer);
        int now_year = 2024;
        int age = now_year - year;
        Console.WriteLine("Ваш возраст" + age);

    }
}