int function(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return function(m - 1, 1);
  else return function(m - 1, function(m, n - 1));
}

Console.WriteLine(function(3,2));