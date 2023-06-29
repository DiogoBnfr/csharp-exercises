namespace ex008_multiples_of_3_and_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert range: ");
            int range = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0;  i < range; i++)
            {
                if (i % 3 == 0  || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"The sum of the multiples of 3 and 5 below {range} is: {sum}");
        }
    }
}