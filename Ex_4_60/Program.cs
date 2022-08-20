//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)
void FillArrayDoubleDigit()
{
    Console.WriteLine("Введите размер первого измерения трехмерного массива: ");
    int height = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите размер второго измерения трехмерного массива: : ");
    int width = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите размер третьего измерения трехмерного массива: ");
    int depth = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[height, width, depth];
    List<int> spisok = new List<int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int b = 0; b < array.GetLength(2); b++)
            {
                int rnd = new Random().Next(10, 100);
                if (!(spisok.Contains(rnd)))
                {
                    array[i, j, b] = rnd;
                    spisok.Add(rnd);
                    Console.Write($"{array[i, j, b]}({i},{j},{b})\t");
                }
                else b--;
            }
            Console.WriteLine();
        }
    }
}
FillArrayDoubleDigit();
