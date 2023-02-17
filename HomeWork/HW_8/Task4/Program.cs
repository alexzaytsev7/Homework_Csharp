// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] array = GenerateInt3DArray(2, 2, 2, 10, 100);
Print2DArray(array);

int[,,] GenerateInt3DArray(int m, int n, int l, int min, int max) {
    Random random = new Random();
    int[,,] array = new int[m, n, l];
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k=0; k<array.GetLength(2); k++){
            array[i,j,k] = random.Next(min, max + 1);
            }
        }
    }

    return array;
}

void Print2DArray(int[,,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        List<int> currentRow = new List<int>();
        for (int j = 0; j < array.GetLength(1); j++) {
            for(int k=0; k < array.GetLength(2); k++)

        Console.Write($"{array[i,j,k]}({i},{j},{k})\t"); 
           //currentRow.Add(array[i, j, k]);
        
        }
        
       // Console.WriteLine(string.Join("  ", currentRow));
       
    }
    
}

