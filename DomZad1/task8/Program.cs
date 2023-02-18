// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int M = 1;

while (M <= N)
{
    if (M % 2 == 0)
        System.Console.Write(M + ", ");
        M++;
}