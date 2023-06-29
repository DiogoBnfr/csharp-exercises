namespace ex009_fibonnacci_even_numbers_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int previous = 0;
            int current = 1;
            int next = 0;
            int sum = 0;
            while (next <= 4000000)
            {
                next = previous + current;
                if (next % 2 == 0) sum += next;
                previous = current;
                current = next;
            }
            Console.WriteLine(sum);
        }
    }
}