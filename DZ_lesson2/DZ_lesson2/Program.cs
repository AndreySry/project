using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    static void Autor()
    {
        
        Console.Title = "Андрей Срыбный (c)";
        Console.ForegroundColor = ConsoleColor.Green;
       
    }
    static void Pause()
    {
        Console.WriteLine("press any key");
        Console.ReadKey();        
    }

    static void Task1()
    {
        Console.WriteLine(" Задача1. Написать метод, возвращающий минимальное из трёх чисел.");
        Console.WriteLine("Введите первое число");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите третье число");
        double c = double.Parse(Console.ReadLine());
        static double MinminimumOfThree(double a, double b, double c)
        {
            double min;
            if (a < b)
            {
                if (a < c)
                {
                    min = a;
                }
                else
                {
                    min = c;
                };
            } 
            else 
            {
                if (c < b)
                {
                    min = c;
                }
                else
                {
                    min = b;
                };
            };
            return min;

        };
        Console.WriteLine($"Из чисел {a}, {b}, {c} минимальным является: " + MinminimumOfThree(a,b,c));
        Pause();

    }

    static void Task2()
    {

        Console.WriteLine("Задача 2. Написать метод подсчета количества цифр числа.");
        Console.WriteLine("Введите число в котором хотите подсчетать количество цифр");
        string number = Console.ReadLine();

        static int NumberOfDigits(string number)
        {
            
            int numberOfDigits = number.Length;
            
            return numberOfDigits;
        }
        Console.WriteLine($"В данном числе {number} количество цифр равно: " + NumberOfDigits(number));
        Pause();
    }

    static void Task3()
    {

        Console.WriteLine("Задача 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
        Console.WriteLine("Введите числа. Для окончания ввода - ведите 0.");
        int numb =int.Parse(Console.ReadLine());
        int sum =0;
        while (numb != 0)
        {
            
            if ((numb%2 != 0)&(numb > 0))
            {
                sum = sum + numb;
            }
            numb = int.Parse(Console.ReadLine());
        }
  
        Console.WriteLine($"Сумма всех нечетных положительных чисел равно: {sum} ");
        Pause();
    }

    static void Task4()
    {
        string login;
        string password;
        static bool Authorization(string login, string password) => (login == "root") & (password == "GeekBrains");
        int n = 3;
        Console.WriteLine("Задача 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.");
        Console.WriteLine("На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).");
        Console.WriteLine("Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.");
        Console.WriteLine("С помощью цикла do while ограничить ввод пароля тремя попытками.");
        do
        {
            Console.WriteLine($"у вас осталось попыток: {n}");
            Console.WriteLine("Введите логин");
            login = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            password = Console.ReadLine();
            n = n - 1;

        } while ((Authorization(login, password) == false)&(n > 0));

        var message = Authorization(login, password)? "Поздравляю! Вы прошли авторизацию" : "Авторизация не пройдена";
        Console.WriteLine(message);

        if (Authorization(login, password))
        {
            Console.WriteLine("Поздравляю! Вы прошли авторизацию");
        }
        else
        {
            Console.WriteLine("Авторизация не пройдена");
        };
        Pause();
    }
   
    static void Task5()
    {

        Console.WriteLine("Задача 5.");
        Console.WriteLine("а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс");
        Console.WriteLine("массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.");
        Console.WriteLine("б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");
        Console.WriteLine("Введите ваш рост в метрах");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите ваш вес в килограммах");
        double weight = double.Parse(Console.ReadLine());
        double imt = weight / (height*height);
        double weightminnormimt = 18.5 * height * height;
        double weightmaxnormimt = 25 * height * height;
        Console.WriteLine($"Индекс массы тела равен {imt:f2}");

        if (imt > 25)
        {
            double loseweight = weight - weightmaxnormimt;
            Console.WriteLine($"Вес выше нормы. Вам нужно похудеть миниму на {loseweight:f2} кг");
           
        }
        else
        {
            if (imt < 18.5)
            {
                double togainweight = weightminnormimt - weight;
                Console.WriteLine($"Вес ниже нормы. Вам нужно набрать миниму {togainweight:f2} кг");
            }
            else
            {
                Console.WriteLine( "Вес в норме");
            };
        };
        Pause();
    }
   
    static void Task6()
   {
        DateTime start = DateTime.Now;
        string number;
        int sumofgoodnumbers = 0;
        Console.WriteLine("Задача 6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.");
        Console.WriteLine("«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.");
        static int TheSumOfTheDigitsInANumber(string number)
        {
            int summ = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsNumber(number[i]))
                {

                    summ += Convert.ToInt32(number[i].ToString());
                }
            }
            return summ;
        }
       
       
       for (int i = 1; i <= 1000000000; i++)
       {
           number = Convert.ToString(i);
        

            if (i % TheSumOfTheDigitsInANumber(number) == 0)
            {
                sumofgoodnumbers++;
                
            }
           
       }
        Console.WriteLine($"количество «хороших» чисел в диапазоне от 1 до 1 000 000 000 составляет: {sumofgoodnumbers}");
        DateTime finish = DateTime.Now;
        TimeSpan timeSpan = finish - start;
        Console.WriteLine($"время выполнения программы составляет: ");
        Console.WriteLine(timeSpan.TotalSeconds + " секунд");
        Pause();
    }
    
    static void Task7()
      {

          Console.WriteLine("Задача 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).");
          Console.WriteLine("б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.");

          Console.WriteLine("Введите число a");
          int a = int.Parse(Console.ReadLine());
          Console.WriteLine("Введите число b");
          int b = int.Parse(Console.ReadLine());
          int sum=0;

        static void RecursiveOutputOnDisplay (int a, int b)                   
        {
            if (a < b-1)
            {
                ++a;
                Console.Write (a + " ");
                RecursiveOutputOnDisplay(a, b);
            }
        }

        static int RecursiveSum(int a, int b)                    
        {
            if (a == b)                                 
                return 0;                              
            else return a + RecursiveSum(a +1, b);   
        }

        RecursiveOutputOnDisplay(a, b);

        Console.WriteLine($" Сумма чисел от {a} до {b} равна {RecursiveSum(a, b)}");
        Pause();

    }
    
    static void Task6a()
    {
        DateTime start = DateTime.Now;
        int sumofgoodnumbers = 0;
        int a;
        Console.WriteLine("Задача 6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.");
        Console.WriteLine("«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.");
        

        static int Sum(int a)               // нерекурсивный метод
        {
            int s = 0;
            while (a > 0)                  // пока a больше нуля
            {
                s = s + a % 10;          // добавляем к сумме последнюю цифру числа а
                a = a / 10;              // отбрасываем от числа а последнюю цифру
            }
            return s;                     // возвращаем в качестве результата сумму цифр числа a
        }



        for (int i = 1; i <= 1000000000; i++)
        {
            a = i;


            if (i % Sum(a) == 0)
            {
                sumofgoodnumbers++;

            }

        }
        Console.WriteLine(sumofgoodnumbers);
        DateTime finish = DateTime.Now;
        TimeSpan timeSpan = finish - start;
        Console.WriteLine($"время выполнения программы составляет: ");
        Console.WriteLine(timeSpan.TotalSeconds + " секунд");
        Pause();
    }
    
    static void Task6b()
    {
        DateTime start = DateTime.Now;
        int a;
        int sumofgoodnumbers = 0;
        Console.WriteLine("Задача 6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.");
        Console.WriteLine("«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.");
       

        static int RecursiveSum(int a)                  // рекурсивный метод
        {
            if (a == 0)                                  // если a =0
                return 0;                                // возвращаем 0
            else return RecursiveSum(a / 10) + a % 10;   // иначе вызываем рекурсивно сами себя
        }



        for (a = 1; a <= 1000000000; a++)
        {
            


            if (a % RecursiveSum(a) == 0)
            {
                sumofgoodnumbers++;

            }

        }
        Console.WriteLine(sumofgoodnumbers);
        DateTime finish = DateTime.Now;
        TimeSpan timeSpan = finish - start;
        Console.WriteLine($"время выполнения программы составляет: ");
        Console.WriteLine(timeSpan.TotalSeconds + " секунд");
        Pause();
    }
    

    static void Main() 
    {
        int taskNumber;
         do
         {
             Autor();
             Console.WriteLine("для просмотра задачи 1 - введите с клавиатуры цифру 1");
             Console.WriteLine("для просмотра задачи 2 - введите 2");
             Console.WriteLine("для просмотра задачи 3 - введите 3");
             Console.WriteLine("для просмотра задачи 4 - введите 4");
             Console.WriteLine("для просмотра задачи 5 - введите 5");
             Console.WriteLine("для просмотра задачи 6 - введите 6");
             Console.WriteLine("для просмотра задачи 7 - введите 7");
             Console.WriteLine("для просмотра задачи 6a - введите 8");
             Console.WriteLine("для просмотра задачи 6b - введите 9");
             Console.WriteLine("для завершения просмотра  - введите 0");
             Console.WriteLine("    Задачи 6a, 6b это решение задачи 6, с использованием методов нахождения суммы своих цифр из методички.\n6a с использованием цикла while. 6b - рекурсией.\nВремя выполнения на моей системе:\n6 ~630sec;\n6a ~110sec;\n6b ~120sec(при использовании переменных типа int) и ~231sec(при использовании переменных типа long).");
            taskNumber = int.Parse(Console.ReadLine());
             Console.Clear();
             switch (taskNumber)
             {
                 case 0:
                     break;
                 case 1:
                     Task1();
                     break;
                 case 2:
                     Task2();
                     break;
                 case 3:
                     Task3();
                     break;
                 case 4:
                     Task4();
                     break;
                 case 5:
                     Task5();
                     break;
                 case 6:
                     Task6();
                     break;
                 case 7:
                     Task7();
                     break;
                case 8:
                    Task6a();
                    break;
                case 9:
                    Task6b();
                    break;
                default:
                     break;
             }
             Console.Clear();

         } while (taskNumber != 0);
      
        
    }
}