// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] Matrix(int m, int n)
{
    int[,] newMatrix = new int[m, n];
    newMatrix[0, 0] = 1;
    int i = 0;
    int j = 0;
    int sum = 0;
    while (i == 0 && j < n - 1)
    {
        newMatrix[0, j] = newMatrix[0, 0] + sum;
        j++;
        sum++;
    }
    //i = 0;
    //j = n - 1;
    while (j == n - 1 && i < m - 1)
    {
        newMatrix[i, n - 1] = sum + 1;
        i++;
        sum++;
    }
    //i = m - 1;
    //j = n - 1;
    while (i == m - 1 && j > 0)
    {
        newMatrix[m - 1, j] = sum + 1;
        j--;
        sum++;
    }
    //i = m - 1;
    //j = 0;
    while (i > 0 && j == 0)
    {
        newMatrix[i, 0] = sum + 1;
        i--;
        sum++;
    }
    i = 1;
    j = 1;
    while (i == 1 && j < n - 1)
    {
        newMatrix[1, j] = sum + 1;
        j++;
        sum++;
    }
    i = m - 2;
    j = n - 2;
    while (i == m - 2 && j > 0)
    {
        newMatrix[m - 2, j] = sum + 1;
        j--;
        sum++;
    }
    printMatrix(newMatrix, m, n);
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