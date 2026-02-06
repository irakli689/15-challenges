Console.WriteLine("Enter number:");
try
{
	int num = int.Parse(Console.ReadLine());
	if (num % 2 == 0)
	{
		Console.WriteLine("Number is even!");
	}
	else
	{
		Console.WriteLine("Number is odd!");
	}
}
catch (Exception)
{
	Console.WriteLine("Youe should enter number!");
}