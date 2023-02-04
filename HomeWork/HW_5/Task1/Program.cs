// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void PrintArray(int[] array)
{
    System.Console.Write($"[{String.Join(",", array)}]\n");
}

int[] GenerateArr(int n, int min, int max)
{
    int[] arrNum = new int[n];

    Random rnd = new Random();

    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

    return arrNum;
}

int CountChet(int[] array)
{
    int count = 0;
for(int i = 0; i < array.Length; i++){
    if(array[i] % 2 == 0)
    count++;
}
return count;

}

int[] array = GenerateArr(3, 100, 999);
PrintArray(array);
CountChet(array);
Console.WriteLine($"Кол-во четных элементов в массиве: {CountChet(array)}");