public class Program
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int t);

        for (int i = 0; i < t; ++i)
            Solution();
    }

    public static void Solution()
    {
        long[] data = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

        long[] boxes = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

        long k = data[1] , max = boxes.Max() , min = boxes.Min();

        long MaxCount = boxes.Count(x => x == max);

        if (max - 1 - min > k) Console.WriteLine("Jerry");

        else if ((max - 1 - min == k) && (MaxCount > 1)) Console.WriteLine("Jerry");

        else if (boxes.Sum() % 2 == 0) Console.WriteLine("Jerry");

        else Console.WriteLine("Tom");
    }
}