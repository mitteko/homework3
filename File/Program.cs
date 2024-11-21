using System;
using System.Threading.Tasks;


namespace File
{
    class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();

        }


        //1
        static void Task1()
        {
           

            /// Дана последовательность из 10 чисел. Определить, является ли эта последовательность упорядоченной по возрастанию.
            /// В случае отрицательного ответа определить порядковый номер первого числа, которое нарушает данную последовательность.
            /// Использовать break.

            Console.WriteLine("1)");
            Console.WriteLine("Определить, является ли последовательность упорядоченной по возрастанию.");

            int[] numbers = new int[10];
            Console.WriteLine("Введите 10 чисел: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            bool ascending = true;
            int violation = -1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                if (numbers[i] > numbers[i + 1])
                {
                    ascending = false;
                    violation = i + 2;
                    break;
                }

            }

            if (ascending)
            {
                Console.WriteLine("Последовательность упорядочена.");
            }
            else
            {
                Console.WriteLine($"Последовательность не упорядочена. Номер числа первого нарушения - {violation}");
            }

        }


        //2
        static void Task2()
        {
            

            /// Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства:
            /// «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            /// Порядковые номера остальных карт соответствуют их названиям(«шестерка»,«девятка» и т.п.).
            /// По заданному номеру карты k(6 <= k <= 14) определить достоинство 
            /// соответствующей карты. Использовать try-catch-finally.

            Console.WriteLine("2)");
            Console.WriteLine("Определить достоинство соответствующей карты.");

            Console.Write("Введите порядковый номер карты (от 6 до 14): ");
            string[] cards = { "Шестерка", "Семерка", "Восьмерка", "Девятка", "Десятка", "Валет", "Дама", "Король", "Туз" };

            bool itiscard = byte.TryParse(Console.ReadLine(), out byte cardValue);
            
            try
            {
                Console.WriteLine($"Карта под номером {cardValue} это {cards[cardValue - 6]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Число должно быть от 6 до 14");
            }
            finally
            {
                Console.WriteLine("");
            }
        }


        //3
        static void Task3()
        {
            /// 

            Console.WriteLine("3)");
            Console.WriteLine("Выходные данные в соответствии с таблицей.");

            Console.Write("Введите строку: ");
            string input = Console.ReadLine().ToUpper();
            switch (input)
            {
                case "JABRONI":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "SCHOOL COUNSELOR":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "PROGRAMMER":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "BIKE GANG MEMBER":
                    Console.WriteLine("Moonshine");
                    break;
                case "POLITICIAN":
                    Console.WriteLine("your tax dollars");
                    break;
                case "RAPPER":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
        }


        enum Week
        {
            Понедельник = 1,
            Вторник = 2,
            Среда = 3,
            Четверг = 4,
            Пятница = 5,
            Суббота = 6,
            Воскресенье = 7
        }
        //4
        static void Task4()
        {
            /// Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, ...,7) выводит на экран его название
            /// (понедельник, вторник, ..., воскресенье). Использовать enum.

            Console.WriteLine("4)");
            Console.WriteLine("Порядковый номер дня-его название.");

            byte num_day;
            while (true)
            {

                Console.Write("Введите порядковый номер дня недели: ");
                string day = Console.ReadLine();
                if (byte.TryParse(day, out num_day))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Допустимы значения от 1 до 7");
                }
               
            }

            Console.WriteLine($"{num_day} день недели это {(Week)num_day}");


        }



        //5
        static void Task5()
        {

            /// Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента "Hello Kitty" или "Barbie doll" 
            /// необходимо положить их в “сумку”, т.е.прибавить к результату. Вывести на экран сколько кукол в “сумке”.

            Console.WriteLine("5)");
            Console.WriteLine("Вывести на экран сколько кукол в “сумке”.");

            string[] strings = {"Hello Kitty", "Barbie doll", "Monster High", " Bratz", "Hello Kitty"};
            int result = 0;
            foreach (string s in strings)
            {
                if ( s == "Hello Kitty" || s == "Barbie doll" )
                {
                    result++;
                }
            }
            Console.WriteLine($"Количество кукол в сумке - {result}");
            Console.ReadKey();
        }

    }
}
