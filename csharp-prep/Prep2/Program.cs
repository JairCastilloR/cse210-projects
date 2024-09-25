using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("\nWhat is your grade percentage?: ");
        string grade_percentage=Console.ReadLine();
        int percentage=int.Parse(grade_percentage);
        string letter_grade= "";

        if (percentage > 90)
        {
            if (percentage%10<3)
            {
                letter_grade = "A-";
            }
            else
            {
                letter_grade = "A";
            }
        }

        else if (percentage >=80)
        {
            if (percentage%10<3)
            {
                letter_grade = "B-";
            }
            else if (percentage%10>=7)
            {
                letter_grade = "B+";
            }
            else
            {
                letter_grade = "B";
            }
        }

        else if (percentage >=70)
        {
            if (percentage%10<3)
            {
                letter_grade = "C-";
            }
            else if (percentage%10>=7)
            {
                letter_grade = "C+";
            }
            else
            {
                letter_grade = "C";
            }
        }

        else if (percentage >=60)
        {
            if (percentage%10<3)
            {
                letter_grade = "D-";
            }
            else if (percentage%10>=7)
            {
                letter_grade = "D+";
            }
            else
            {
                letter_grade = "D";
            }
        }

        else
        {
            letter_grade = "F";
        }

        Console.WriteLine($"Your grade is: {letter_grade}");

    }
}