string? input;
int number;
bool isValidNumber = false;

do
{
    Console.WriteLine("Enter an integer value between 5 and 10:");

    input = Console.ReadLine();
    _ = int.TryParse(input, out number);

    if (number >= 5 && number <= 10)
    {
        isValidNumber = true;
        Console.WriteLine($"Your input value ({number}) has been accepted.");
    } else if (number != 0)
    {
        Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10");
    } else
    {
        Console.WriteLine("Sorry, you entered an invalid number. Please try again");
    }

} while (!isValidNumber);
