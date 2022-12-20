Console.WriteLine("Razmernost' massiva");
Console.WriteLine("Vvedi kolichestvo strok n=");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedi kolichestvo stolbtsov m=");
int m = Convert.ToInt32(Console.ReadLine());
int [,] mass = new int [n, m];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j =0; j < m; j++)
    {
        mass[i, j] = random.Next(10);
    }
}
Console.WriteLine("Massiv");    
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(String.Format("{0,6}", mass[i, j]));
    }
    Console.WriteLine();
}
int sum = 0;
double sred = 0;
for (int j = 0; j < m; j++)
{
    for (int i = 0; i < n; i++)
    {
        sum = sum + mass[i,j];       
    }
    sred = (double) sum / n;
    Console.WriteLine("Srednee arifmeticheskoe stolbtsa = " + String.Format("{0,6:F2}", sred));   
}
 