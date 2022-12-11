/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[,,] array = GetArray(2, 2, 2, 10, 99);
PrintArray(array);




int[,,] GetArray(int a, int b, int c, int minValue, int maxValue){
    int[,,] result = new int[a,b,c];
    for(int i = 0; i < a; i++){
        for(int j = 0; j < b; j++){
            for(int k = 0; k < c; k++){
                result[i,j,k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}


void PrintArray(int[,,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(1); k++){
                Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}