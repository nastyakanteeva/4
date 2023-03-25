internal class Program
{
    const int maxArrayLength = 1000;
    private static void Main(string[] args)
    {
        // заполнение массива 
        var counters = new int[maxArrayLength];
        // Ввод данных
        for (int N = int.Parse(Console.ReadLine()); N > 0; N--)
            counters[int.Parse(Console.ReadLine())]++;
        // Подсчет пар и вывод
        for (int i = 0; i < counters.Length; i++)
        {
            if (counters[i] != 0)
                Console.WriteLine($"{i} {counters[i]}");
        }
    }
}
