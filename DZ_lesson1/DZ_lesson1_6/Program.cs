#region Выполнил
//Андрей Срыбный
#endregion
#region Задание
/*
 * 6.	*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

 */
#endregion
using System;
class Program
{
    static void Pause()                   
    {
        Console.ReadKey();
    }
    static void Print(string msg, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(msg);
    }


    static void Main(string[] args)
    {
        
    }
}
