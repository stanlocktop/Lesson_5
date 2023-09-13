namespace Task1
{
    //    1) Напишіть програму, яка «запитуватиме» правильний пароль, доки він не буде введений. Правильний пароль нехай буде "root". Якщо пароль неправильний, програма повинна сказати "Неправильний пароль!"
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string truePassword = "root";
            string enteredPassword;
            do
            {
                Console.ForegroundColor = ConsoleColor.White; // устанавливаем цвет
                Console.Write("Введіть пароль: ");
                Console.ResetColor(); // сбрасываем в стандартный
                enteredPassword = Console.ReadLine();
                if (enteredPassword != truePassword)
                {
                    Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                    Console.WriteLine("Неправильний пароль!");
                    Console.ResetColor(); // сбрасываем в стандартный
                }
            } while (enteredPassword != truePassword);
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.WriteLine("Вхід дозволено :) Ви увійшли в систему :)");
            Console.ResetColor(); // сбрасываем в стандартный
            Console.ReadKey();
        }
    }
}
