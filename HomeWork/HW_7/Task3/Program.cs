// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
//в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GenerateArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = random.Next(min, max + 1);

    return array;
}

void PrintArray2D(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + ", ");
        Console.WriteLine();
    }
}

void AverageColumn(int[,] array){
    Console.Write("Cреднее арифметическое элементов в каждом столбце: ");
    float result = 0;
    for (int j = 0; j < array.GetLength(1); j++){
        for (int i = 0; i < array.GetLength(0); i++){
      
        result += array[i,j];
        
    }
        Console.Write(result/array.GetLength(0) + ", ");
    }
}

var array = GenerateArray(4, 3, 0, 9);
PrintArray2D(array);
AverageColumn(array);