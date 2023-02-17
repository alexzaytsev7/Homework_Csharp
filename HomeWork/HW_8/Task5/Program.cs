// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GenerateArray(int m, int n)
{
    int[,] array = new int[m, n];
    int k = 1, t = 0, i = 0, j = 0; 
    //int colums = n;//кол-во элементов в столбце
    //int rows = m;//кол-во элементов в строке
    int elements =m*n;
while(k <= elements){
    for (i = t; i < m; i++)
        array[j,i] =k++;
    j = m-1;
    for (i = t+1; i < n; i++)
        array[i,j] =k++;
    j = n-1;     
    for(i = m-2; i>=t; i--)     
        array[j,i] =k++;
    j = t;
    for(i = n-2; i>t; i--)     
        array[i,j] =k++;
    m--;
    n--;
    t++;
    j = t;
}
 return array;
}

void PrintArray2D(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++)
            if(array[i,j]<10)
              Console.Write("0"+array[i,j] + " ");  
            else
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

var array = GenerateArray(4, 4);
PrintArray2D(array);