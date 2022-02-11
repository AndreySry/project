#region Выполнил
//Андрей Срыбный
#endregion
#region Задание
/*
 3.	а) Написать программу, которая подсчитывает расстояние между точками
       с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)). 
       Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);

    б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.


 */
#endregion
using System;
class Program
{
    static void Pause()                   
    {
        Console.ReadKey();
    }

    static double Distance (double x1, double x2, double y1, double y2)
    {
        double dis = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return dis;
    }

    
    static void Main(string[] args)
    {
        #region заданные
        double x1 = 1;
        double x2 = 3;
        double y1 = 1;
        double y2 = 3;
        double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"a) расстояние между точкам с координатами x1, y1 и x2, y2: {r:f2}");
        Console.WriteLine($"б) расстояние между точкам с координатами x1, y1 и x2, y2: {Distance(x1, x2, y1, y2):f2}");
        #endregion

        #region Вводимые
        Console.Write("Введите x1:");
        x1 = double.Parse(Console.ReadLine());
        Console.Write("Введите x2:");
        x2 = double.Parse(Console.ReadLine());
        Console.Write("Введите y1:");
        y1 = double.Parse(Console.ReadLine());
        Console.Write("Введите y2:");
        y2 = double.Parse(Console.ReadLine());
        r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"a) расстояние между точкам с координатами x1, y1 и x2, y2: {r:f2}");
        Console.WriteLine($"б) расстояние между точкам с координатами x1, y1 и x2, y2: {Distance(x1, x2, y1, y2):f2}");
        Pause();
        #endregion


    }
}