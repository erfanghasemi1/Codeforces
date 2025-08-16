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
        long[] data = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

        long n= data[0] , c = data[1];

        List<long> trashes = Console.ReadLine()!.Split().Select(long.Parse).ToList();

        trashes = trashes.OrderByDescending(x => x).ToList();

        int MinCoin = 0 , multiply = 1;

        for (int i = 0; i  < n; i++)
        {
            if (trashes[i] * multiply > c) ++MinCoin;

            else multiply *= 2;
        }
        Console.WriteLine(MinCoin);
    }
}