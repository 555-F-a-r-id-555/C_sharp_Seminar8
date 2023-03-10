// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести 
// сообщение для пользователя.

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
    int[,] newMatrix2 = new int[newMatrix.GetLength(1), newMatrix.GetLength(0)];
    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            newMatrix2[j, i] = newMatrix[i, j];
        }
    }
    printMatrix(newMatrix2, n, m);
    return newMatrix;
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