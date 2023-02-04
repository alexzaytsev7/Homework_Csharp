// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размерность массива:");
            int i, n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Console.WriteLine("Введите массив:");
            string[] str = Console.ReadLine().Split(new char[] { ' ',',', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

void PrintArray(int [] mas)
{
            for (i = 0; i < (n < str.Length ? n : str.Length); ++i){
                mas[i] = Convert.ToInt32(str[i]);
            }
                  

}


int DeltaMaxMin(int[] array) {
    int max = array[0];
    int min = array[0];

    for (int i = 0; i < array.Length; i++) {
        if (max < array[i])
        {
            max = array[i];
        }
        else if (min > array[i])
        {
            min= array[i];
        } 

       }    

    return (max-min);
}


PrintArray(mas);

//Проверка на указанное кол-во элемнтов массива с реально введенным
if (str.Length != n)
{
    Console.WriteLine("Указанное кол-во элемнтов массива не совпадает с реально введенным!");
return;
}
else
Console.WriteLine("Разность между max и min масиве: ");
Console.WriteLine(DeltaMaxMin(mas));
