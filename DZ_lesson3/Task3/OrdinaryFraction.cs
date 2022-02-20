using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Выполнил Андрей Срыбный
 *   Задание:
 *   3.* Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
 *       Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
 *       *    Добавить свойства типа int для доступа к числителю и знаменателю;
 *       *    Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
 *       **   Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
 *       ***  Добавить упрощение дробей.
 */
namespace Task3
{
    internal class OrdinaryFraction
    {
        public int c = 0;
        public int z = 1;

        public OrdinaryFraction(int c, int _z)
        {
            if (_z == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
           
            this.c = c;
            z = _z;

        }

        public override string ToString() //cтроковое представление override
        {
            return "(" + c.ToString() + "/" + z.ToString() + ")";
            //if ((c<0)^(z<0))              //Исключающее «или» (XOR) — в случае двух переменных результат выполнения операции истинен тогда и только тогда, когда один из аргументов истинен, а другой — ложен.
            //{
            //    c = Math.Abs(c);
            //    z = Math.Abs(z);
            //    return "(-" + c.ToString() + "/" + z.ToString() + ")";

            //}
            //else
            //{
            //    c = Math.Abs(c);
            //    z = Math.Abs(z);
            //    return "(" + c.ToString() + "/" + z.ToString() + ")";
            //}

        }

        public static OrdinaryFraction operator +(OrdinaryFraction a, OrdinaryFraction b)//сложение дробей
        {
            OrdinaryFraction t = new OrdinaryFraction(1, 1);//создание и инициализация новой дроби
            t.c = (a.c * b.z + a.z * b.c);//числитель новой дроби
            t.z = a.z * b.z;//знаменатель новой дроби
            OrdinaryFraction.SetFormat(t);//сокращаем дробь
            return t;//возвращаем результат

        }
        public static OrdinaryFraction operator -(OrdinaryFraction a, OrdinaryFraction b)//вычитание дробей
        {
            OrdinaryFraction t = new OrdinaryFraction(1, 1);//создание и инициализация новой дроби
            t.c = (a.c * b.z - a.z * b.c);//числитель новой дроби
            t.z = a.z * b.z;//знаменатель новой дроби
            OrdinaryFraction.SetFormat(t);//сокращаем дробь
            return t;//возвращаем результат

        }
        public static OrdinaryFraction operator *(OrdinaryFraction a, OrdinaryFraction b)//умножение дробей
        {
            OrdinaryFraction t = new OrdinaryFraction(1, 1);//создание и инициализация новой дроби
            t.c = (a.c * b.c);//числитель новой дроби
            t.z = a.z * b.z;//знаменатель новой дроби
            OrdinaryFraction.SetFormat(t);//сокращаем дробь
            return t;//возвращаем результат

        }
        public static OrdinaryFraction operator /(OrdinaryFraction a, OrdinaryFraction b)//деление дробей
        {
            
            OrdinaryFraction t = new OrdinaryFraction(1, 1);//создание и инициализация новой дроби
            t.c = (a.c * b.z);//числитель новой дроби
            t.z = a.z * b.c;//знаменатель новой дроби
            OrdinaryFraction.SetFormat(t);//сокращаем дробь
            return t;//возвращаем результат
        }
        //процедура по сокращению дроби
        public static OrdinaryFraction SetFormat(OrdinaryFraction a)
        {

            int max;

            //выбираем что больше числитель или знаменатель
            if (a.c > a.z)
                max = Math.Abs(a.z);//ВНИМАНИЕ! берем по модулю, что работало и с отрицательными
            else
                max = Math.Abs(a.c);//ВНИМАНИЕ! берем по модулю, что работало и с отрицательными
                                    //поиск от максимума до 2
            for (int i = max; i >= 2; i--)
            {
                //такого числа, поделив на которое бы делилось без
                //остатка и на числитель и на знаменатель
                if ((a.c % i == 0) & (a.z % i == 0))
                {
                    a.c = a.c / i;
                    a.z = a.z / i;
                }

            }
            //Определяемся со знаком
            //если в знаменателе минус, поднимаем его наверх
            if ((a.z < 0))
            {
                a.c = -1 * (a.c);
                a.z = Math.Abs(a.z);
            }
            return (a);//возращаем результат
        }
    }
}

