/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */
int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Console.WriteLine();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}
void FindRowWithMinSum(int[,] array)
{
    int minSum = 0;
    int i = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum = minSum + array[i, j];
    }
    int rowWithMinSum = 0;
    for (i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            rowWithMinSum = i;
        }
    }
    Console.WriteLine($"Строка номер: {rowWithMinSum + 1} имеет минимальную сумму элементов: {minSum}.");
}
Console.WriteLine("Введите количество строк в Вашей матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в Вашей матрице: ");
int column = Convert.ToInt32(Console.ReadLine());
FindRowWithMinSum(FillArray(row, column));