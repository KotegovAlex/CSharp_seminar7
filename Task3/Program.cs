/* Задача 3: Задайте двумерный массив. Найдите сумму 
элементов главной диагонали. Например, задан массив:
1   4   7
5   9   2
8   4   2
Сумма элементов главной диагонали: 1+9+2 = 12 */

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

int MainDiagonalElementsSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sum = sum + array[i, j];
        }
    }
    return sum;
}

int rows = Promt("Введите количество строк > ");
int columns = Promt("Введите количество столбцов > ");
int[,] matrix = GenerateArray(rows, columns, -10, 10);
PrintArray(matrix);

int sum = MainDiagonalElementsSum(matrix);
System.Console.WriteLine($"Сумма элементов главной диагонали равна: {sum}");