namespace Task2
{
    //    2) Програма загадує число від 1 до 146 (привіт, Random). Користувач намагається вгадати його. У разі неправильної відповіді програма підказує «більше» або «менше»
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Random random = new Random();
            int secretNumber = random.Next(1, 147);
            Console.ForegroundColor = ConsoleColor.White; // устанавливаем цвет
            Console.WriteLine("Я загадав число від 1 до 146. Спробуйте вгадати! :)");
            Console.ResetColor(); // сбрасываем в стандартный
            int attempts = 0;
            int guess;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
                Console.Write("Ваша спроба: ");
                string input = Console.ReadLine();
                Console.ResetColor(); // сбрасываем в стандартный

                if (int.TryParse(input, out guess))
                {
                    attempts++;

                    string hint = guess < secretNumber ? "більше" : (guess > secretNumber ? "менше" : $"Вітаємо! Ви вгадали число {secretNumber} за {attempts} спроб.");
                    Console.WriteLine(hint);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                    Console.WriteLine("Введено некоректне число. Спробуйте ще раз.");
                    Console.ResetColor(); // сбрасываем в стандартный
                }

            }
            while (guess != secretNumber);
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.WriteLine("Гра завершена. Дякуємо за гру!");
            Console.ResetColor(); // сбрасываем в стандартный
            Console.ReadKey();
        }
    }
}
