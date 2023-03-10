// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9


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
    int[] temp = new int[10];
    for (int k = 0; k < 10; k++)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (k == newMatrix[i, j])
                {
                    temp[k]++;
                }
            }
        }
        Console.WriteLine($"{k} встречается {temp[k]} раз");
    }
    return temp;
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

newMatrix(m1, n1);