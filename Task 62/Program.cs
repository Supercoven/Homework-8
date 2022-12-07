// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк в массиве (2 или более): ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов в массиве (2 или более): ");
        int colls = Convert.ToInt32(Console.ReadLine());


        void ShowArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write($"{arr[i, j],3} ");

                }
                Console.WriteLine();
            }
        }

        int SpirallArr(int[,] newArray, int count, int iElem, int jElem)
        {

            for (int j = jElem; j < colls; j++)
            {
                if (newArray[iElem, j] == 0) newArray[iElem, j] = count;
                count++;
            }

            for (int i = iElem + 1; i < rows; i++)
            {
                if (newArray[i, colls - 1] == 0) newArray[i, colls - 1] = count;
                count++;
            }

            for (int j = colls - 2; j >= jElem; j--)
            {
                if (newArray[rows - 1, j] == 0) newArray[rows - 1, j] = count;
                count++; // ==
            }

            for (int i = rows - 2; i > iElem; i--)
            {
                if (newArray[i, jElem] == 0) newArray[i, jElem] = count;
                count++;
            }

            return count;
        }


        int[,] AddSpiralArray = new int[rows, colls];
        int iBegin = 0;
        int jBegin = 0;
        int value = 1;

        while (rows > 1 & colls > 1)
        {
            value = SpirallArr(AddSpiralArray, value, iBegin, jBegin);
            iBegin++;
            jBegin++;
            rows--;
            colls--;

        }

        ShowArr(AddSpiralArray);
    }
}