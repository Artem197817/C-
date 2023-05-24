
 

﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите 1 число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int secondNum = Convert.ToInt32(Console.ReadLine());
if (firstNum > secondNum) {
    Console.WriteLine("max = " + firstNum);
} else {
    Console.WriteLine("max = " + secondNum);
}

/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 228*/

Console.WriteLine("Введите 1 число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int num3 = Convert.ToInt32(Console.ReadLine());
int temp;
if (num1 > num2) {
    temp = num1;num1 = num2;num2 = temp;
}
if (num2 > num3){
    temp = num2;num2 = num3;num3 = temp;
}
if (num1 > num2) {
    temp = num1;num1 = num2;num2 = temp;
}
Console.WriteLine("max = " + num3);

/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0){
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}

/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(N + " -> ");
for (int i = 2;i <= N;i++){
    if (i % 2 == 0){
    Console.Write(i + " ");
}
}
Console.WriteLine();