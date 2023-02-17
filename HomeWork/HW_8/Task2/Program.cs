// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

int [,] array = GenerateInt2DArray(4, 4, 0, 9);

Console.WriteLine("Исходный массив: ");
Print2DArray(array);
FindMinStr(array.GetLength(0), array.GetLength(1));


int[,] GenerateInt2DArray(int m, int n, int min, int max) {
    Random random = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = random.Next(min, max + 1);
        }
    }

    return array;
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


int[,] FindMinStr(int ma, int na) {
  
    int [] ArraySum = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++) {
    
        for (int j = 0; j < array.GetLength(1); j++)
            
     {
            ArraySum[i] = ArraySum[i] + array[i,j];
            }  
        // Вывод сумм в каждой строке
        Console.Write( " " +ArraySum[i]); 

        }
//находим минимальное в новом массиве из сумм
        int min = 1000000;
        int imin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        if (ArraySum[i]<min){
            min = ArraySum[i];
            imin = i;
    }
    Console.WriteLine("Мин строка: " +imin);
               
      return array;
    }



 
