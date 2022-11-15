// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Console.WriteLine("Введите m");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите n");
// int numN = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [numM,numN];
// FillArray(array);
// void FillArray(int [,] array)
// {
//  for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//        array[i,j] = new Random().Next(0,10);
//     }
// }
// }
// printArray(array);
// void printArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// MIin(array);
// void MIin(int[,] array)
// {
//     int minStr = 0;
//     int minSum = 0;
//     int sumStr = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minStr += array[0, i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) sumStr += array[i, j];
//         if (sumStr < minStr)
//         {
//             minStr = sumStr;
//             minSum = i;
//         }
//         sumStr = 0;
//     }
//     Console.Write($"{minSum + 1} строка");
// }
