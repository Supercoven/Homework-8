// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] CreateArray(int row, int coll)
        {
            int[,] newArray = new int[row, coll];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    newArray[i, j] = new Random().Next(0, 10);
                }
            }
            return newArray;
        }

        void ShowArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j],3}    ");
                }
                Console.WriteLine();
            }
        }

        int[] SummRows(int[,] array)
        {
            int[] resultArr = new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum = sum + array[i, j];
                }
                Console.WriteLine($"Сумма значений в {i + 1} строке: {sum} ");
                resultArr[i] = sum;
            }
            return resultArr;
        }


        Console.Write("Введите количество строк в массиве: ");
        int lengthArr = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов в массиве: ");
        int widthArray = Convert.ToInt32(Console.ReadLine());

        int[,] addArray = CreateArray(lengthArr, widthArray);
        ShowArray(addArray);


        int[] sumArray = SummRows(addArray);
        int min = sumArray[0];

        int minIndex = 0;
        for (int i = 1; i < sumArray.Length; i++)
        {
            if (sumArray[i] < min)
            {
                min = sumArray[i];
                minIndex = i;
            }
        }

        Console.Write($"Номер строки, где сумма значений наименьшая: {minIndex + 1}");
    }
}