internal class Program
{
    private static void Main(string[] args)
    {
        int x = 4;
        int y = x + 5;
        int u = x + y;
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(u);
        int o = Math.Max(u, y);
        Console.WriteLine("the biigger value:" + o);
        int p = o ^ 2;
        Console.WriteLine("square:" + p );
    }
}