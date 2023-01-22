// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int xa, ya, za, xb, yb, zb;

Console.WriteLine("Введите координатy x А");
if(!int.TryParse(Console.ReadLine(), out xa))
    Console.WriteLine("Введено не целое число");
    
Console.WriteLine("Введите координатy y А");
if(!int.TryParse(Console.ReadLine(), out ya))
    Console.WriteLine("Введено не целое число");
    
Console.WriteLine("Введите координатy z А");
if(!int.TryParse(Console.ReadLine(), out za))
    Console.WriteLine("Введено не целое число");
    

    Console.WriteLine("Введите координатy x B");
if(!int.TryParse(Console.ReadLine(), out xb))
    Console.WriteLine("Введено не целое число");
    
Console.WriteLine("Введите координатy y B");
if(!int.TryParse(Console.ReadLine(), out yb))
    Console.WriteLine("Введено не целое число");
    
Console.WriteLine("Введите координатy z B");
if(!int.TryParse(Console.ReadLine(), out zb))
    Console.WriteLine("Введено не целое число");
    

double Distance(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2)+ Math.Pow((zb - za), 2));    
}

double res = Distance(xa,ya,za,xb,yb,zb);
Console.WriteLine($"Расстоняние между тремя точками: {res.ToString("0.##")}");