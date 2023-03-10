// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


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

int[,] newMatrix(int m, int n)
{
    int[,] newMatrix1 = randomMatrix(m, n);
    int[,] newMatrix2 = randomMatrix(m, n);
    printMatrix(newMatrix1, m, n, 1);
    printMatrix(newMatrix2, m, n, 2);
    int[,] newMatrix3 = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newMatrix3[i, j] = newMatrix1[i, j] * newMatrix2[i, j];
        }
    }
    printMatrix(newMatrix3, m, n, 3);
    return newMatrix3;
}


void printMatrix(int[,] matrix, int m, int n, int MatrixNumber)
{
    Console.WriteLine($"matrix_{MatrixNumber}[{m}x{n}] = " + "\n{");
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

newMatrix(m1, n1);