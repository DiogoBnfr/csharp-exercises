bool playAgain = true;
string options = "rps";
while (playAgain)
{
    string player = "";
    string computer;
    Console.WriteLine(":::: ROCK, PAPER, SCISSORS GAME :::::");
    Console.WriteLine("\t- (N)ew Game" + Environment.NewLine +
                      "\t- (H)elp" + Environment.NewLine +
                      "\t- (Q)uit");

    while (player != "n" && player != "h" && player != "q")
    {
        Console.Write("Enter your option: ");
        player = Console.ReadLine().ToLower();
    }

    if (player == "n")
    {
        Random random = new Random();
        int index = random.Next(0, 3);
        computer = options[index].ToString();
        Console.Write("\t(R)ock" + "\n" +
                      "\t(P)aper" + "\n" +
                      "\t(S)cissors" + "\n");
        while (player != "r" && player != "p" && player != "s")
        {
            Console.Write("Choose one of the options: ");
            player = Console.ReadLine().ToLower();
        }
        
        if (player == computer)
        {
            Console.WriteLine("\n" + "Player: " + player.ToUpper());
            Console.WriteLine("Computer: " + computer.ToUpper());
            Console.WriteLine("Draw!" + "\n");
        }
        else if (player == "r" && computer == "s" || 
            player == "s" && computer == "p" ||
            player == "p" && computer == "r")
        {
            Console.WriteLine("\n" + "Player: " + player.ToUpper());
            Console.WriteLine("Computer: " + computer.ToUpper());
            Console.WriteLine("You win!" + "\n");
        }
        else
        {
            Console.WriteLine("\n" + "Player: " + player.ToUpper());
            Console.WriteLine("Computer: " + computer.ToUpper());
            Console.WriteLine("You lose!" + "\n");
        }
        Thread.Sleep(2000);
    }

    if (player == "h")
    {
        Console.WriteLine(
            "\n" + "The game consists of choosing one of the options (rock, paper, or scissors) and seeing what your opponent" + "\n" +
            "has chosen as well. All the options have a symmetric correlation where each option can defeat only one of" +
            "\n" +
            "the others and vice versa." + "\n" + "\n" +
            "In practice, the game compares the chosen values and gives you a result based on this. Here's a table that shows" +
            "\n" +
            "which option wins over the other:" + "\n" + "\n" +
            "\tRock > Scissors" + "\n" +
            "\tScissors > Paper" + "\n" +
            "\tPaper > Rock" + "\n" + "\n" +
            "Note: The option on the left wins over the option on the right." + "\n");
        Thread.Sleep(3000);
    }

    if (player == "q")
    {
        Console.WriteLine("See you next time!");
        playAgain = false;
    }
}



              