Random random = new Random();

bool playAgain = true;
const int min = 1;
const int max = 10;
int number;
int guess;
int guesses;

while (playAgain)
{
    number = random.Next(min, max + 1);
    guess = 0;
    guesses = 0;

    while (guess != number)
    {
        Console.Write("Guess a number between " + min + " - " + max + ": ");
        guess = Convert.ToInt32(Console.ReadLine());
        guesses++;
        
        if (guess == number)
        {
            Console.WriteLine("You're right!");
            Console.WriteLine("Attempts: " + guesses);
            break;
        }

        if (guess > number)
        {
            Console.WriteLine(guess + " is too high!");
        }
        if (guess < number)
        {
            Console.WriteLine(guess + " is too low!");
        }
    }

    while (true)
    {
        Console.Write("Want to play again (y/n)? ");
        string userInput = Console.ReadLine().ToLower();

        if (userInput == "y" || userInput == "yes")
        {
            break;
        }
        if (userInput == "n" || userInput == "no")
        {
            Console.WriteLine("See you next time!");
            playAgain = false;
            break;
        }
        Console.WriteLine("Invalid argument! Please, try again.");
    }
}
