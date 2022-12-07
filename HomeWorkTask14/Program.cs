Console.WriteLine("Enter massiv size");
int n = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[n];
Console.WriteLine("Enter massiv elements");

void WriteInArray(int[] array)
{
    for (int ind = 0; ind < array.Length; ind++)
    {
        array[ind] = new Random().Next(1, 1000);
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

int ChetnyyElement(int[] array)
{
    int kolvo = 0;
    for (int i =0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            kolvo = kolvo + 1;
        }
    }
    return kolvo;
}

WriteInArray(massiv);
PrintToScreen(massiv);
int k = ChetnyyElement(massiv);
Console.WriteLine("Number of even elements=" + k);
