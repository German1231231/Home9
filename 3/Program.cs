int AckermanFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermanFunction(m - 1, 1);
  else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.WriteLine(AckermanFunction(3,2));