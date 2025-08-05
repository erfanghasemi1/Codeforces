using System.Reflection.Metadata;
using System.Text;

public class Program
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int t);
        List<StringBuilder> results = Enumerable.Repeat(0,t).Select(_ => new StringBuilder()).ToList();

        for (int i = 0; i < t; i++)
            results[i].Append(Solution());

        foreach (StringBuilder sb in results) Console.WriteLine(sb);
    }

    public static string Solution()
    {
        int[] data = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int k = data[1] - 1 , x = 1;

        int[] towers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        int position = towers[k];
        
        towers = towers.OrderByDescending(x => x).ToArray();
        
        for (int i = towers.Length - 1; i >= 0; i--)
        {
            if (towers[i] <= position) continue;

            if (towers[i] - position + x - 1 > position) return "NO";

            else
            {
                x += (towers[i] - position);
                position = towers[i];

            }
        }

        return "YES";
        
    }
}