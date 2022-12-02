Console.Write("Enter number a = ");  
int number = Convert.ToInt32(Console.ReadLine());
int ost = 0;
if (number / 100 == 0)
{
    Console.WriteLine("Resheniy net");
}
else
{
    while (number / 1000 != 0)
        number = number / 10;
    ost = (number % 100) % 10; 
}
   Console.WriteLine(ost);


