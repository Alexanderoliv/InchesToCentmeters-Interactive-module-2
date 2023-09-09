using System;

public class Program
{
    const double CM_IN_INCH = 2.54;

    public static void Main()
    {
        // Running the tests
        TestInchesToCm();

        Console.WriteLine("\nEnter a value in inches to convert to centimeters: ");
        double inches;
        if (double.TryParse(Console.ReadLine(), out inches))
        {
            Console.WriteLine($"{inches} inches is {InchesToCm(inches)} centimeters.");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    public static double InchesToCm(double inches)
    {
        return inches * CM_IN_INCH;
    }

    public static void TestInchesToCm()
    {
        Console.WriteLine("Running Tests...\n");

        Console.WriteLine($"Test 1: {InchesToCm(5)} cm");  // Expected: 12.7 cm
        Console.WriteLine($"Test 2: {InchesToCm(5)} cm");  // Expected: 12.7 cm
        Console.WriteLine($"Test 3: {InchesToCm(-15)} cm"); // Expected: -38.1 cm
        Console.WriteLine($"Test 4: {InchesToCm(15994)} cm"); // Expected: 40624.76 cm

        Console.WriteLine("\nTests Completed.");
    }
}
