
namespace Practice
{
    public class OverloadingAndRecursion
    {
        public static void Main(string[] args)
        {
           
        }
        
        private static int Multiply(int a, int b)
        {
            return a * b;
        }
        
        private static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        
        private static double Multiply(double a, double b)
        {
            return a * b;
        }
    }
    
    public class SquareAreaCalculator
    {
        public int CalculateArea(int side) //square
        {
            return side * side;
        }

        public int CalculateArea(int width, int height) //rectangle
        {
            return width * height;
        }

        public double CalculateArea(double radius) //circle
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
    
    public class Recursion
    {
        public void OutputOfNumbers(int n)
        {
            if (n <= 0)
                return;

            Console.WriteLine(n);
            OutputOfNumbers(n - 1);
        }

        public int OutputSumOfNumbers(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            
            return n + OutputSumOfNumbers(n - 1);
        }

        public string ReverseString(string text)
        {
            if (text.Length <= 1)
            {
                return text;
            }

            return text[^1] + ReverseString(text[..^1]);
        }

        public int CountingLenghtOfString(string text)
        {
            if (text == "")
            {
                return 0;
            }
            
            return 1 + CountingLenghtOfString(text.Substring(1));
        }


        public int SearchingSumOfNumbers(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            
            return n + SearchingSumOfNumbers(n - 1);
        }

        public int SearchingFactorialOfNumbers(int n)
        {
            if (n == 1)
            {
                return 1; 
            }
            
            return n * SearchingFactorialOfNumbers(n - 1);
        }
        
    }
    
}