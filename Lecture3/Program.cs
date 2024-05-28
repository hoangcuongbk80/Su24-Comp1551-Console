namespace Lecture3
{
    class Person
    {
        // Data
        public string name;
        public int age;

        // Constructor
        public Person()
        {
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.PrintInfo();
        }
        
        // Functionality 
        public void PrintInfo()
        {
            Console.WriteLine("{0}, {1}", name, age);
        }
    }

    class MyClass
    {
        private double X, Y;
        private double? Z = null;
        public MyClass(double a, double b) 
        {
            this.X = a;
            this.Y = b;
        }
        public double? Logarithm()
        {
            Z = Math.Log(X, Y);
            return Z;
        }

        public double Sum()
        {
            return X + Y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass MyObject = new MyClass(8, 2);
            double? result = MyObject.Logarithm();
            Console.WriteLine("The logarithm of {0} to the base {1} is {2}", MyObject.X, MyObject.Y, result);
            Console.WriteLine("Sum = {0}", MyObject.Sum());
            /*Console.WriteLine("--------Lecture 3------------");
            Person p1 = new Person();
            p1.name = "Cuong";
            p1.age = 33;
            p1.PrintInfo();

            Person p2 = new Person("Linh", 20);
            p2.PrintInfo();*/


        }
    }
}
