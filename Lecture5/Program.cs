namespace Lecture5
{
    
    internal class Program
    {
        public enum Seasons
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public enum ErrorCode
        {
            None = 0,
            NotFound = 404,
            ServerError = 500
        }
        static void Swap(ref int x, ref int y)
        {
            int temp = x; x = y; y = temp;
        }
        static void Swap(ref double x, ref double y)
        {
            double temp = x; x = y; y = temp;
        }
        static void Swap<T>(ref T x, ref T y)
        {
            T temp = x; x = y; y= temp;
        }       
        static dynamic Addition<T>(T x, T y)
        {
            return (dynamic)x + (dynamic)y;
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("-----------Lecture 5-----------");
            Seasons currentSeason = Seasons.Summer;
            Console.WriteLine("Current season: {0}", currentSeason);
            Seasons nextSeason = currentSeason + 1;
            Console.WriteLine("Next season: {0}", nextSeason);*/

            /*Days today = (Days)1 + 1;
            Console.WriteLine("{0}", today);*/

            /*ErrorCode code = ErrorCode.NotFound;
            Console.WriteLine(code);
            Console.WriteLine((int) code);*/

            /*int a = 0, b = 1;
            Console.WriteLine("a={0}, b={1}", a, b); // a=0, b=1
            //Swap(ref a, ref b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("a={0}, b={1}", a, b); //a=1, b=0

            double c = 6.5, d = 8.5;
            Console.WriteLine("c={0}, d={1}", a, b); //c=6.5, b=8.5
            //Swap(ref c, ref d);
            Swap<double>(ref c, ref d);
            Console.WriteLine("c={0}, d={1}", a, b); //c=8.5, d=6.5

            string s1 = "FPT", s2 = "FGW";
            Console.WriteLine("s1={0}, s2={1}", s1, s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine("s1={0}, s2={1}", s1, s2);*/

            /*int a = 1, b = 2;
            int c = Addition<int>(a, b);
            Console.WriteLine("a+b={0}", c);

            double x = 0.5, y = 1.5;
            double z = Addition<double>(x, y);
            Console.WriteLine("x+y={0}", z);*/
        }
    }
}
