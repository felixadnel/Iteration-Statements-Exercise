namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsEqual(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            return false;
        }
        //Write a method to check whether a given number is even or odd
        public static string CheckEvenOdd(int number)
        {
            return number % 2 == 0 ? "even" : "odd";
        }
        //Write a method to check whether a given number is positive or negative
        public static string CheckPositiveNegative(int number)
        {
            if (number > 0)
            {
                return "positive";
            }
            else if (number < 0)
            {
                return "negative";
            }
            else
            {
                return "zero";
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void CheckVotingEligibility(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool IsInRange()
        {
            Console.WriteLine("Enter an integer: ");
            string input = Console.ReadLine();
            int number;

            if (int.TryParse(input, out number))
            {
                return number >= -10 && number <= 10;
            }

            return false;
        }




        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");


                //Call the methods to test them in the Main method below
                static void Main(string[] args)
                {
                    PrintThousand();
                    Threes();
                    Console.WriteLine(IsEqual(5, 5));
                    Console.WriteLine(CheckEvenOdd(7));
                    Console.WriteLine(CheckPositiveNegative(-3));
                    CheckVotingEligibility(20);
                    Console.WriteLine(IsInRange());
                    DisplayMultiplicationTable(7);
                }

            }
        }
    }

}




        
