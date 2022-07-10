/* Задача 4: Задайте двумерный массив. Введите элемент, 
и найдите первое его вхождение, выведите позиции по 
горизонтали и вертикали, или напишите, что такого элемента нет.
Например, такой массив:
1 4 7 2
5 9 2 3
8 4 2 4

Введенный элемент 2, результат: [1, 4]
Введенный элемент 6, результат: такого элемента нет. */

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

void FindElementPosition(int[,] array, int FindElement)
{
    bool res = false;
    int posI = 0;
    int posJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == FindElement)
            {
                res = true;
                posI = i;
                posJ = j;
                break;
            }
        }
    }
    if (res == true) System.Console.WriteLine($"Введенный элемент {FindElement}, результат: [{posI}, {posJ}]");
    else System.Console.WriteLine($"Введенный элемент {FindElement}, результат: такого элемента нет");
}

int rows = Promt("Введите количество строк > ");
int columns = Promt("Введите количество столбцов > ");
int[,] matrix = GenerateArray(rows, columns, -10, 10);
PrintArray(matrix);

int find = Promt("Введите значение для поиска элемента > ");
FindElementPosition(matrix, find);