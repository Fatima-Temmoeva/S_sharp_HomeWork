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

double MaximumElement(double[] array)
{
    double maximum = array[1];
    for (int i =0; i < array.Length; i++)
    {
        if(array[i] > maximum)
        {
            maximum = array[i];
        }
    }
    return maximum;
}

double MinimumElement(double[] array)
{
    double minimum = array[1];
    for (int i =0; i < array.Length; i++)
    {
        if(array[i] < minimum)
        {
            minimum = array[i];
        }
    }
    return minimum;
}

WriteInArray(massiv);
Console.WriteLine();
Console.WriteLine("Massive");
PrintToScreen(massiv);
Console.WriteLine();
double maxx = MaximumElement(massiv);
Console.WriteLine("Maximum array elements = " + maxx);
double minn = MinimumElement(massiv);
Console.WriteLine();
Console.WriteLine("Minimum array elements = " + minn);
double razn = maxx - minn;
Console.WriteLine();
Console.WriteLine("Difference between the maximum and minimum elements of the array = " + razn); 
Console.WriteLine();