Console.Write("Enter number a = ");  
int number = Convert.ToInt32(Console.ReadLine());
if (number / 10000 == 0)
{
    Console.WriteLine("Resheniy net");
}
else
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
    {
      Console.WriteLine("Chislo - palindrome");  
    }
    else
    {
      Console.WriteLine("Chislo - NE palindrome");  
    }
}
   
