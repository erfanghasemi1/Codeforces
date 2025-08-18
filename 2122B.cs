public class Program
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int t);

        for (int i = 0; i < t; i++)
            Solution();
    }

    public static void Solution()
    {
        long.TryParse(Console.ReadLine(), out long n);

        long operations = 0; 

        for (int i = 0; i < n; i++)
        {
            long[] input = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

            if (input[0] < input[2])
                operations += input[2] - input[0];

            if (input[1] < input[3])
                operations += input[3] - input[1];

            else if (input[1] > input[3])
                if (Math.Min(input[0], input[2]) != 0) 
                    operations += Math.Min(input[0], input[2]);

        }
        Console.WriteLine(operations);
    }
}