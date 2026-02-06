double firstNum = 0;
double secondNum = 0;
double thirdNum = 0;
double fourthNum = 0;
double fifthNum = 0;

try
{
	Console.WriteLine("Enter first number:");
	firstNum = double.Parse(Console.ReadLine());
}
catch (Exception)
{
	Console.WriteLine("You should enter digital number!");
}
try
{
	Console.WriteLine("Enter second number:");
	secondNum = double.Parse(Console.ReadLine());
}
catch (Exception)
{
	Console.WriteLine("You should enter digital number!");
}
try
{
	Console.WriteLine("Enter third number:");
	thirdNum = double.Parse(Console.ReadLine());
}
catch (Exception)
{
	Console.WriteLine("You should enter digital number!");
}
try
{
	Console.WriteLine("Enter fourth number:");
	fourthNum = double.Parse(Console.ReadLine());
}
catch (Exception)
{
	Console.WriteLine("You should enter digital number!");
}
try
{
	Console.WriteLine("Enter fifth number:");
	fifthNum = double.Parse(Console.ReadLine());
}
catch (Exception)
{
	Console.WriteLine("You should enter digital number!");
}
double divider = 5;
double average = (firstNum + secondNum + thirdNum + fourthNum + fifthNum) / divider;
Console.WriteLine("Average of 5 numbers is " + average);