// Найти точку пересечения двух прямых заданных уравнениями:
// y = k1*x+b1 ,  y = k2*x+b2
// k1, b1, k2, b2 заданы

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

(int, int)? FindPoint(int k1, int b1, int k2, int b2)
{
    if (k1!=k2 && b1!=b2)
    {
        int x = (b2-b1)/(k1-k2);
        int y = (k1*(b2-b1)/(k1-k2)+b1);
        return (x,y);
    }
    return null;
}

int k1 = ReadInt("Задайте k1 уравнения y=k1*x+b1: ");
int b1 = ReadInt("Задайте b1 уравнения y=k1*x+b1: ");
int k2 = ReadInt("Задайте k2 уравнения y=k2*x+b2: ");
int b2 = ReadInt("Задайте b2 уравнения y=k2*x+b2: ");

(int,int)? indexes = FindPoint(k1,b1,k2,b2);
if (indexes==null)
    Console.WriteLine("Прямые не пересекаются");
else
    Console.WriteLine($"Прямые пересекаются в точке с координатами: ({indexes?.Item1},{indexes?.Item2})");