// Kata 2: FizzBuzz from 1 to 20
// ** OBJECTIVE** Create your own loop using the following logic**
// Commit 1: "scaffold for loop"
for (int Set; Condition; Increment)
        {
            // body
        }
// Commit 2: "added fizzbuzz logic"
for (int i = 1; i <= 20; i++)
        {
            if (i % 3 == 0 & i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
// Commit 3: "refactored with clear variable and comments"
for (int number = 1; number <= 20; number++) // loop from 1 to 20
{
    if (number % 3 == 0 && number % 5 == 0) // if divisible by 3 and 5
    {
        Console.WriteLine("FizzBuzz"); // print FizzBuzz
    }
    else if (number % 3 == 0) // if divisible by 3
    {
        Console.WriteLine("Fizz"); // print Fizz
    }
    else if (number % 5 == 0) // if divisible by 5
    {
        Console.WriteLine("Buzz"); // print Buzz
    }
    else // if not divisible by 3 or 5
    {
        Console.WriteLine(number); // print number
    }
}