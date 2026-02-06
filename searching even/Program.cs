Console.WriteLine("Write first number");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Write second number");
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine("Write third number");
int thirdNum = int.Parse(Console.ReadLine());
if(firstNum%2==0 || secondNum%2==0 || thirdNum % 2 == 0)
{
	Console.WriteLine("There is even number");
}
else
{
	Console.WriteLine("There is no even number");
}