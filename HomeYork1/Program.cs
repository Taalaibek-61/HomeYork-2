/* Домашнее задание
 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
Console.Write("Input a first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 < num2)
{
    Console.WriteLine("num2");
}
else
{
    Console.WriteLine("num1");
}
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
Console.Write("Input numberA");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numberB");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numberC");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if(numberA > max) max = numberA;
if(numberB > max) max = numberB;
if(numberC > max ) max = numberC;

Console.Write("max=");
Console.WriteLine(max);
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Console.Write("Input numberA");
int numberA = Convert.ToInt32(Console.ReadLine());

if(numberA % 2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


Console.Write("Input number:");
int N  = Convert.ToInt32(Console.ReadLine());
int index = 0;

while(index <= N)
{
 if(index % 2 == 0)   
{
Console.WriteLine(index);
}
index++;   
    
}*/


/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int methodA (int number)
{
    int sot = number / 10;
    int ed = sot % 10;

    int result = ed;
    return result;

}

Console.Write("Input a  number");
int number = Convert.ToInt32(Console.ReadLine());

int newnumber = methodA(number);
Console.WriteLine("New version of number is" + newnumber);



/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/


