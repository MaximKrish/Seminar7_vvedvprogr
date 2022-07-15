//Задайте двумерный массив. Найлите элементы, у которых оба индекса не четные,
// и замените эти элементы на их квадраты

int[,] CreateMatr(int n, int m)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
            Console.Write(matrix[i, j] + " ");
            //matrix[i, j] = Convert.ToInt32(Console.ReadLine()); ручной ввод
        }
        Console.WriteLine();
    }
    return matrix;
}


void PrintMatr(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
                matrix[i, j] = matrix[i, j] * matrix[i, j];
       
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите колличество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцоы  m = ");
int m = Convert.ToInt32(Console.ReadLine());
PrintMatr(CreateMatr(n, m));


// Ручной ввод
// int[, ] CreateMatr(int n, int m)
// {
//     int[, ] matrix = new int[n ,m];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i +j;
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
