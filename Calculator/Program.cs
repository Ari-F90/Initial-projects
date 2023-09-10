// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello! Please enter your name: ");
string username = Console.ReadLine();
Console.WriteLine($"Welcome {username} to the C# calculator");


Console.WriteLine("Enter the first number: ");
double firstNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
double secondNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the operation that you want to calculate. Examples: +, -, *, / ");
string operation = Console.ReadLine();

double total;
switch(operation)
{
  case "+":
    total = firstNumber + secondNumber;
    Console.WriteLine($"The sum between {firstNumber} and {secondNumber} is {total}.");
    break;
  case "-":
    total = firstNumber - secondNumber;
    Console.WriteLine($"The subtraction between {firstNumber} and {secondNumber} is {total}.");
    break;
  case "*":
    total = firstNumber * secondNumber;
    Console.WriteLine($"The multiplication operation between {firstNumber} and {secondNumber} is {total}.");
    break;
  case "/":
    total = firstNumber / secondNumber;
    Console.WriteLine($"The division between {firstNumber} and {secondNumber} is {total}.");
    break;
  default:
    Console.WriteLine("Operation not valid. Please reload the program.");
    break;
}