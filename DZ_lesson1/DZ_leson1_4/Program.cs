#region Выполнил
//Андрей Срыбный
#endregion
#region Задание
/*
 4.	Написать программу обмена значениями двух переменных:
    а) с использованием третьей переменной;
	б) *без использования третьей переменной.

 */
#endregion
using System;
class Program
{
   
    static void Main(string[] args)
    {
        // с использованием третьей переменной;
        int a = 24;
        int b = 52;
        int с = a;
        Console.WriteLine($"a={a}, b={b}");
        a = b;
        b = с;
        Console.WriteLine($"a={a}, b={b}");
        // б) *без использования третьей переменной.
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"a={a}, b={b}");
    }

}