namespace Lecture4
{
    class MonthName
    {
        private int month = 1;
        public int Month
        {
            get { return month; }
            set { if((value>0) && (value<13)) { month = value; }}
        }
    }

    class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;
        private double D;
        private double? x1;
        private double? x2;

        public double? X1 {
            get { return x1; } set { x1 = value; }
        }
        public double? X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public void Calculate(double p1, double p2, double p3)
        {
            a = p1; b = p2; c = p3;
            D = Convert.ToDouble(b * b - 4 * a * c);
            if((a!=0) && (D >= 0))
            {
                x1 = Convert.ToDouble((-b + Math.Sqrt(D)) / (2*a));
                x2 = Convert.ToDouble((-b - Math.Sqrt(D)) / (2*a));
            }
            else
            {
                x1 = null;
                x2 = null;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Lecture 4----------------");

            /*String S;
            System.Globalization.DateTimeFormatInfo Months = new System.Globalization.DateTimeFormatInfo();
            MonthName a = new MonthName();
            a.Month = 3;
            S= Convert.ToString(Months.GetMonthName(a.Month));
            Console.WriteLine("The month is: {0}", S);*/

            QuadraticEquation quadraticEquation = new QuadraticEquation();
            quadraticEquation.Calculate(27,4,-5);
            if (quadraticEquation.X1 != null)
            {
                Console.WriteLine("Result: {0}, {1}", quadraticEquation.X1, quadraticEquation.X2);
            }
            else
            {
                Console.WriteLine("Result: null");
            }


        }
    }
}
