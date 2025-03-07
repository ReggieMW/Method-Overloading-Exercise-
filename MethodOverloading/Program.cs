namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        
        public static decimal Add(decimal c, decimal d)
        {
            return c + d;
        }

        public static string Add(int a, int b, bool one)
        {
            var sum = a + b;
            
            if (one == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (one == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (one == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
            int a = -1;
            int b = 2;
            decimal c = 2.0m;
            decimal d = -1.0m;
            bool one = true;
            string oneDollar = " dollar";
            string twoDollar = " dollars";
            
            if (Add(a, b) == 1)
                Console.WriteLine(a + b + oneDollar);
            else
            {
                Console.WriteLine(a + b + twoDollar);
            }

            if (Add(c, d) == 1)
            {
                Console.WriteLine(c + d + oneDollar);
            }
            else
            {
                Console.WriteLine(c + d + twoDollar);
            }
            
            Console.WriteLine(Add(a, b, one));
        }
    }
}
