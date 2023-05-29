
//Задание 10.
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите число");

// int num=Convert.ToInt32(Console.ReadLine());

// if (num>=100)
// {
//    num/=10;
// }
// int num2=num%10;
// Console.WriteLine(num2);
// ________________________________________________________

//Задание 13.
// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает,
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = ReadLine("Введите число ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

int ReadLine(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
if (b < 3)
{
 Console.Write("Третьей цифры нет");
}
 else
{
 int c = 1;
 for (int i = b; i > 3; i--)
{
 c = c * 10;
}
 result = (a / c) % 10;
}
return result;
}


// ____________________________________________________

// Задача 15.
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Какой сегодня день, выходной или нет?");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1)
// {
//     Console.WriteLine("Нет - Понедельник");
// }
// else if (num == 2)
// {
//     Console.WriteLine("Нет-Вторник");
// }
// else if (num == 3)
// {
//     Console.WriteLine("Нет - Среда");
// }
// else if (num == 4)
// {
//     Console.WriteLine("Нет - Четверг");
// }
// else if (num == 5)
// {
//     Console.WriteLine("Нет - Пятница");
// }
// else if (num == 6)
// {
//     Console.WriteLine("Да - Суббота - выходной");
// }
// else if (num == 7)
// {
//     Console.WriteLine("Да - Воскресенье - выходной");
// }
// else
// {
//     Console.WriteLine("Введите число от 1 до 7");
// }