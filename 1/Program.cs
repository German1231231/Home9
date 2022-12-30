// Метод, выполняющий подсчёт чисел от n до 1
string OutputOfNaturalNumbers(int n)
{
    string falls = "Ошибка";
    if(n == 0)
    {
        return string.Empty;
    }
    else if(n > 0) return $"{n} " + OutputOfNaturalNumbers(n - 1);
    else return falls;
}

Console.WriteLine(OutputOfNaturalNumbers(8));