
namespace Practice
{
    public class MultiplyOverloading
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
    
}