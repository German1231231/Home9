// Метод, выполняющий подсчёт чисел от n до 1
string Function(int n)
{
    string falls = "Ошибка";
    if(n == 0)
    {
        return string.Empty;
    }
    else if(n > 0) return $"{n} " + Function(n - 1);
    else return falls;
}

Console.WriteLine(Function(8));