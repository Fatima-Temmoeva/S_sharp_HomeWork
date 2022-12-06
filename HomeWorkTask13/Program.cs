Console.WriteLine("Enter massiv size");
int n = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[n];
int i = 0;
Console.WriteLine("Enter massiv elements");
while (i < massiv.Length)
{
    massiv[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
Console.Write("[");
for (i = 0; i < massiv.Length; i++)
{
    if (i == massiv.Length - 1)
    {
        Console.Write(massiv[i]);
    }
    else
    {
        Console.Write(massiv[i] + " ");
    }
}
Console.Write("]");
