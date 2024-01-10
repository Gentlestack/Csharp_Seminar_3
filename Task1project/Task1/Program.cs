int M = 1;
int N = 10;

Console.WriteLine();
void WriteNumbers(int a, int b)
{
    a = a + 1;

    if (a != b)
    {
        Console.WriteLine(a);
        WriteNumbers(a, b);
    }
    Console.WriteLine("Ура, наконец то эта ебливая рекурсия закончилась");
}

WriteNumbers(M, N);

