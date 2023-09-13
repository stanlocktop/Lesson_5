namespace Task1
{
    //   1) Потрібно додати до масиву елемент на початок. 
    //Масив заповнити рандомними числами.Той елемент, що потрібно додати, також взяти рандомно.Зробити методи, які в якості параметру приймають масив (вивід на екран, заповнення масиву елементами, додавання елементу на початок).
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int[] array = new int[5]; 
            RandomNumbersArray(array);

            Console.Write("Начальный вид массива: ");
            Console.Write(string.Join(",",  array) + "\n"); // Виводимо початковий масив

            // Генеруємо випадкове число, яке будемо додавати на початок масиву
            int numberToAdd = GenerateRandomNumber();

            // Додаємо елемент на початок масиву
            AddElementAtBeginning(array, numberToAdd);

            // Виводимо оновлений масив на екран
            PrintArray(array);
        }

        // Метод для заповнення масиву випадковими числами
        static void RandomNumbersArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101); // Змініть діапазон чисел за потребою
            }
        }

        // Метод для виведення масиву на екран
        static void PrintArray(int[] array)
        {
            Console.WriteLine("Масив:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        // Метод для генерації випадкового числа
        static int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 101); // Змініть діапазон чисел за потребою
        }

        // Метод для додавання елементу на початок масиву
        static void AddElementAtBeginning(int[] array, int element)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[0] = element;

            // Копіюємо вміст початкового масиву в новий масив, зсуваючи його на один елемент праворуч
            Array.Copy(array, 0, newArray, 1, array.Length);

            // Копіюємо оновлений масив назад в початковий масив
            Array.Copy(newArray, array, array.Length);
            Console.ReadKey();
        }
    }
}
