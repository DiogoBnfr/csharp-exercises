bool runAgain = true;
while (runAgain)
{
    double x, y;
    string userIn;
    Console.WriteLine("::::: CALCULATOR :::::");
    Console.Write("Enter number X: ");
    x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter number Y: ");
    y = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Choose an option:" + "\n" +
                      "\t+ : Add" + "\n" +
                      "\t- : Subtract" + "\n" +
                      "\t* : Multiply" + "\n" +
                      "\t/ : Divide");
    Console.Write("Enter an option: ");
    userIn = Console.ReadLine().ToLower();
    Console.WriteLine();
    switch (userIn)
    {
        case "+":
            Console.WriteLine("Result: " + x + " + " + y + " = " + (x + y));
            break;
        case "-":
            Console.WriteLine("Result: " + x + " - " + y + " = " + (x - y));
            break;
        case "*":
            Console.WriteLine("Result: " + x + " * " + y + " = " + (x * y));
            break;
        case "/":
            Console.WriteLine("Result: " + x + " / " + y + " = " + (x / y));
            break;
    }
    Thread.Sleep(1000);
    
    while (userIn != "y" && userIn != "n")
    {
        Console.Write("\nWant to continue (y = yes, n = no)? ");
        userIn = Console.ReadLine().ToLower();
        Console.WriteLine();
    }

    if (userIn == "n")
    {
        Console.WriteLine("See you next time!");
        runAgain = false;
    }
}
