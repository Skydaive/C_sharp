// Задача 64.
// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите натуральное число больше 1:");
// int number = int.Parse(Console.ReadLine());
// void NumberCounter(int number)
// {
//     if (number < 0) Console.Write($"{number} не натуральное число");
//     if (number == 0) return;
//     Console.Write("{0,4}", number);
//     NumberCounter(number - 1);
// }

// NumberCounter(number);

// ____________________________________________________________________

// Задача 66.
// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// SumFromMToN(m, n);
// void SumFromMToN(int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }
// int SumMN(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }

// ______________________________________________________________________
// Задача 68.
// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Введите значение число M:");
// int numberM = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите значение число N:");
// int numberN = int.Parse(Console.ReadLine());
// int AckermannFunction(int numberM, int numberN)
// {
//     if (numberM == 0) return numberN + 1;
//     if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
//     if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
//     return AckermannFunction(numberM, numberN);
// }
// Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");
