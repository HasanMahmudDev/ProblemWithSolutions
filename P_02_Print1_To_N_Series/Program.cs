namespace P_02_Print1_To_N_Series
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nNumbers from 1 to {n}:");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
