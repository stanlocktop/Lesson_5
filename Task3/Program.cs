using Random = System.Random;
namespace Task3
{
    //    3) Доробити програму, яку розглядали на занятті (через використання методу і в ньому return)
    //Перевірка чи є введене натуральне число простим

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Random random = new Random();
            int gennum = random.Next(2, 1000);
            bool simple = true;
            int indicator = 1;
            for (int i = 2; i < gennum; i++)
            {
                if (gennum % i == 0)
                {
                    simple = false;
                    break;
                }
            }
            if (simple)
            {
                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                Console.WriteLine("Simple :) ");
                Console.ResetColor(); // сбрасываем в стандартный
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                Console.WriteLine("Not simple :( ");
                Console.ResetColor(); // сбрасываем в стандартный
            }    
            Console.ReadKey();
        }
    }
}
