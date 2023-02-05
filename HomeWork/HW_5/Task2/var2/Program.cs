// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите массив:");
int i = 0;   
int[] mas = Console.ReadLine().Split( ' ',',', '\n', '\t' ).Select(Int32.Parse).ToArray();
int n = mas.Length;  

void SumNaNechetPoz(int [] mas)
{
    int result = 0;   
    for(i=0; i < n ; i+=2){
    result +=mas[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");
}

SumNaNechetPoz(mas);
