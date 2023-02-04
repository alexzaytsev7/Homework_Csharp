// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

           
Console.WriteLine("Введите значения b1, k1, b2 и k2:");
double[] mas = new double[4];
string[] str = Console.ReadLine().Split(new char[] { ' ',',', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

void PrintArray(double [] mas)
{
            for (int i = 0; i < 4; ++i){
                mas[i] = Convert.ToDouble(str[i]);
            }               
}
  

float[] CrossPoint(double [] mas)
{
  double x, y;

  float [] arrNum = new float[2];
  
  x = (mas[2] - mas[0]) / (mas[1] - mas[3]);      
  y = mas[1] * x + mas[0];

  Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");   
  return arrNum;           
}

PrintArray(mas);

 if(mas[0] == mas[2]){
        Console.WriteLine("Отрезки параллельны");
        return;
    }

CrossPoint(mas);
