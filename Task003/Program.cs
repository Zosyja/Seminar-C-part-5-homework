// Написать программу копирования массива

int ReadInt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[,] CreateMatrix(int lenght, int width){
    Random random = new Random();
    int[,] matrix = new int[lenght, width];
    for (int i=0; i<matrix.GetLength(0); i++)
        for (int j=0; j<matrix.GetLength(1); j++)
            matrix[i,j] = random.Next(0,10);
    return matrix;
}
void PrintMatrix(int[,] matrix){
    for (int i=0; i<matrix.GetLength(0); i++){
        for (int j=0; j<matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]} ");
        Console.WriteLine();
    }
}

int lenght = ReadInt("Введите количество строк массива ");
int width = ReadInt("Введите количество столбцов массива: ");
Console.WriteLine();

int[,] matrix = CreateMatrix(lenght, width);
Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);
Console.WriteLine();

int[,] newmatrix = new int[matrix.GetLength(0),matrix.GetLength(1)];
for (int i=0; i<newmatrix.GetLength(0); i++){
    for (int j=0; j<newmatrix.GetLength(1); j++){
        newmatrix[i,j] = matrix[i,j];
    }
}
Console.WriteLine("Скопированный массив: ");
PrintMatrix(newmatrix);