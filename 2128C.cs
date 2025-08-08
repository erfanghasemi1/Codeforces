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
        int.TryParse(Console.ReadLine(), out int n);

        int[] b = Console.ReadLine()!.Split().Select(int.Parse).ToArray() ;
        int minimum = b[0];
        
        for (int i = 1; i < n; i++)
        {
            if (2 * minimum <= b[i])
            {
                Console.WriteLine("NO");
                return;
            }
            minimum = b[i] < minimum ? b[i] : minimum;
        }
        Console.WriteLine("YES");
    }
}