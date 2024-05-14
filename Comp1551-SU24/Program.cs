namespace Comp1551_SU24
{
    internal class Program
    {
        static void printHello()
        {
            Console.WriteLine("PrintHello without parameters");
        }
        static void printHello(string str)
        {
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, CO1103!");
            printHello();
            printHello("Cuong1");
        }
    }
}
