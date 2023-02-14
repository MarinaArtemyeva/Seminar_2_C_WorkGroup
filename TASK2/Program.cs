// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int value = int.Parse(Console.ReadLine());
int a = value / 100;
int c = value % 10;

int result = a * 10 + c;
Console.WriteLine(result);