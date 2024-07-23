Console.WriteLine("Ingrese un numero");
int a = int.Parse(Console.ReadLine());
string s = "0";
if (a < 1) s = "01";
for (int i = 1; i < a; i++)
{
    int serie;
    serie = 0;
    for (int j = 0; j < i; j++)
    {
        serie = serie * 10 + i;
    }

    s += serie.ToString();
}
if (a == 0) Console.WriteLine("0");
if (a == 1) a += 1;
for (int i = 0; i < a; i++)
{
    Console.Write(s[i]);
}
