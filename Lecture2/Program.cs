namespace Lecture2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Lecture 2-------");

            /*int numOfStudent;
            numOfStudent = 30;
            int numOfLecturer = 3;
            Console.WriteLine("NumOfStudent: {0}, NumOfLecturer: {1}", numOfStudent, numOfLecturer);
            numOfLecturer = 5;
            numOfStudent = 35;
            Console.WriteLine("NumOfStudent: {0}, NumOfLecturer: {1}", numOfStudent, numOfLecturer);

            float grade = 6.5F;
            double gpa = 3.6;

            char gradeInLetter = 'M';
            string gradeInWorld = "Merit";*/

            //const double PI = 3.14;

            /*bool pass = true;
            Console.WriteLine("Pass: {0}", pass);
            pass = false;
            Console.WriteLine("Pass: {0}", pass);*/

            /*int int_max = int.MaxValue; //int -> 4 bytes -> 32 bits -> 2147483647
            int int_min = int.MinValue;
            uint uint_max = uint.MaxValue; // 4294967295
            uint uint_min = uint.MinValue;
            byte byte_max = byte.MaxValue; // byte -> 1 byte -> 8 bits -> 2^8 = 256 (0-255)
            byte byte_min = byte.MinValue;
            Console.WriteLine("int_max: {0}, int_min: {1}", int_max, int_min);
            Console.WriteLine("uint_max: {0}, uint_min: {1}", uint_max, uint_min);
            Console.WriteLine("byte_max: {0}, byte_min: {1}", byte_max, byte_min);*/

            /*var result = (double) 8 / 3; // method 1: 8/3.0; method 2: 8.0/3; (double) 8/3
            Console.WriteLine("Data type: {0}", result.GetType());
            Console.WriteLine("Result: {0}", result);*/

            /*int IntegerNumber = 5;
            double RealNumber = 5.5;
            RealNumber = (double)IntegerNumber;
            IntegerNumber = (int)5.55;
            Console.WriteLine("Integer value: {0}", IntegerNumber);
            Console.WriteLine("Integer value: {0} ", RealNumber);*/

            /*int UserInput;
            bool Flag;
            Console.WriteLine("Enter a value:");
            UserInput = Convert.ToInt32(Console.ReadLine());
            Flag = (UserInput > 0);
            Console.WriteLine("The value is positive, {0}", Flag);*/

            /*int UserInput;
            Console.WriteLine("Enter a value:");
            UserInput = Convert.ToInt32(Console.ReadLine());
            if(UserInput > 0) 
            {
                Console.WriteLine("The value is positive");
            }
            else
            {
                Console.WriteLine("The value is negative, or 0");
            }*/

            /*int i;
            Console.WriteLine("\n----- for loop 1->n ------");
            for(i = 0; i< 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n----- for loop n->1 ------");
            for (i = 9; i >= 0; i--)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n----- while loop ------");
            i = 10;
            while (i < 10)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine("\n----- do while loop ------");
            i = 10;
            do
            {
                Console.Write(i + " ");
                i++;
            }
            while (i < 10);*/

            /*int[] numbers = { 5, 30, 2, 5, 5, 7, 32, 59 };
            for(int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine(numbers[i]);
            }
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }*/

            /*string[] names = {"An", "Thai", "Nhung", "Yen", "Tra"};
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }*/

            /*
             Please enter a positive integer number: 3
             Please enter value for a[0]: 5
             Please enter value for a[1]: -4
             Please enter value for a[2]: 0
             The array: 5 -4 0
             */

            Console.Write("Enter a positive number: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a value for a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Array:");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

        }

    }
}
