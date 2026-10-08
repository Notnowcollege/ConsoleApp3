namespace ConsoleApp3
{
    internal class Program
    {
        static void SumEvenNumbers()
    {
        Console.Write("Введіть кількість чисел для перевірки: ");
        int N = int.Parse(Console.ReadLine());

        int sum = 0;
        int total = 0;

        for (int i = 0; i < N; i++)
        {
            Console.Write("Введіть число для перевірки: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                sum += number;
                total++;
            }
        }

        if (total == 0)
        {
            Console.WriteLine("Парних чисел немає.");
        }
        else
        {
            double average = (double)sum / total;

            Console.WriteLine("Сума парних чисел: " + sum);
            Console.WriteLine("Кількість парних чисел: " + total);
            Console.WriteLine("Середнє значення: " + average);
        }
    }

        static void MultiplicationTable()
                    {
            Console.Write("Введіть число для виведення таблиці множення: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Таблиця множення для {number}:");
            for (int i = 1; i <= 10; i++)
            {
                if (number == 0)
                {
                    Console.WriteLine("Таблиця множення для нуля не існує.");
                    break;
                }
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }

        static void CheckTriangle()
        {
            Console.Write("Введіть першу сторону трикутника: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введіть другу сторону трикутника: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введіть третю сторону трикутника: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Трикутник існує.");

                if (a == b && b == c)
                {
                    Console.WriteLine("Трикутник рівносторонній.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Трикутник рівнобедрений.");
                }
                else
                {
                    Console.WriteLine("Трикутник різносторонній.");
                }
            }
            else
            {
                Console.WriteLine("Трикутник не існує.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Виберіть завдання:");
            Console.WriteLine("1. Сума парних чисел");
            Console.WriteLine("2. Таблиця множення");
            Console.WriteLine("3. Перевірка трикутника");
            Console.WriteLine("0. Вийти з програми");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SumEvenNumbers();
                    break;
                case 2:
                    MultiplicationTable();
                    break;
                case 3:
                    CheckTriangle();
                    break;
                case 0:
                    Console.WriteLine("Вихід з програми.");
                    break;  
                default:
                    Console.WriteLine("Невірний вибір.");
                    break;
            }
        }
    }
}
        
    


           
        
    
