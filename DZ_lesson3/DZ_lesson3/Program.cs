/*Выполнил: Андрей Срыбный
 * Задание:
 * 1 в) Добавить диалог с использованием switch демонстрирующий работу класса.
 */
using System;
namespace DZ_lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Описали ссылку на объект.
            Complex complex1;
            // Создали объект и сохранили ссылку на него в complex1.
            complex1 = new Complex(1, 1);
            // Описали объект и создали его.
            Complex complex2 = new Complex(2, 2);
            // С помощью свойства Im изменили внутреннее (приватное) поле im.
            complex2.Im = 3;
            // Создали ссылку на объект.
            Complex result;
            static void Pause()
            {
                Console.WriteLine("press any key");
                Console.ReadKey();
            }


            int taskNumber;
            do
            {
                Console.WriteLine("для просмотра сложения комплексных чисел - введите с клавиатуры цифру 1");
                Console.WriteLine("для просмотра вычитания комплексных чисел - введите 2");
                Console.WriteLine("для просмотра умножение комплексных чисел - введите 3");
                Console.WriteLine("для просмотра деление комплексных чисел - введите 4");
                Console.WriteLine("для завершения просмотра  - введите 0");
                taskNumber = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (taskNumber)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine($"Первое комплексное число: {complex1.ToString()}");
                        Console.WriteLine($"Второе комплексное число: {complex2.ToString()}");
                        result = complex1.Plus(complex2);
                        Console.WriteLine($"Результат сложения: {result.ToString()}");
                        Pause();
                        break;
                    case 2:
                        Console.WriteLine($"Первое комплексное число: {complex1.ToString()}");
                        Console.WriteLine($"Второе комплексное число: {complex2.ToString()}");
                        result = complex1.Minus(complex2);
                        Console.WriteLine($"Результат вычитания: {result.ToString()}");
                        Pause();
                        break;
                    case 3:
                        Console.WriteLine($"Первое комплексное число: {complex1.ToString()}");
                        Console.WriteLine($"Второе комплексное число: {complex2.ToString()}");
                        result = complex1.Multiplication(complex2);
                        Console.WriteLine($"Результат умножения: {result.ToString()}");
                        Pause();
                        break;
                    case 4:
                        Console.WriteLine($"Первое комплексное число: {complex1.ToString()}");
                        Console.WriteLine($"Второе комплексное число: {complex2.ToString()}");
                        result = complex1.Division(complex2);
                        Console.WriteLine($"Результат деления: {result.ToString()}");
                        Pause();
                        break;
                    
                    default:
                        break;
                }
                Console.Clear();

            } while (taskNumber != 0);
        }
    }

}

