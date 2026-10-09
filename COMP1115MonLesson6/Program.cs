//// Ex 1 - basic while loop (infinite until a condition is met)
//Console.WriteLine("What is 5 + 7?");
//int answer = int.Parse(Console.ReadLine());

//// repeat asking the question until we get the correct answer.  != means NOT EQUALS 
//while (answer != 12)
//{
//    Console.WriteLine("Incorrect, please try again");
//    answer = int.Parse(Console.ReadLine()); // update answer value with new user input
//}

//// this only executes once the user successfully meets the condition in the loop (provides right answer)
//Console.WriteLine("Correct!");

//// Ex 2 - do while loop (runs at least once then forever until condition is met)
//// in c#, comparing string values is case-sensitive ("No", "NO", and "no" are not equal)
//string choice;
//do
//{
//    Console.WriteLine("Play again? (yes/no)");
//    choice = Console.ReadLine().ToLower(); // convert answer to all lowercase so not case-sensitive
//} while (choice != "no");

// Ex 3 - finite loop for `for`: loop from starting # to a stopping #, and set the increment (usually 1 but not always)
// i++ is the same as i = i + 1 (add 1 to the current value)
//for (int i = 1; i <= 10; i++)
//{
//    if (i == 5)
//    {
//        break;  // stop at 5 before printing
//    }
//    if (i % 2 == 1)
//    {
//        continue; // skip odd numbers.  go to next iteration without printing the current #
//    }
//    Console.WriteLine(i);
//}

//// Ex 4 - `for` loop incrementing by 10 not 1
//for (int i = 0; i <= 100; i = i + 10)
//{
//    Console.WriteLine(i);
//}

//// Ex 5 - `for` loop decrementing by 10
//for (int i = 100; i >= 0; i = i - 10)
//{
//    Console.WriteLine(i);
//}

// Ex 6 - refactor to include a loop
Console.WriteLine("Welcome to C# Trivia!");
int answer;

// run this loop infinitely until user gets right answer
do
{
    Console.WriteLine("How many bits are in a byte? ");
    answer = int.Parse(Console.ReadLine());

    // answer was wrong, prompt user to retry
    if (answer != 8)
    {
        Console.WriteLine("Wrong! The answer is 8.");
    }
} while (answer != 8);

// only show correct message once user has successfully exited the loop by giving the right answer
Console.WriteLine("Correct!");
