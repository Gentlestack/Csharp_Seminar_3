
int M = 1;
int N = 10;

int LeviAccerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if ((m > 0) && (n == 0))
    {
        return LeviAccerman(m - 1, 1);
    }
    else
    {
        return LeviAccerman(m - 1, LeviAccerman(m, n - 1));
    }
}

Console.WriteLine(LeviAccerman(M, N));