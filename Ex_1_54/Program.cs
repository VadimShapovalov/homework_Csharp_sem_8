/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8 */
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
void ArraySorting(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[a, i] > array[a, j])
                {
                    int temp = array[a, i];
                    array[a, i] = array[a, j];
                    array[a, j] = temp;
                }
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк в Вашей матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в Вашей матрице: ");
int column = Convert.ToInt32(Console.ReadLine());
ArraySorting(FillArray(row, column));

