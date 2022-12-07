Console.WriteLine("Enter massiv size");
int n = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[n];
Console.WriteLine("Enter massiv elements");

void WriteInArray(int[] array)
{
    for (int ind = 0; ind < array.Length; ind++)
    {
        array[ind] = new Random().Next(1, 10);
    }
}
void PrintToScreen(int[] arr)
{
    int index = 0;
    int dlina = arr.Length;
    while (index < dlina) 
    {
        Console.WriteLine(arr[index]);
        index++;
    }
}

int NeChetnyyIndex(int[] array)
{
    int summaindex = 0;
    for (int i =0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            summaindex = summaindex + array[i];
        }
    }
    return summaindex;
}

WriteInArray(massiv);
PrintToScreen(massiv);
int sum = NeChetnyyIndex(massiv);
Console.WriteLine("Sum of elements in odd positions=" + sum);
