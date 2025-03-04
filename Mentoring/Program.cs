
namespace Practice
{
    public class MultiplyOverloading
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2,3));
            /*Console.WriteLine(Multiply(2,3,4));
            Console.WriteLine(Multiply(2.5, 2.0));*/
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
    
}