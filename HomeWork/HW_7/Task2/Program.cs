// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

var array = GenerateArray(4, 3, 0, 9);
PrintArray2D(array);

Console.WriteLine("Введите позицию искомого элемента m и n");
string[] str = Console.ReadLine().Split(new char[] { ' ',',', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

int[] mas = new int[2];
void PrintArray(int [] mas)
{
            for (int i = 0; i < 2; ++i){
                mas[i] = Convert.ToInt32(str[i]);
            }
}

void FindElementArray(int[,] array)
{
    if(mas[0]< array.GetLength(0) && mas[0]>0 && mas[1]< array.GetLength(1) && mas[1]>0){
        Console.WriteLine("Искомый элемент: " + array[mas[0], mas[1]]);
    }
    else
    Console.WriteLine("Искомого элемента в матрице нет");
}

PrintArray(mas);
FindElementArray(array);