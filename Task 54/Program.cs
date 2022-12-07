// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Create2dArray(int rows, int column){
  int[,] array = new int[rows, column];
  for (int i = 0; i < rows; i++){
    for (int j = 0; j < column; j++){
      array[i, j] = new Random().Next(0, 20);
    }
  }
  return array;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
      Console.Write($"{array[i, j], 3}    ");
    }
    Console.WriteLine();
  }
}

int[,] ArrSort(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1) - 1; j++){
      int temp = array[i, j]; 
      if (array[i, j] < array[i, j + 1]){ 
 
        temp = array[i, j + 1];
        array[i, j + 1] = array[i, j]; 
        array[i, j] = temp; 

      }
    }
  }
  return (array);
}


Console.Write("Задайте количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте количество столбцов в массиве: ");
int coll = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(rows, coll);

Console.WriteLine("Сгенерированный массив: ");
PrintArray(myArray);

for (int i = 0; i < myArray.GetLength(1) - 1; i++) 
{
ArrSort(myArray);
}

Console.WriteLine("Упорядоченный массив: ");
PrintArray(myArray);