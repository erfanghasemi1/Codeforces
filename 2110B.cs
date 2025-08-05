using System.Net.Http.Headers;
using System.Text;

public class Program
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out var t);

        List<StringBuilder> results = Enumerable.Repeat(0, t).Select(_ => new StringBuilder()).ToList();

        for (int i = 0; i < t; i++)
            results[i].Append(Solution());

        foreach(StringBuilder result in results) Console.WriteLine(result);
    }

    public static string Solution()
    {
        string input = Console.ReadLine()!;

        int sum = 0;

        for (int i = 1; i < input.Length - 1; i++)
        {
            if (input[i] == '(') sum++;
            else sum--;

            if (sum < 0) return "YES";
        }
        return "NO";
    }
}