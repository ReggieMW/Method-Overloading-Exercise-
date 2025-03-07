namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
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
            var a = -11;
            var b = 76;
            bool one = true;
            
            Console.WriteLine(Add(a, b, one));
        }
    }
}
