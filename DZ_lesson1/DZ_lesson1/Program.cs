#region Выполнил
//Андрей Срыбный
#endregion
#region Задание
/*
 * 1.	Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
    а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $.

 */
#endregion
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше имя");
        string? name = Console.ReadLine();
        Console.WriteLine("Введите вашу фамилию");
        string? surname = Console.ReadLine();
        Console.WriteLine("Введите ваш возраст");
        string? age = Console.ReadLine();
        Console.WriteLine("Введите ваш рост");
        string? height = Console.ReadLine();
        Console.WriteLine("Введите ваш вес");
        string? weight = Console.ReadLine();
        Console.WriteLine("Имя: "+name+" Фамилия: "+surname+" Возраст: "+age+" Рост: "+height+" Вес:"+weight);            // а) используя  склеивание
        Console.WriteLine("ИМЯ: {0} ФАМИЛИЯ: {1} ВОЗРАСТ: {2} РОСТ: {3} ВЕС: {4}", name, surname, age, height, weight);   // б) используя форматированный вывод
        Console.WriteLine($"||имя {name} ||фамилия {surname} ||возраст {age} ||рост {height} ||вес {weight}");            // в) используя вывод со знаком $
        Console.ReadKey();
    }
}