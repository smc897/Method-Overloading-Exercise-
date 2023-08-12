namespace MethodOverloading
{
    public class Program
    {

        //add two numbers
        static int Add(int a, int b) {
            return a + b;
        }

        //add two floats
        static double Add(double a, double b) {
            return a + b;
        }

        //add two strings
        static string Add(int a, int b, bool bl) {
            if (bl) {
                int c = a + b;
                if (c != 1) return c + " dollars";
                else return c + " dollar";
            }
            return null;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(3,5));
            Console.WriteLine(Add(4.5, 5.5));
            Console.WriteLine(Add(4, 1, true));
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine(Add(8, 8, true));

        }
    }
}
