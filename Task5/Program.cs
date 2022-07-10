/* Задача 5: Сгенерировать 3-хмерную матрицу, 
4х4х4 - заполнить ее неповторяющимися случаными значениями, вывести на экран. */

int Promt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,,] GenerateThreeDimensionArray(int rows, int columns, int lines, int min, int max)
{
    int[,,] array = new int[rows, columns, lines];
    Random rnd = new Random();
    int temp = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < lines; k++)
            {
                do
                {
                    temp = rnd.Next(min, max + 1);
                } while (FindExist(array, temp));
                array[i, j, k] = temp;
            }
        }
    }
    return array;
}

bool FindExist(int[,,] array, int find)
{
    foreach (int n in array)
    {
        if (n == find)
        {
            return true;
        }
    }
    return false;
}

void PrintThreeDimensionArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine($"Слой {i}");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}\t");
            }
            System.Console.WriteLine();
        }

    }
    System.Console.WriteLine();
}

int rows = Promt("Введите количество строк > ");
int columns = Promt("Введите количество столбцов > ");
int lines = Promt("Введите количество рядов > ");
int[,,] matrix = GenerateThreeDimensionArray(rows, columns, lines, 1, 999);
PrintThreeDimensionArray(matrix);