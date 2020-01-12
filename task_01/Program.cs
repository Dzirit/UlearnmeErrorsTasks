using System;
using System.Diagnostics;
using System.Threading;
//Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5
/*Число n называется кратным некоторому натуральному числу p, 
 если оно нацело делится на p. При этом говорят что n кратно p.
 Признак делимости на 2.

Число делится на 2, если его последняя цифра есть число четное (то есть 2, 4, 6, 8) или 0.

Признак делимости на 3.

Число делится на 3, если сумма его цифр делится на 3.

Признак делимости на 4.

Число делится на 4, если две его последние цифры - нули или образуют число, делящееся на 4.

Признак делимости на 5.

Число делится на 5, если оно заканчивается либо на 0, либо на 5.

Признак делимости на 8.

Число делится на 8, если три его последние цифры - нули или образуют число, делящееся на 8.

Признак делимости на 9.

Число делится на 9, если сумма его цифр делится на 9.

Признак делимости на 11.

Число делится на 11, если сумма цифр, стоящих на четных местах либо равна сумме цифр, стоящих на нечетных местах, либо отличается от неё на число, делящееся на 11.

Признак делимости на 25.

Число делится на 5, если две его последние цифры - нули или образуют число, делящееся на 25.
 */
namespace task_01
{
    class Program
    {
        static void Calculate_variant_1()
        {
            int sum = 0;
            for (int i=5; i<1001; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                    sum += i;
            }
            Console.WriteLine($"Сумма1 - {sum}");
        }
        static void Calculate_variant_2()
        {
            int sum = 0;

            for (int i = 15; i < 1001; i++)
            {
                int inside_sum = 0;
                int value = i;
                int digit = i % 10;
                value = i / 10;
                if (digit != 5 && digit != 0)//проверяем условие кратности 5
                {
                    continue;
                }
                else// если i кратно 5 значит нужно проверить кратность 3
                {
                    while (value > 9)
                    {
                        inside_sum += value % 10;
                        value = value / 10;

                    }
                    inside_sum += digit + value;
                    if (inside_sum % 3 == 0) sum += i;
                }
                
            }
            Console.WriteLine($"Сумма2 - {sum}");
        }
        static void Calc_perfomance(Func method)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            method();
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}.{3:00000}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds, ts.Ticks);
            Console.WriteLine("RunTime " + elapsedTime);
        }
        delegate void Func();
        static void Main(string[] args)
        {
            Calc_perfomance(Calculate_variant_1);
            Calc_perfomance(Calculate_variant_2);//не работает?)
        }
    }
}
