namespace Practice;

public class Recursion
{
    static void PrintArray()
    {
        int[] a = {1,2,3};

        Console.WriteLine(a);

       
        PrintArray();
    }
}