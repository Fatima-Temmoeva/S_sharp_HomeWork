Console.WriteLine("Enter 3 number");
Console.Write("Enter first number a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number b =");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number c =");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > b) 
{
  max = a;
  if (max > c)
  {
    Console.WriteLine("a maximum number");
    Console.WriteLine(max);
  }
  else
  {
    max = c;
    Console.WriteLine("c maximum number");
    Console.WriteLine(max);
  }
}
else 
{
    max = b;
    if (max > c)
    {
      Console.WriteLine("b maximum number");
      Console.WriteLine(max);  
    }
    else 
    {
      max = c;
      Console.WriteLine("c maximum number");
      Console.WriteLine(max);
    }
}