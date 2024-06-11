namespace Comp1551_SU24
{
    class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic animal sound");
        }
    }
    class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
    class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
    internal class Program
    {
        public enum Seasons
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        public enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        public enum ErrorCode
        {
            None = 0,
            NotFound = 404,
            ServerError = 500
        }
        static public int Addition(int a, int b)
        { return a + b; }
        static public double Addition(double a, double b) 
        { 
            return a + b; 
        }
        static public T Addition<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            dynamic z = x+y;
            return z;
        }
        static public void Swap(ref int a, ref int b)
        {
            int temp = a; a = b; b = temp;
        }
        static public void Swap(ref double a, ref double b)
        {
            double temp = a; a = b; b = temp;
        }

        static public void Swap<T>(ref T a, ref T b)
        {
            T temp = a; a = b; b = a;
        }

        static void DateTime_Ex()
        {
            // Get the current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + now);

            // Get the current date
            DateTime today = DateTime.Today;
            Console.WriteLine("Today's Date: " + today);

            // Creating a specific date and time
            DateTime specificDate = new DateTime(2024, 6, 10, 15, 30, 0);
            Console.WriteLine("Specific Date and Time: " + specificDate);

            // Extracting components of a DateTime object
            Console.WriteLine("Year: " + specificDate.Year);
            Console.WriteLine("Month: " + specificDate.Month);
            Console.WriteLine("Day: " + specificDate.Day);
            Console.WriteLine("Hour: " + specificDate.Hour);
            Console.WriteLine("Minute: " + specificDate.Minute);
            Console.WriteLine("Second: " + specificDate.Second);

            // Adding or subtracting time intervals
            DateTime futureDate = specificDate.AddYears(1).AddMonths(2).AddDays(3);
            Console.WriteLine("Future Date: " + futureDate);

            DateTime pastDate = specificDate.AddYears(-1).AddMonths(-2).AddDays(-3);
            Console.WriteLine("Past Date: " + pastDate);

            // Formatting a DateTime object as a string
            string formattedDate = specificDate.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine("Formatted Date: " + formattedDate);

            // Parsing a string into a DateTime object
            string dateString = "2024-12-25 08:00:00";
            DateTime parsedDate = DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm:ss", null);
            Console.WriteLine("Parsed Date: " + parsedDate);
        }
        static void Main(string[] args)
        {
            /*Seasons currentSeasons = Seasons.Summer;
            Console.WriteLine(currentSeasons); 
            currentSeasons = Seasons.Autumn;
            Console.WriteLine(currentSeasons);
            currentSeasons = (Seasons)1;
            Console.WriteLine(currentSeasons);
            currentSeasons += 1;
            Console.WriteLine(currentSeasons);*/

            /*DayOfWeek today = DayOfWeek.Monday;
            Console.WriteLine($"Today is: {today}");*/

            /*ErrorCode code = ErrorCode.ServerError;
            Console.WriteLine($"Error code: {(int)code}");*/

            /*int a = 5, b = 6;
            Console.WriteLine("a={0} and b = {1}", a, b);
            Swap(ref a , ref b);
            Console.WriteLine("a={0} and b = {1}", a, b);

            string x = "Greenwich ", y= "FPT";
            Console.WriteLine("x={0}, y={1}", x, y);
            Swap<string>(ref x,ref y);
            Console.WriteLine("x={0}, y={1}", x, y);*/

            /*Animal[] animals = new Animal[3];
            animals[0] = new Dog("Buddy");
            animals[1] = new Cat("Whiskers");
            animals[2] = new Dog("Max");
            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}");
                animal.MakeSound();
                Console.WriteLine();
            }*/

            /*List<Animal> animalsList = new List<Animal>();
            animalsList.Add(new Dog("Buddy"));
            animalsList.Add(new Cat("Whiskers"));
            animalsList.Add(new Dog("Max"));
            foreach (var animal in animalsList)
            {
                Console.WriteLine($"Name: {animal.Name}");
                animal.MakeSound();
                if (animal is Dog)
                {
                    Console.WriteLine("Special Dog-related action here");
                }
                else if (animal is Cat)
                {
                    Console.WriteLine("Special Cat-related action here");
                }
                Console.WriteLine();
            }*/
            DateTime_Ex();
        }
    }
}
