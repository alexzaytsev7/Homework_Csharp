// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//матрицы для расчета
int[,] arr1 = {{2,4}, {3,2}};
int[,] arr2 = {{3,2}, {3,3}};

Console.WriteLine("Результирующая матрица произведения двух матриц: ");
int[,] resArray = new int[arr1.GetLength(0), arr1.GetLength(1)];

ProizvedArray(arr1.GetLength(0), arr1.GetLength(1));
Print2DArray(resArray); 

int[,] ProizvedArray(int ma, int na) {
    for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
              for (int k = 0; k < arr1.GetLength(1); k++){
        resArray[i,j]+=arr1[i, k] * arr2[k, j];
            }
        } 
        }
        return resArray;
}

void Print2DArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        List<int> currentRow = new List<int>();
        for (int j = 0; j < array.GetLength(1); j++) {
            currentRow.Add(array[i,j]);
        }
        Console.WriteLine(string.Join("  ", currentRow));
    }
}