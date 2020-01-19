using System;

namespace Task_02
{
    //Expr11. Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах.
    //Необходимо первоначально расчитать угол за единицу времени
    //минуты 360/60=6 градусов
    //часы - 360/12=30 градусов

    class Program
    {
        const int minMinuteHandDeegres = 6;
        const int minHourHandDeegrees = 30;
        static double CalculateAngle(double _hours, double _minutes)
        {
            if (_hours > 12) _hours -= 12;
            double _result= ((_hours+_minutes/60) * minHourHandDeegrees- _minutes * minMinuteHandDeegres);//hours with minutes degrees minus minutes degrees
            return _result;
        }
        static void Main(string[] args)
        {
            int hours, minutes;
            Console.WriteLine("Enter hours");
            while (!int.TryParse(Console.ReadLine(), out hours) || hours<0 || hours>25)//This is integer hours without minutes!!!!
            {
                Console.WriteLine("Enter correct hours");
            }
            Console.WriteLine("Enter minutes");
            while (!int.TryParse(Console.ReadLine(), out minutes) || minutes < 0 || minutes > 25)
            {
                Console.WriteLine("Enter correct minutes");
            }
            double result=CalculateAngle(hours, minutes);
            Console.WriteLine($"Result {result}");
        }
    }
}
