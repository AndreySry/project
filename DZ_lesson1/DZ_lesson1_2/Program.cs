#region Выполнил
//Андрей Срыбный
#endregion
#region Задание
/*
 * 2.	Ввести вес и рост человека. 
 * Рассчитать и вывести индекс массы тела (ИМТ)
 * по формуле I=m/(h*h); где m — масса тела в килограммах, 
 *                           h — рост в метрах.

 */
#endregion
using System;
class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Введите ваш рост в метрах");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите ваш вес в килограммах");
        double weight = double.Parse(Console.ReadLine());
        double imt = weight / (height * height);
        Console.WriteLine($"индекс массы тела (ИМТ): {imt}");
        Console.ReadKey();
    }
}