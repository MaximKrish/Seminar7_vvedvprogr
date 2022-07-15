// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[, ] CreateMatr(int n, int m)
{
    int[, ] matrix = new int[n ,m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
            //matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}


void PrintMatr(int[, ] matrix)
{
    Console.WriteLine();
    int AverageSum = 0, count = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
        for (int j = 0; j < matrix.GetLength(1); j++)
            
             AverageSum = (AverageSum + matrix[i, j])/count;
             count++;
            Console.Write(Convert.ToDouble(AverageSum));
    }
    //Console.Write(Convert.ToDouble(AverageSum  + " "));
}

Console.Write("Введите колличество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцоы  m = ");
int m = Convert.ToInt32(Console.ReadLine());
PrintMatr(CreateMatr(n, m));