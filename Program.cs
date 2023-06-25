//Задача 54/
//Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой
//строки двумерного массива.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int[m,n];

// void mas(int m, int n)
// {
// int i,j;
// Random rand = new Random();
// for (i = 0; i < m; i++)
// {
// for (j = 0; j < n; j++)
// {
// randomArray[i,j] = rand.Next(1,9);
// }
// }
// }
// void printm(int[,] array)
// {
// int i,j;
// for (i = 0; i < array.GetLength(0); i++)
// {
// Console.WriteLine();
// for (j = 0; j < array.GetLength(1); j++)
// {
// Console.Write($"{array[i,j]} ");
// }
// Console.WriteLine();
// }
// }
// mas(m,n);
// Console.WriteLine("\nИсходный массив: ");
// printm(randomArray);
// void uporyadok(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// for (int k = 0; k < array.GetLength(1) - 1; k++)
// {
// if (array[i, k] < array[i, k + 1])
// {
// int temp = array[i, k + 1];
// array[i, k + 1] = array[i, k];
// array[i, k] = temp;
// }
// }
// }
// }
// }
// uporyadok(randomArray);
// Console.WriteLine("\nОтсортированный массив: ");
// printm(randomArray);

// ___________________________________________________________

// Задача 56.
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Введите m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int[m,n];

// void mas(int m, int n)
// {
// int i,j;
// Random rand = new Random();
// for (i = 0; i < m; i++)
// {
// for (j = 0; j < n; j++)
// {
// randomArray[i,j] = rand.Next(1,9);
// }
// }
// }
// void printm(int[,] array)
// {
// int i,j;
// for (i = 0; i < array.GetLength(0); i++)
// {
// Console.WriteLine();
// for (j = 0; j < array.GetLength(1); j++)
// {
// Console.Write($"{array[i,j]} ");
// }
// Console.WriteLine();
// }
// }
// mas(m,n);
// Console.WriteLine("\nИсходный массив: ");
// printm(randomArray);
// int SumLine(int[,] array, int i)
// {
// int sum = array[i,0];
// for (int j = 1; j < array.GetLength(1); j++)
// {
// sum += array[i,j];
// }
// return sum;
// }
// int minSum = 1;
// int sum = SumLine(randomArray, 0);
// for (int i = 1; i < randomArray.GetLength(0); i++)
// {
// if (sum > SumLine(randomArray, i))
// {
// sum = SumLine(randomArray, i);
// minSum = i+1;
// }
// }
// Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");

// ________________________________________________________________________

// Задача 58.
// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int rows = ReadInt("Введите количество строк: ");
// int columns = ReadInt("Введите количество столбцов: ");
// int[,] array = new int[rows, columns];
// int[,] secondArray = new int[rows, columns];
// int[,] resultArray = new int[rows, columns];
// FillArrayRandom(array);
// PrintArray2D(array);
// Console.WriteLine();
// FillArrayRandom(secondArray);
// PrintArray2D(secondArray);
// Console.WriteLine();
// if (array.GetLength(0) != secondArray.GetLength(1))
// {
//     Console.WriteLine(" Нельзя перемножить ");
//     return;
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < secondArray.GetLength(1); j++)
//     {
//         resultArray[i, j] = 0;
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             resultArray[i, j] += array[i, k] * secondArray[k, j];
//         }
//     }
// }
// PrintArray2D(resultArray);
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// ______________________________________________________________________

// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array3D = new int[2, 2, 2];
// FillArray(array3D);
// PrintIndex(array3D);
// void PrintIndex(int[,,] arr)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }
// void FillArray(int[,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }

// ______________________________________________________________________________

// Задача 62.
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int n = 4;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;
// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//     sqareMatrix[i, j] = temp;
//     temp++;
//     if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//         j++;
//     else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//         i++;
//     else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//         j--;
//     else
//         i--;
// }
// WriteArray(sqareMatrix);
// void WriteArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] / 10 <= 0)
//                 Console.Write($" {array[i, j]} ");

//             else Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
