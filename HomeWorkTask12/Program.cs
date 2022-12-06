Console.WriteLine("Vvedi chislo");
int a = Convert.ToInt32(Console.ReadLine());

int Dlina_Chisla(int chislo)
{
    int dlina = 1;
    while (chislo / 10 != 0)
    {
        chislo = chislo / 10;
        dlina = dlina + 1;
    }
    return dlina;
}
int n = Dlina_Chisla(a);
Console.WriteLine("N=" + n);

int Stepen(int chislo1, int chislo2)
{
    int stepen = 1;
    for (int i = 1; i <= chislo2; i++)
        stepen = stepen * chislo1;
    return stepen;
}
int sum = 0;
for (int i = 1; i <= n; i++)
{
    int b = a / Stepen(10, n - i) % 10;
    sum += b;
}

Console.WriteLine("Summa tsifr =" + sum);
