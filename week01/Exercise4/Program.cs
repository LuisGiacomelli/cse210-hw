using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        do
        {
            Console.Write("Enter number: ");
            string value = Console.ReadLine();

            number = int.Parse(value);

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);
        int z = 0;
        int larger = numbers[0];

        foreach (int x in numbers)
        {
            z += x;
            if (larger < x)
            {
                larger = x;
            }
        }
        Console.Write("The sum is: ");
        Console.WriteLine(z);

        int cantNum = numbers.Count;
        float average = z / cantNum;

        Console.Write("The average is: ");
        Console.WriteLine(average);

        Console.Write("Larger number is: ");
        Console.WriteLine(larger);

    }
}