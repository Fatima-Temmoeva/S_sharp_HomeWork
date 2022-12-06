Console.WriteLine("Vvedi chislo dlya vozvedeniya v stepen'");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedi stepen'");
int B = Convert.ToInt32(Console.ReadLine());

int Stepen(int chislo1, int chislo2)
{
    int stepen = 1;
    for (int i = 1; i <= chislo2; i++)
        stepen = stepen * chislo1;
    return stepen;
}

int st = Stepen(A, B);
Console.Write("Stepen' chisla A = " + st);
Console.WriteLine();
