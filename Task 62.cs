// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Console.WriteLine("Введите m");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите n");
// int numN = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [numM,numN];
// int num1 = 0;
// Zmeika(array);
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
// void Zmeika(int [,] array)
// {
//     if (numM == numN)
//     {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             while (num1 <= numM * numM)
//             {
//                 array[i, j] = num1;
//                 if (i <= j + 1 && i + j < numM - 1)
//                 {
//                     ++j;
//                 }
//                 else if (i < j && i + j >= numM - 1)
//                 {
//                     ++i;
//                 }
//                 else if (i >= j && i + j > numM - 1)
//                 {
//                     --j;
//                 }
//                 else
//                 { 
//                     --i;
//                 } 
//                 ++num1;
//             }
//         }
//     }
//         printArray(array);
//     }
//     else
//     {
//         Console.WriteLine("Не получится");
//     }
// }   