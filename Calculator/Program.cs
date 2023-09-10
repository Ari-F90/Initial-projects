// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the C# calculator");
Console.WriteLine("Enter your name: ");
string username = Console.ReadLine();



Console.WriteLine("Enter the first number");
double firstNumber = double.Parse(Console.ReadLine());
Console.WriteLine($"{username}: {firstNumber}");
