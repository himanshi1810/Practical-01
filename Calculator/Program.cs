// See https://aka.ms/new-console-template for more information
Calculator.CalculatorClass calc = new Calculator.CalculatorClass();
double num1;
double num2;

//Ask the user to enter the first number
Console.WriteLine("Enter Your First Number That you want to calculate :- ");
num1 = Convert.ToDouble(Console.ReadLine());
//Ask the user to enter the second number
Console.WriteLine("Enter Your Second Number That you want to calculate :- ");
num2 = Convert.ToDouble(Console.ReadLine());

//Calculation of the numbers
Console.WriteLine($"The sum of {num1} and {num2} is :- {calc.Add(num1,num2)}" );
Console.WriteLine($"The subtraction of {num1} and {num2} is :- {calc.Subtract(num1,num2)}" );
Console.WriteLine($"The Multiplication of {num1} and {num2} is :- {calc.Multiply(num1,num2)}" );

//For divion we need to check if the second number is not zero
if (num2 != 0)
{
    Console.WriteLine($"The Division of {num1} and {num2} is :- {calc.Divide(num1, num2)}");
}
else
{
    Console.WriteLine("Division by zero is not allowed.");
}

