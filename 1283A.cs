public class Program
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int t);
        int TotalTime = 0;
        int[] results = new int[t];

        for (int i = 0; i < t; i++)
        {
            int[] time = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            TotalTime += (60 - time[1]);

            time[0]++;

            TotalTime += ((24 - time[0]) * 60);
            results[i] = TotalTime;
            TotalTime = 0;
        }

        foreach(int i in results) Console.WriteLine(i);
    }
}