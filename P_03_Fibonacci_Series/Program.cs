namespace P_03_Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, temp;

            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                temp = a + b;
                a = b;
                b = temp;
            }
        }
    }
}
