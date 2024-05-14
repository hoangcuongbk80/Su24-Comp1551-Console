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

        static double SquareRoot(double number)
        {
            double result = Math.Sqrt(number);
            return result;
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, CO1103!");
            // printHello();
            // printHello("Cuong");

            Console.Write("Enter an integer number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            if(number > 0)
            {
                double result = SquareRoot(number);
                Console.WriteLine("Square root of {0} is: {1:F2}", number, result);
            }
            else
            {
                Console.WriteLine("Cannot find square root of a negative number");
            }
        }
    }
}
