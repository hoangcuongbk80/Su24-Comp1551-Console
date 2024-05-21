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
            Console.WriteLine("--------Lecture 1--------");

            // Console.WriteLine("Hello, CO1103!");
            // printHello();
            // printHello("Cuong");

            /*Console.Write("Enter an integer number: ");
            double number; //= Convert.ToDouble(Console.ReadLine());
            number = Convert.ToDouble(Console.ReadLine());
            if (number > 0)
            {
                double result = SquareRoot(number);
                Console.WriteLine("Square root of {0} is: {1:F2}", number, result);
            }
            else
            {
                Console.WriteLine("Cannot find square root of a negative number");
            }*/

            /*double a1 = 3.0;
            double b1 = 0.000000000000000000001;
            double c1 = a1 + b1;
            Console.WriteLine(c1);*/

            /*Decimal a2 = 3.0M;
            Decimal b2 = 0.000000000000000000001M;
            Decimal c2 = a2 + b2;
            Console.WriteLine(c2);*/

            var a3 = 3.0;
            var b3 = 0.000000000000000000001;
            var c3 = a3 + b3;
            Console.WriteLine(c3);


        }
    }
}
