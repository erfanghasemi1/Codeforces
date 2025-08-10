using System.Net;

public class Program
{
    public static void Main()
    {
        long.TryParse(Console.ReadLine(), out long t);

        for (long i = 0; i < t; ++i)
            Solution();
    }

    public static void Solution()
    {
        var data = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

        long coin = data[1];

        List<Casino> casino = new List<Casino>();

        for (long i = 0; i < data[0]; ++i)
        {
            long[] input = Console.ReadLine()!.Split().Select(long.Parse).ToArray();
            Casino c = new Casino { l = input[0] , r = input[1] , Real = input[2] };
            casino.Add(c);
        }

        casino = casino.OrderBy(c => c.l).ToList();  


        for (int i = 0; i < casino.Count; i++)
        {
            if (coin >= casino[i].l && coin <= casino[i].r && coin < casino[i].Real)
                coin = casino[i].Real;
        }
        Console.WriteLine(coin);
    }

    struct Casino
    {
        public long l, r, Real;
    }
}