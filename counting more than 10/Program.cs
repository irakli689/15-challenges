Console.WriteLine("Write first number");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Write second number");
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine("Write third number");
int thirdNum = int.Parse(Console.ReadLine());
int moreThanTenCount = 0;
if (firstNum > 10)
{
	moreThanTenCount++;
}
if (secondNum > 10)
{
	moreThanTenCount++;
}
if (thirdNum > 10)
{
	moreThanTenCount++;
}
Console.WriteLine("Number of numbers more than 10 is " + moreThanTenCount);
