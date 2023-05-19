Console.Write("A leg: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("B leg: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

Console.WriteLine("Hypotenuse: " + c);