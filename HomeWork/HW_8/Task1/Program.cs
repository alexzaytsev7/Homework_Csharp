// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] array = GenerateInt2DArray(3, 4, 0, 9);
int [,] newarray = GenerateIntNew(array.GetLength(0), array.GetLength(1));

Console.WriteLine("Исходный массив: ");
Print2DArray(array);

Console.WriteLine("Массив с упорядоченными элементами строки по убванию:");
Print2DArray(newarray);

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
  

int[,] GenerateIntNew(int ma, int na) {

   
    int[,] newarray = new int[array.GetLength(0), array.GetLength(1)];

                for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    newarray[i, j] = array[i, j];
                }
            }

     
    for (int i = 0; i < newarray.GetLength(0); i++) {
        
        for (int j = 0; j < newarray.GetLength(1); j++) {
              
            for(int c = j+1; c < newarray.GetLength(1); c++){
              
                if(newarray[i,j]>newarray[i,c]){
 int num;
                num = newarray[i,j];
                newarray[i,j] = newarray[i,c];
                newarray[i,c] = num;
             
            
            }
          
            }

        }
    }

    return newarray;
}

