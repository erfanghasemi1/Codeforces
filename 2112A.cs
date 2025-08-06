using System.Text;
using System.Xml.Schema;

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
        int[] inputs = Console.ReadLine()!.Split().Select(int.Parse).ToArray(); 

        int a = inputs[0] , x = inputs[1] , y = inputs[2];

        if ( (a >= x  && a <= y) || (a >= y && a<=x) ) Console.WriteLine("NO");

        else Console.WriteLine("YES");
    }
}