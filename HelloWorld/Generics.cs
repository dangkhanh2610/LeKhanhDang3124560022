namespace HelloWorld;

public class Generics
{
    public static void swap<T> (ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
    static void Main(string[] args)
    {
        int x = 18, y = 36;
        swap<int> (ref x, ref y);
        System.Console.WriteLine($"Gia tri sau khi swap: x = {x}, y = {y}");
    }   
}