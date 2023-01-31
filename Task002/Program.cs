// Написать программу масштабирования фигуры
// двумерная плоскость (координаты каждой из вершин = {x,y})

int ReadInt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
double[,] FillPoints(){
    int w = ReadInt("Введите количество вершин фигуры: ");
    double[,] figure = new double[w,2];
    for (int i=0; i<figure.GetLength(0); i++){
        for (int j=0; j<figure.GetLength(1); j++){
            if (j==0) figure[i,j] = ReadInt($"Введите координаты {i+1} вершины по x: ");
            else figure[i,j] = ReadInt($"Введите координаты {i+1} вершины по y: ");
        }
    }
    return figure;
}
void PrintMatrix(double[,] matrix){
    for (int i=0; i<matrix.GetLength(0); i++){
        for (int j=0; j<matrix.GetLength(1); j++)
            if (j==0) Console.Write($"({matrix[i,j]};");
            else Console.Write($"{matrix[i,j]})  ");
    }
}

double[,] figure = FillPoints();
Console.WriteLine();
Console.WriteLine("Перечень координат фигуры: ");
PrintMatrix(figure);
Console.WriteLine();
Console.Write("Коэффициент масштабирования фигуры: ");
double k = Convert.ToDouble(Console.ReadLine() ?? "0"); //дробные числа - например 0,5...
Console.WriteLine("Перечень координат фигуры с учетом масштабирования: ");

double sumX = 0;
double sumY = 0;
for (int i=0; i<figure.GetLength(0); i++){
        sumX = sumX+figure[i,0];
}
for (int i=0; i<figure.GetLength(0); i++){
        sumY = sumY+figure[i,1];
}

double centerX = sumX/figure.GetLength(0);
double centerY = sumY/figure.GetLength(0);
for (int i=0; i<figure.GetLength(0); i++){
        double numX = centerX + (figure[i,0]-centerX)*k;
        figure[i,0] = numX;
}
for (int i=0; i<figure.GetLength(0); i++){
        double numY = centerX + (figure[i,1]-centerY)*k;
        figure[i,1] = numY;
}
PrintMatrix(figure);