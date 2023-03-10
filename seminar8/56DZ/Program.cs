// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[] newMatrix(int m, int n)
{
    int[,] newMatrix = randomMatrix(m, n);
    printMatrix(newMatrix, m, n);
    int[] sum = new int[m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum[i] += newMatrix[i, j];
        }
    }
    return sum;
}

void PrintMinSum(int m, int n)
{
    int[] sum = newMatrix(m, n);
    int mIn = sum[0];
    int row = 0;
    for (int i = 1; i < m; i++)
    {
        if (sum[i] < mIn)
        {
            mIn = sum[i];
            row = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов : {row + 1} строка sum = {mIn}");
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

PrintMinSum(m1, n1);