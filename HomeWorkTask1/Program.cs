Console.Write("Enter first number a = ");     //Vvodim chislo a
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number b = ");    //Vvodim chislo b
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;                                  //VVodim peremennyu max, v nee bydem zapisivat' maksimal'noe znachenie 
if (a > b)                                    // Proveryaem yslovie
{
    max = a;                                  // Esli yslovie vypolnyaetsya prisvaevaem max znachenie a
    Console.Write("a > b, max = ");
    Console.WriteLine(max);
}
else
{
    max = b;
    Console.Write("a < b, max = ");
    Console.WriteLine(max);
}