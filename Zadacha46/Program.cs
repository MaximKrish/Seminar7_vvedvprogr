// Задайте двумерный массив размером m*n, заполненный случайными целыми числами


int[,] CreateMatr(int n, int m)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
        }
    }
    return matrix;
}


void PrintMatr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PrintMatr(CreateMatr(3, 4));


// Ручной ввод
// int[, ] CreateMatr(int n, int m)
// {
//     int[, ] matrix = new int[n ,m];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//         }
//     }
//     return matrix;
// }


// void PrintMatr(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// PrintMatr(CreateMatr(n, m));
