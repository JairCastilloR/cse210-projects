using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers_list = new List<int>();
        int number = -1;

        do
        {
            Console.Write("\nEnter a list of numbers, type 0 when finished:");
            string response = Console.ReadLine();
            number = int.Parse(response);

            if (number != 0 )
            {
                numbers_list.Add(number);
            }

        }while (number != 0);

        int sum = 0;
        foreach (int numb in numbers_list)
        {
            sum += numb;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum)/numbers_list.Count;
        Console.WriteLine($"The average is: {average}");
        
        int max_number = numbers_list[0];

        foreach (int numb in numbers_list)
        {
            if (numb > max_number)
            {
                max_number = numb;
            }
        }
        Console.WriteLine($"The largest number is: {max_number}");

        int min_number = numbers_list[0];

        foreach (int numb in numbers_list)
        {
            if (numb < min_number)
            {
                if (number> 0)
                    {
                        min_number = numb;
                    }
            }
        }
        Console.WriteLine($"The smallest positive number is: {min_number}");

    }
}