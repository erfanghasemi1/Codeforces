public class Program
{
    public static void Main()
    {
        long.TryParse(Console.ReadLine(), out long t);

        for (long i = 0; i < t; i++)
            Solution();
    }

    public static void Solution()
    {
        long.TryParse(Console.ReadLine(), out long n);

        List<long> p = Console.ReadLine()!.Split().Select(long.Parse).ToList();

        int up = 1, down = 1;
        long pre = -1;

        Console.Write('L');
        pre = p[0];
        p.RemoveAt(0);

        Console.Write('L');
        if (p[0] > pre) up++;
        else down++;
        pre = p[0];
        p.RemoveAt(0);

        for (long i = 2; i < n - 1; ++i)
        {
            if (up > 1)
            {
                if (p.Last() < pre)
                {
                    up = 1;
                    down++;
                    Console.Write('R');
                    pre = p.Last();
                    p.RemoveAt(p.Count - 1);
                }
                else if (p[0] < pre)
                {
                    up = 1;
                    down++;
                    Console.Write('L');
                    pre = p[0];
                    p.RemoveAt(0);
                }
                else
                {
                    up++;
                    if (p.Last() > p[0])
                    {
                        Console.Write('R');
                        pre = p.Last();
                        p.RemoveAt(p.Count-1);
                    }
                    else
                    {
                        Console.Write('L');
                        pre = p[0];
                        p.RemoveAt(0);
                    }
                }
            }
            else if (down > 1)
            {
                if (p.Last() > pre)
                {
                    down = 1;
                    up++;
                    Console.Write('R');
                    pre = p.Last();
                    p.RemoveAt(p.Count - 1);
                }
                else if (p[0] > pre)
                {
                    down = 1;
                    up++;
                    Console.Write('L');
                    pre = p[0];
                    p.RemoveAt(0);
                }
                else
                {
                    down++;
                    if (p.Last() < p[0])
                    {
                        Console.Write('R');
                        pre = p.Last();
                        p.RemoveAt(p.Count - 1);
                    }
                    else
                    {
                        Console.Write('L');
                        pre = p[0];
                        p.RemoveAt(0);
                    }
                }
            }
        }
        Console.WriteLine('R');
    }
}