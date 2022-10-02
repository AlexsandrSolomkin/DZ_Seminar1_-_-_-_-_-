/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

//==============================================================================================================================================

//Частный случай:

/*
int[] numsA = { 5, 2, -9 };
int[] numsB = { 7, 10, -3 };
int i = 0;

while (i < numsA.Length){
    if (numsA[i] < numsB[i]){
        Console.WriteLine("max = " + numsB[i] + ", данные из массивов с индексом: " + i);
        i++;
    } else if(numsA[i] > numsB[i]){
        Console.WriteLine("max = " + numsA[i] + ", данные из массивов с индексом: " + i);
        i++;
    } else if(numsA[i] == numsB[i]){
        Console.WriteLine("max = numsA = numsB = " + numsA[i] + ", данные из массивов с индексом: " + i);
        i++;
    }
}
*/

//==============================================================================================================================================

//Общий случай:

/*
Console.WriteLine("Введите первое число, которое хотите сравнить: ");
double numA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число, которое хотите сравнить: ");
double numB = double.Parse(Console.ReadLine()!);

if(numA < numB){
    Console.WriteLine("max = " + numB);
} else if(numA > numB){
    Console.WriteLine("max = " + numA);
} else if(numA == numB){
    Console.WriteLine("max = numA = numB = " + numA);
}
*/

//==============================================================================================================================================