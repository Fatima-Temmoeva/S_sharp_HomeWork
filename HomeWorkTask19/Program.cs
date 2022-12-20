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
    
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(String.Format("{0,6:F2}", mass[i, j]));
    }
    Console.WriteLine();
}
   
