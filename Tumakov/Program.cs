using System;


namespace Tumakov
{
    internal class Program
    {
        static void Main()
        {

            //1

            Console.WriteLine("4.1)");
            Console.WriteLine("Написать программу, которая читает с экрана число от 1 до 365 (год), переводит этот число в месяц и день месяца.");

            Console.WriteLine("Введите номер дня в году (от 1 до 365): ");
            short dayofyear;

            if (short.TryParse(Console.ReadLine(), out dayofyear) && dayofyear > 0 && dayofyear < 366)
            {
                DateTime date = new DateTime(2024,1,1).AddDays(dayofyear-1); //Метод AddDays добавляет указанное количество дней к текущему объекту DateTime
                                                                             //new-инициализация нового объекта типа DateTime с заданными значениями
                Console.WriteLine(date.ToString("d MMMM yyyy"));

            }
            else
            {
                Console.WriteLine("Введите число от 1 до 365!");
            }



            //2

            Console.WriteLine("4.2)");
            Console.WriteLine("Добавить к задаче из предыдущего упражнения проверку числа введенного пользователем.");

            Console.WriteLine("Введите номер дня в году (от 1 до 365): ");
            short day;

            if (short.TryParse(Console.ReadLine(), out day) && day > 0 && day < 366)
            {
                DateTime date1 = new DateTime(2024, 1, 1).AddDays(day - 1); 
                Console.WriteLine(date1.ToString("d MMMM yyyy"));

            }
            else
            {
                Console.WriteLine("Введите число от 1 до 365!");
            }



            //3

            /// Изменить программу из упражнений 4.1 и 4.2 так, 
            /// чтобы она учитывала год (високосный или нет). 
            /// Год вводится с экрана. 
            /// (Год високосный, если он делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный год. Однако, если он делится без остатка на 400, это високосный год.)

            Console.WriteLine("4.3)");
            Console.WriteLine("Учитывание год (високосный или нет)");

          
            short year;

            Console.WriteLine("Введите год: ");
            while (!short.TryParse(Console.ReadLine(), out year) || year < 0)
            {
                Console.WriteLine("Некорректные данные, ведите число больше нуля");
            }
            

            short dayOfYear;

            Console.WriteLine("Введите номер дня в году (от 1 до 365 или от 1 до 366 для високозного года): ");
            while (!short.TryParse(Console.ReadLine(), out dayOfYear) || dayOfYear <= 0 || dayOfYear > (LeapYear(year) ? 366 : 365))
            {
                Console.WriteLine($"Введите число от 1 до {(LeapYear(year) ? 366 : 365)}.");
            }

            DateTime dateday = new DateTime(year,1,1).AddDays(dayOfYear - 1);
            Console.WriteLine(dateday.ToString("d MMMM yyyy"));
            Console.ReadKey();
        }



        static bool LeapYear(short year)
        {
            if (year%4==0)
            {
                if (year % 100 == 0)
                {
                    return year % 400 == 0;
                }
                return true;
            }
            return false;
        }
    }
}
