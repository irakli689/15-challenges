Console.WriteLine("Enter first numer:");
int firstNum = 0;
try
{
	firstNum = int.Parse(Console.ReadLine());
}
catch (Exception)
{
	Console.WriteLine("You should enter number!");
}
Console.WriteLine("Enter second numer:");
int secondNum = 0;
try
{
	secondNum = int.Parse(Console.ReadLine());
}
catch (Exception)
{
	Console.WriteLine("You should enter number!");
}
if (firstNum < secondNum)
{
	Console.WriteLine("Minimum number is " + firstNum);
}
else if (firstNum > secondNum)
{
	Console.WriteLine("Minimum number is " + secondNum);
}
else
{
	Console.WriteLine("These numbers are equal!");
}
