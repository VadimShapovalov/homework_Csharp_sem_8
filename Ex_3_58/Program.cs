/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49 */
//int[][,,]array = new int [3][,,];
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

void Multiplication(int[,] array, int [,] array2)
{
    int[,] array3 = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array3[i, j] = array[i, j] * array2[i, j];
            Console.Write(array3[i, j] + "\t");
        }
    Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк в Вашей матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в Вашей матрице: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(row, column);
int[,] array2 = FillArray(row, column);
Multiplication(array, array2);
