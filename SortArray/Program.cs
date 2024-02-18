int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

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
            //Расчитываем и сохраняем в кортеж индексы текущего и следующего элементов
            var currentElement = (row: j / array.GetLength(1), column: j % array.GetLength(1));
            var nextElement = (row: (j + 1) / array.GetLength(1), column: (j + 1) % array.GetLength(1));

            if (array[currentElement.row, currentElement.column] > array[nextElement.row, nextElement.column])
            {
                temp = array[currentElement.row, currentElement.column];
                array[currentElement.row, currentElement.column] = array[nextElement.row, nextElement.column];
                array[nextElement.row, nextElement.column] = temp;
            }
        }
    }
}