Console.WriteLine("Write first number");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Write second number");
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine("Write third number");
int thirdNum = int.Parse(Console.ReadLine());
int oddCount = 0;
if (firstNum%2==1)
{
	oddCount++;
}
if (secondNum % 2 == 1)
{
	oddCount++; 
}
if (thirdNum%2==1)
{
	oddCount++;
}
Console.WriteLine("Number of odds is " + oddCount);