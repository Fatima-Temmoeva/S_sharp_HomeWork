Console.WriteLine("Enter massiv size");
int n = Convert.ToInt32(Console.ReadLine());
double[] massiv = new double[n];
Console.WriteLine();
Console.WriteLine("Enter massiv elements");

void WriteInArray(double[] array)
{
    for (int ind = 0; ind < array.Length; ind++)
    {
        array[ind] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintToScreen(double[] arr)
{
    int index = 0;
    int dlina = arr.Length;
    while (index < dlina) 
    {
        Console.Write(arr[index] + " ");
        index++;
    }
}

double BolsheNulya(double[] array)
{
    int schetchik = 0;
    for (int i =0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            schetchik = schetchik + 1;
        }
    }
    return schetchik;
}

WriteInArray(massiv);
Console.WriteLine();
Console.WriteLine("Massive");
PrintToScreen(massiv);
Console.WriteLine();
double kolichestvo = BolsheNulya(massiv);
Console.WriteLine("Kolichestvo elementov bol'she 0 = " + kolichestvo);