using System.Text.RegularExpressions;
using Year3ConsoleApp.Basics;
using Year3ConsoleApp.Testing;
using Year3ConsoleApp.Week2;


// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");
start:
// Declare variables and then initialize to zero.
int num1 = 0; int num2 = 0;

// Ask the user to choose an option.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("Press 1 for Addition");
Console.WriteLine("Press 2 for Subtraction");
Console.WriteLine("Press 3 for Multiplication");
Console.WriteLine("Press 4 for Division");
Console.WriteLine("Press 5 for Jagged Arrays");
Console.WriteLine("Press 6 for SingleDimensional Arrays");
Console.WriteLine("Press 7 for ImplicitlyTyped Arrays");
Console.WriteLine("Press 8 for MultiDimensional Arrays");
Console.WriteLine("Press 9 for If-Else Statement Example");
Console.WriteLine("Press 10 for Switch-Case Statement Example");
Console.WriteLine("Press 11 for While Statement Example");
Console.WriteLine("Press 12 for Do-While Statement Example");
Console.WriteLine("Press 13 for For Statement Example");
Console.WriteLine("Press 14 for For-Each Statement Example");
Console.WriteLine("Press 14 for For-Each Statement Example");
Console.Write("Your option? ");


var a = Console.ReadLine();

if (a == "1" || a == "2" || a == "3" || a == "4" || a == "9")
{
    // Ask the user to type the first number.
    Console.WriteLine("Type a number, and then press Enter");
    num1 = Convert.ToInt32(Console.ReadLine());

    // Ask the user to type the second number.
    Console.WriteLine("Type another number, and then press Enter");
    num2 = Convert.ToInt32(Console.ReadLine());
}

if (a == "11" || a == "12" || a == "13")
{
    Console.WriteLine("Type a number, and then press Enter");
    num1 = Convert.ToInt32(Console.ReadLine());
}


// Use a switch statement to do the math.
switch (a)
{
    case "1":
        Calculator.Additions(num1, num2);
        break;
    case "2":
        Calculator.Subtraction(num1, num2);
        break;
    case "3":
        Calculator.Multiplication(num1, num2);
        break;
    case "4":
        Calculator.Division(num1, num2);
        break;
    case "5":
        Arrays.JaggedArray();
        break;
    case "6":
        Arrays.SingleDimensionalArray();
        break;
    case "7":
        Arrays.ImplicitlyTypedArray();
        break;
    case "8":
        Arrays.MultiDimensionalArray();
        break;
    case "9":
        JumpStatement.IfElse(num1, num2);
        break;
    case "10":
        SelectStatement.SwitchCase();
        break;
    case "11":
        IterationStatement.WhileStatement(num1);
        break;
    case "12":
        IterationStatement.DoWhileStatement(num1);
        break;
    case "13":
        IterationStatement.ForLoop(num1);
        break;
    case "14":
        IterationStatement.ForEachLoop();
        break;
    default:
        Interpolation.StringInterpolation();
        break;
}

rerun:
Console.Write("Do you want to run the program again?[y/n]");
var option = Console.ReadLine();

switch (option)
{
    case "y":
        goto start;

    case "n":
        Console.Write("Press any key to close the Calculator console app...");
        Console.ReadKey();
        break;
    default:
        Console.Write("Please select the from the given options.");
        goto rerun;
}