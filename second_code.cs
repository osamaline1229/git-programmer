internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("write your name:");
        string myna = Console.ReadLine();
        Console.WriteLine("write your gba:");
        int mygba = Convert.ToInt32(Console.ReadLine());

        int c = mygba / 2;

        

        Console.WriteLine("my name is:" + myna);
        Console.WriteLine("my gba is:" + mygba);
        Console.WriteLine("your divided gba:"+ c);

    }
}