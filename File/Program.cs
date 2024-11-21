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

        }
    }
}
