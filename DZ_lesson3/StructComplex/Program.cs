using System;
/*Выполнил Андрей Срыбный
 * Задание:
 * 1.	а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
 */
struct Complex
{
    public double im;
    public double re;
    //  в C# в структурах могут храниться также действия над данными
    public Complex Plus(Complex x)
    {
        Complex y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }
    //  Пример произведения двух комплексных чисел
    public Complex Multi(Complex x)
    {
        Complex y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }
    public string ToString()
    {
        return re + "+" + im + "i";
    }
    // а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
    public Complex Minus(Complex x)
    {
        Complex y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }
    //
}
class Program
{
    static void Main(string[] args)
    {
        Complex complex1;
        complex1.re = 1;
        complex1.im = 1;

        Complex complex2;
        complex2.re = 2;
        complex2.im = 2;

        Complex result = complex1.Plus(complex2);
        Console.WriteLine(result.ToString());
        result = complex1.Multi(complex2);
        Console.WriteLine(result.ToString());
        result = complex1.Minus(complex2);
        Console.WriteLine(result.ToString());



    }
}
