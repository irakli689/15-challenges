Console.WriteLine("Enter first number:");
int firstNum = 0;
try
{
	firstNum = int.Parse(Console.ReadLine());
}
catch (Exception)
{
	Console.WriteLine("You should enter number!");
}

Console.WriteLine("Enter second number:");
int secondNum = 0;
try
{
	secondNum = int.Parse(Console.ReadLine());
}
catch (Exception)
{
	Console.WriteLine("You should enter number!");
}

Console.WriteLine("Enter third number:");
int thirdNum = 0;
try
{
	thirdNum = int.Parse(Console.ReadLine());
}
catch (Exception)
{
	Console.WriteLine("You should enter number!");
}

if (firstNum <= secondNum && firstNum <= thirdNum)
{
	Console.WriteLine("Minimum number is " + firstNum);
}
else if (secondNum <= firstNum && secondNum <= thirdNum)
{
	Console.WriteLine("Minimum number is " + secondNum);
}
else
{
	Console.WriteLine("Minimum number is " + thirdNum);
}
