double num1;
double num2;
double num3;

Console.Write("Input the first number: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input the second number: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input the third number: ");
num3 = Convert.ToDouble(Console.ReadLine());

double multiply = num1 * num2 * num3;
Console.WriteLine("The multiply is " + multiply);

double avg = (num1 + num2 + num3)/3;
Console.WriteLine("The average is " + avg);