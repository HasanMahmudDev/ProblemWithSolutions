using System;
namespace P_01_PerformAddSubMulandDivision
{
    public class Program
    {
        static void Main()
        {
            // Take input from the user
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Perform basic arithmetic operations
            double addition = num1 + num2;
            double subtraction = num1 - num2;
            double multiplication = num1 * num2;
            double division = (num2 != 0) ? num1 / num2 : double.NaN; // Check for division by zero

            // Display the results
            Console.WriteLine("\nResults:");
            Console.WriteLine($"Addition: {num1} + {num2} = {addition}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {subtraction}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {multiplication}");
            Console.WriteLine($"Division: {num1} / {num2} = {(num2 != 0 ? division.ToString() : "Division by zero is undefined!")}");
        }
    }
}
