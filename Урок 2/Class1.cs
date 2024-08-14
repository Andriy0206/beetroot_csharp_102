class Program
{

    static void Main()
    {
        int sum = SumBetween(5, 8);
    }
    static int SumBetween(int x, int y)
        {
            
            int sum = 0;

            if (x == 0)
            {
                sum = x;
            }
            else if (x < y)
            {
                for (int i = x; i <= y; i++)
                {
                    sum += i;

                }
            }
            else
            {
                for (int i = y; i<= x; i++)
                {
                    sum += i;

                }
            }
            return sum;
        }
    static int MaxOf(params int[] ints)
    {
        string s1 = "qwerty;"
        int lenght1 = s1.Lenght;
        int lenght = ints.Lenght;
        int sum = ints.Sum();
        int min = ints.Min();
        return ints.Max();
    }
    
}
