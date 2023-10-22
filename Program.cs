// Declare variables for user input and total
string input;
int total = 0;

// Print Title
Console.WriteLine("Running Total");
Console.WriteLine("=============");

// Loop until Q is enetered
do
{
    // Prompt user
    Console.Write("Enter a number (Q to quit): ");
    input = Console.ReadLine().ToUpper();

    // if Q break loop
    if (input != "Q")
    {
        // parse and add to total
        total += int.Parse(input);
    }
} while (input != "Q");

// Print result
Console.WriteLine($"The sum of the number is {total}.");