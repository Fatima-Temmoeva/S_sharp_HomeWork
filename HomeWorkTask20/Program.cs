Console.WriteLine("Razmernost' massiva");
Console.WriteLine("Vvedi kolichestvo strok n=");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedi kolichestvo stolbtsov m=");
int m = Convert.ToInt32(Console.ReadLine());
double [,] mass = new double [n, m];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j =0; j < m; j++)
    {
        mass[i, j] = random.NextDouble()*10;
    }
}
Console.WriteLine("Massiv");    
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(String.Format("{0,6:F2}", mass[i, j]));
    }
    Console.WriteLine();
}
Console.WriteLine("Vvedi pozitsiyu dlya poiska v massive");
Console.WriteLine("Vvedi pozitsiyu v stroke");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedi pozitsiyu v stolbtse");
int l = Convert.ToInt32(Console.ReadLine());
if ((k > n -1) || (l > m -1))
{
    Console.WriteLine("Nevernoe znachenie pozitsiyu");
}
else
{
       Console.WriteLine (String.Format("{0,6:F2}", mass[k,l]));
}