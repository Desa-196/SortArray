int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 }};

arraySort(a);
arrayPrint(a);


//Функция вывода двумерного массива
void arrayPrint(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.Write("\n");
    }
}


//Функция сортировки двумерного массива
void arraySort(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            Console.WriteLine($"{j / array.GetLength(1)}, {j % array.GetLength(1)}");
            if (array[j / array.GetLength(1), j % array.GetLength(1)] > array[(j + 1) / array.GetLength(1), (j + 1) % array.GetLength(1)])
            {
                temp = array[j / array.GetLength(1), j % array.GetLength(1)];
                array[j / array.GetLength(1), j % array.GetLength(1)] = array[(j + 1) / array.GetLength(1), (j + 1) % array.GetLength(1)];
                array[(j + 1) / array.GetLength(1), (j + 1) % array.GetLength(1)] = temp;
            }
        }
    }
}