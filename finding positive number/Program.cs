Console.WriteLine("Write first number");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Write second number");
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine("Write third number");
int thirdNum = int.Parse(Console.ReadLine());
if (firstNum > 0 || secondNum > 0 || thirdNum > 0)
{
	Console.WriteLine("There is positive number");
}
else
{
	Console.WriteLine("There is no positive number");
}
