﻿// int n = 100;
// int i = 1;

// while (i <= n)
// {
// 	Console.Write(i);
// 	Console.Write(' ');
// 	i++;
// }
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num / 100;
int num3 = num % 10;

int result = num1 * 10 + num3;
Console.WriteLine(result);