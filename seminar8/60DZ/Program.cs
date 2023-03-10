// Задача 60. Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)


int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,,] RandomMatrix(int m, int n, int p)
{
    int[,,] matrix = new int[m, n, p];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
                matrix[i, j, k] = Random.Shared.Next(10, 20);
        }
    };
    return matrix;
}


void printMatrix(int m, int n, int p)
{
    int[,,] newMatrix = RandomMatrix(m, n, p);
    Console.WriteLine($"matrix[{m}x{n}x{p}] = ");
    for (int k = 0; k < p; k++)
    {
        Console.WriteLine("{");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{newMatrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("}");
    }
}


int m1 = ReadNumber("Введите количество строк:");
int n1 = ReadNumber("Введите количество столбцов:");
int p1 = ReadNumber("Введите  глубину:");

printMatrix(m1, n1, p1);