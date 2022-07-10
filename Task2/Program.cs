/* Задача 2: Задайте двумерный массив. Найдите элементы, 
у которых обе позиции чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4 

Новый массив будет выглядеть 
вот так:
1   4  7  2
5  81  2  9
8   4  2  4 */ 

int Promt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(min, max + 1);
        }
    }
    return answer;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }

    }
    System.Console.WriteLine();
}

int[,] SwapEvenPosition(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i=i+2)
    {
        for (int j = 1; j < array.GetLength(1); j=j+2)
        {
            array[i, j] = array[i, j]*array[i,j];
        }
    }
    return array;
}

int rows = Promt("Введите количество строк > ");
int columns = Promt("Введите количество столбцов > ");
int[,] matrix = GenerateArray(rows, columns, -10, 10);
PrintArray(matrix);
System.Console.WriteLine();
int[,] array2 = SwapEvenPosition(matrix);
PrintArray(array2);