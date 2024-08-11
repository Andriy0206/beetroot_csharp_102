using System;
class Program
{

    static int Sum(int from, int to)
    {
        if (from > to) return Sum(to, from);
        if (from == to) return from;
        return from + Sum(from + 1, to);
    }
    static void Main()
    {
        Sum(1, 2);
    //    Console.WriteLine("Ведіть оцінку від 0-100");
    //    int grade = int.Parse(Console.ReadLine());
    //    if (grade >=90 && grade <=100)
    //    {
    //        Console.WriteLine("SUPER");
    //    }
    //    else if (grade < 89 && grade >= 56)
    //    {
    //        Console.WriteLine("GOOD");
    //    }
    //    else
    //    {

    //        Console.WriteLine("Bad");
    //    }


    //}
}