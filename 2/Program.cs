
int FindingTheAmount(int N, int M)
{
    //string c = "Ошибка";
    if(M == N) return N;
    //else if(M > N) return c;
    else return M + FindingTheAmount(N, M + 1); 
}

int n = 10;
int m = 7;

Console.WriteLine(FindingTheAmount(n, m));
