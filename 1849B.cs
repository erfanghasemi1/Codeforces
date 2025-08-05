using System.Diagnostics;
using System.Text;

public class Program
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int t);
        List<StringBuilder> results = Enumerable.Repeat(0, t).Select(_ => new StringBuilder()).ToList();

        PriorityQueue<(int index, int health), (int, int)> pq = new PriorityQueue<(int index, int health), (int, int)>();

        for (int i = 0; i < t; i++)
        {
            int[] data = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int k = data[1];
            int[] enemies = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            for (int j = 0; j < enemies.Length; ++j)
            {
                int result = enemies[j] % k;
                if (result == 0) result += k;
                pq.Enqueue((j, result), (-result, j));
            }

            while (pq.Count > 0)
            {
                var current = pq.Dequeue();

                current.health -= k;

                if (current.health <= 0) results[i].Append((current.index + 1).ToString() + ' ');

                else pq.Enqueue((current.index, current.health), (-current.health, current.index));
            }
        }

        foreach (var result in results)
            Console.WriteLine(result);
    }
}
