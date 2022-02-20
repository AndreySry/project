/* Выполнил Андрей Срыбный
 *   Задание:
 *   3.* Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
 *       Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
 *    *    Добавить свойства типа int для доступа к числителю и знаменателю;
 *    *    Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
 *    **   Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
 *    ***  Добавить упрощение дробей.
 */
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Основная программа
            OrdinaryFraction a = new OrdinaryFraction(4, -8);//создание объекта класса OrdinaryFraction
            OrdinaryFraction b = new OrdinaryFraction(2, 5);//создание объекта класса OrdinaryFraction

            OrdinaryFraction sum;
            sum = a + b;
            OrdinaryFraction subtraction;
            subtraction = a - b;
            OrdinaryFraction multiplication;
            multiplication = a * b;
            OrdinaryFraction division;
            division = a / b;
            Console.WriteLine("Проверка на сложение: " + a.ToString() + "+" + b.ToString() + "=" + sum.ToString());
            Console.WriteLine("Проверка на вычитание: " + a.ToString() + "-" + b.ToString() + "=" + subtraction.ToString());
            Console.WriteLine("Проверка на умножение: " + a.ToString() + "*" + b.ToString() + "=" + multiplication.ToString());
            Console.WriteLine("Проверка на деление: " + a.ToString() + "/" + b.ToString() + "=" + division.ToString());
            Console.ReadKey();

        }


    }
}