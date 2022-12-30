
int Fun(int N, int M)
{
    //string c = "Ошибка";
    if(M == N) return N;
    //else if(M > N) return c;
    else return M + Fun(N, M + 1); 
}

int n = 10;
int m = 7;

Console.WriteLine(Fun(n, m));
