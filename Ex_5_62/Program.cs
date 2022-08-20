/* Задача 62. Заполните спирально массив 4 на 4. Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 */
void Spiral()
{
    Console.WriteLine("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int [ , ] array = new int [n , n ];
    int x = 0;
    int y = 0;
    int z = 1;
    int zero = 0;
    int num = n*n;
    array [y, x]= z;
    for( x = 0; z <= num; x++, y++, n--, zero++)
    {
        for(; x < n; z++, x++ )
        {
            array [y, x]= z;
        }
        x = n - 1;
        for(y = y + 1; y < n; z++, y++)
        {  
            array [y, x] = z;
        }
        x = x - 1;
        y = y-1;
        while(x >= zero)
        {    
            array [y, x] = z;
            z++;
            x--;
        }
        x = x + 1;
        y = y - 1;
        while(y > zero)
        {
            array [y, x] = z;
            z++;
            y--;
        }
    }
    int height = array.GetLength(0);
    int width = array.GetLength(1);

    for(y=0; y<height; y++)
    {
        for(x = 0; x<width; x++)
        {
            Console.Write(array[y,x] + "\t");
        }
        Console.WriteLine();
    }
}
Spiral();