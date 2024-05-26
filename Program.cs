using System;

class Program
{
    static void Main()
    {
        double sum = 0.0;
        int count = 0;

        Console.WriteLine("Enter numbers to calculate the average (enter a non-numeric value to end):");

        while (true)
        {
            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                sum += number;
                count++;
            }
            else
            {
                break; // Exit the loop if the input is not a number
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No numbers were entered.");
        }
        else
        {
            double average = sum / count;
            Console.WriteLine("The average of the entered numbers is: " + average);
        }
    }
}

