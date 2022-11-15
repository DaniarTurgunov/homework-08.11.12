// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
// ChArray(array);
// void ChArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int z = 0; z < array.GetLength(1) - 1; z++)
//             {
//                 if (array[i, z] < array[i, z + 1]) 
//                 {
//                     int temp = 0;
//                     temp = array[i, z];
//                     array[i, z] = array[i, z + 1];
//                     array[i, z + 1] = temp;
//                 }
//             }
//         }
//     }
// Console.WriteLine();
// }
// printArray(array);