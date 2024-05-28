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
    public static class MyMath
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static double CalculateSquare(double x)
        {
            return x * x;
        }
    }
    public class ArrayClass
    {
        int MaxP;
        int MinP;
        public void Initialise(int[] A)
        {
            int i;
            Random MyValue = new Random();
            for (i = 0; i < 10; i++)
            {
                A[i] = Convert.ToInt32(MyValue.Next(1, 100));
            }
        }
        public void Display(int[] A)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. {1}", i, A[i]);
            }
        }
        public int FindMaximum(int[] A)
        {
            int i;
            int Max;
            Max = A[0];
            for (i = 1; i < 10; i = i + 1)
            {
                if (Max < A[i])
                {
                    Max = A[i];
                    MaxP = i;
                }
            }
            return (Max);
        }
        public int FindMinimum(int[] A)
        {
            int i;
            int Min;
            Min = A[0];
            for (i = 1; i < 10; i = i + 1)
            {
                if (Min > A[i])
                {
                    Min = A[i];
                    MinP = i;
                }
            }
            return (Min);
        }
        public int PositionOfMaximum()
        {
            return (MaxP);
        }
        public int PositionOfMinimum()
        {
            return (MinP);
        }
    }
    class Student
    {
        public string name;
        public int age;
        public string school;
        public Student(string name, int age, string school)
        {
            this.name = name;
            this.age = age;
            this.school = school;
        }
        public override string ToString()
        {
            return $"{name}, {age} years old, study at {school}";
        }
    }

    internal class Program
    {
        public static void Menu()
        {
            Console.WriteLine("-------------Menu:------------");
            Console.WriteLine("0->add a new student");
            Console.WriteLine("1->remove a student");
            Console.WriteLine("2->print all current students");
            Console.WriteLine("3->sort students");
            Console.WriteLine("4->exit");
        }

        static void RunStudentApp()
        {
            Console.WriteLine("------------Lecture 16--------------");

            Console.Write("Enter number of students: ");
            var n = int.Parse(Console.ReadLine());
            var students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter student  {0}: ", i);
                var input = Console.ReadLine().Split(" ");
                string name = input[0];
                int age = int.Parse(input[1]);
                string school = input[2];

                Student student = new Student(name, age, school);
                students.Add(student);
            }

            bool finish = false;
            Menu();

            while (finish != true)
            {
                Console.Write("\nEnter your option (0-3): ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Enter a new student: ");
                        var input = Console.ReadLine().Split(" ");
                        string name = input[0];
                        int age = int.Parse(input[1]);
                        string school = input[2];

                        Student student = new Student(name, age, school);
                        students.Add(student);
                        break;

                    case 1:
                        Console.WriteLine("Enter student position where you want to remove: ");
                        int pos = int.Parse(Console.ReadLine());
                        students.RemoveAt(pos);
                        break;
                    case 2:
                        Console.WriteLine("\nInfo of all students: ");
                        foreach (Student stu in students)
                        {
                            Console.WriteLine(stu.ToString());
                        }
                        break;
                    case 3:
                        var students_sorted = students.OrderBy(p => p.name).ThenBy(p => p.age).ToList();
                        Console.WriteLine("\nInfo of all students after sorting: ");
                        foreach (Student stu in students_sorted)
                        {
                            Console.WriteLine(stu.ToString());
                        }
                        break;
                    case 4:
                        finish = true;
                        break;
                    default:
                        Console.WriteLine("Please only enter a number from 0 to 4");
                        Menu();
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("--------Lecture 3------------");
            Person p1 = new Person();
            p1.name = "Cuong";
            p1.age = 33;
            p1.PrintInfo();

            Person p2 = new Person("Linh", 20);
            p2.PrintInfo();*/

            /*var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            MyClass MyObject = new MyClass(a, b);
            var result = MyObject.Logarithm();
            Console.WriteLine("The logarithm of {0} to the base {1} is {2}", a, b, result);
            Console.WriteLine("Sum = {0}", MyObject.Sum());*/

            /*Console.WriteLine(MyMath.Sum(12, 5));
            Console.WriteLine(MyMath.Multiplication(2, 5));
            Console.WriteLine(MyMath.CalculateSquare(3.5));*/

            /*int[] MyArray = new int[10];
            ArrayClass a = new ArrayClass();
            a.Initialise(MyArray);
            a.Display(MyArray);
            Console.WriteLine("Maximum element is: {0}", a.FindMaximum(MyArray));
            Console.WriteLine("The position of the maximum element is: {0}", a.PositionOfMaximum());
            Console.WriteLine("Minimum element is: {0}", a.FindMinimum(MyArray));
            Console.WriteLine("The position of the minimum element is: {0}", a.PositionOfMinimum());*/

            RunStudentApp();
        }
    }
}
