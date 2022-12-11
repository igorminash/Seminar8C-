/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
 */

Console.WriteLine("Введите количество строк в массиве А : ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов в массиве B : ");
int columnsA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк в массиве B : ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов в массиве B : ");
int columnsB = int.Parse(Console.ReadLine()!);

if (columnsA != rowsB){
    Console.WriteLine("Такие матрицы нельзя умножить между собой");
}

int [,] arrayA = GetArray(rowsA, columnsA, 0, 10);
int [,] arrayB = GetArray(rowsB, columnsB, 0, 10);

PrintArray (arrayA);
Console.WriteLine("----------------");
PrintArray (arrayB);
Console.WriteLine("----------------");
PrintArray(GetMultiplicationArray(arrayA, arrayB));


int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] massive){
    for(int i = 0; i < massive.GetLength(0); i++){
        for(int j = 0; j < massive.GetLength(1); j++){
            Console.Write($"{massive[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] GetMultiplicationArray (int [,] arrayA, int [,] arrayB){
    int [,] Mass = new int [arrayA.GetLength(0), arrayB.GetLength(1)];
    for(int i = 0; i < arrayA.GetLength(0); i++){
        for(int j = 0; j < arrayB.GetLength(1); j++){
            for(int k = 0; k < arrayA.GetLength(1); k++){
                Mass[i,j] += arrayA[i,k] * arrayB[k,j];
            }
        }
    }
    return Mass;
}