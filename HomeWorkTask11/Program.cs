Console.WriteLine("Vvedi chislo dlya vozvedeniya v stepen'");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedi stepen'");
int B = Convert.ToInt32(Console.ReadLine());
int st = 1;
for (int i = 1; i <= B; i++ )
st = st * A;
Console.Write("Stepen' chisla A = " + st);
Console.WriteLine();
