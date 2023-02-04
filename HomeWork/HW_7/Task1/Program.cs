// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GenerateArray(int m, int n, double min, double max)
{
    double[,] array = new double[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = random.NextDouble() * 10;

    return array;
}

void PrintArray2D(double[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(String.Format("{0:F1}", array[i,j])+" ");
        Console.WriteLine();
    }
}

var array = GenerateArray(4, 3, 0, 9);
PrintArray2D(array);