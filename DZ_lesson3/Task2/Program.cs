/*Выполнил Андрей Срыбный
 * Задание:
 * 2. С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
 * Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
 */
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        string message = "Введите число:";
        int x;
        string s;
        bool flag;       
        do
        {
            Console.WriteLine(message);
            s = Console.ReadLine();
            flag = int.TryParse(s, out x);
            if (flag)
            {
                if ((x>=0)&(x%2!=0))
                {
                    sum += x;
                }
            }
            else
            {
                x = 2;
                Console.WriteLine("Вводите только числа");
            }
        }
        while (x != 0);
        Console.WriteLine($"Cумма всех нечётных положительных чисел равна: {sum}");
    }
}
