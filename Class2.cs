//using System;
//class Program
//    static void Main(string[] args)
//{
//    {
//        //Метод для знаходження мінімального та максимального значень
//        public static void
//            MaxMinValues(int a, int b, int c)
//        {
//            int max = Math.Max(a, Math.Max(b, c));
//            int min = Math.Min(a, Math.Min(b, c));
//            Console.WriteLine($"Max:{max} Min:{min}");
//        }
//        //Метод TrySumIfodd,що повертаєсуму якщо вона непарна,інакше - третій параметр
//        public static int TrySumIfOdd(int a, int b, int defaultValue)
//        {
//            int sum = a + b;
//            if (sum % 2 != 0)
//            {
//                return sum;
//            }

//        }
//        //Метод Repeat,Що повторю рядок N разів
//        public static string Repeat(string str, int N)
//        {
//            string result = "";
//            for (int i = 0; i < N; i++)
//            {
//                result += str;
//            }
//            return result;
//        }
//        static void Main(string[] args)
//        {
//            //Викликаємо метод MaxMinValues
//            Console.WriteLine("Визначення максимального та мінімального значення:");
//            MaxMinValues(10, 20, 5);
//            //Виконуємо метод TrySumIfOdd
//            Console.WriteLine("\nСпроба суми, якщо вона непарна:");
//            int result = TrySumIfOdd(10, 3, 0);
//            Console.WriteLine($"Результат:{result}");
//            //Викликамо метод Repat 
//            Console.WriteLine("\nПовторення рядка:");
//            string repestedString = Repeat("str", 3);
//            Console.WriteLine($"результат:{repestedString}");
//            //Затримка консольного вікна
//            Console.ReadLine();
//        }
//    }

Console.WriteLine("Віедіть ваш вік");
int age  = int.Parse(Console.ReadLine());
if (age < 18)
{
    Console.WriteLine("Ви не повнолітній");

}
if (age >18 && age <60)
{
    Console.WriteLine("Ви дорослий");

}
else
{
    Console.WriteLine("Ви пенсіонер");
}