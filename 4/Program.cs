// Метод заполнения двумерного массива спирально
void FillArraySpirally(int[,] arr)
{
    int numb = 1;
    int i = 0;
    int j = 0;

    while (numb <= arr.GetLength(0) * arr.GetLength(0))
    {
        arr[i, j] = numb;
        if (i <= j + 1 && i + j < arr.GetLength(0) - 1)
        ++j;
        else if (i < j && i + j >= arr.GetLength(0) - 1)
        ++i;
        else if (i >= j && i + j > arr.GetLength(0) - 1)
        --j;
        else
        --i;
        ++numb;
    }
}

// Метод печати элементов массива
void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4,4];
FillArraySpirally(array);
PrintArray(array);