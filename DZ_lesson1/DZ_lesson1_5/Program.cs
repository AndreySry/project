#region Выполнил
//Андрей Срыбный
#endregion
#region Задание
/*
 *  а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    б) *Сделать задание, только вывод организовать в центре экрана.
    в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).


 */
#endregion
using System;
class Program
{
    static void СenteredText(string text)
    {
        Console.Clear();
        int centerX = (Console.WindowWidth / 2) - (text.Length / 2);
        int centerY = (Console.WindowHeight / 2) - 1;
        Console.SetCursorPosition(centerX, centerY);
        Console.Write(text);
    }
    static void Pause()
    {
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        СenteredText("Андрей Срыбный Приалейск сити");
        Pause();
    }
}
