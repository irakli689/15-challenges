////Console.WriteLine("Enter size of first side");
////double firstSide = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter size of second side");
//double secondSide = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter size of third side");
//double thirdSide = int.Parse(Console.ReadLine());
double perimeter = 0;
double firstSide = 0;
double secondSide = 0;
double thirdSide = 0;
try
{
	Console.WriteLine("Enter size of first side");
	firstSide = int.Parse(Console.ReadLine());	
}
catch (Exception)
{
	Console.WriteLine("You should enter number");
}

try
{
	Console.WriteLine("Enter size of second side");
	secondSide = int.Parse(Console.ReadLine());
}
catch (Exception)
{
	Console.WriteLine("You should enter number");
}

try
{
	Console.WriteLine("Enter size of third side");
	thirdSide = int.Parse(Console.ReadLine());
}
catch (Exception)
{
	Console.WriteLine("You should enter number");
}

perimeter = firstSide + secondSide + thirdSide;
Console.WriteLine("Perimeter of triangle is " + perimeter);