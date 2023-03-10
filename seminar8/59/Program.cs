// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] randomMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            matrix[i, j] = Random.Shared.Next(0, 10);
    };
    return matrix;
}

int[,] Matrix(int m, int n)
{
    int[,] newMatrix = randomMatrix(m, n);
    printMatrix(newMatrix, m, n);
    int min = newMatrix[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (newMatrix[i, j] < min)
            {
                min = newMatrix[i, j];
                row = i;
                column = j;
            }
        }
    }
    Console.WriteLine($"row = {row} column = {column}");
    int[,] newMatrix2 = new int[m - 1, n - 1];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i < row && j < column)
            {
                newMatrix2[i, j] = newMatrix[i, j];
            }
            else if (i > row && j > column)
            {
                newMatrix2[i - 1, j - 1] = newMatrix[i, j];
            }
            else if (i > row && j < column)
            {
                newMatrix2[i - 1, j] = newMatrix[i, j];
            }
            else if (i < row && j > column)
            {
                newMatrix2[i, j - 1] = newMatrix[i, j];
            }


        }
    }
    printMatrix(newMatrix2, m - 1, n - 1);
    return newMatrix2;
}


void printMatrix(int[,] matrix, int m, int n)
{
    Console.WriteLine($"matrix[{m}x{n}] = " + "\n{");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("}");
}


int m1 = ReadNumber("Введите количество строк:");
int n1 = ReadNumber("Введите количество столбцов:");

Matrix(m1, n1);