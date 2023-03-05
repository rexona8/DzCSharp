// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.

System.Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number3)
{
    System.Console.Write("Максимальное число: " + number1);
}
else if (number2 > number1 && number2 > number3)
{
    System.Console.Write("Максимальное число: " + number2);
}
else if (number3 > number1 && number3 > number2)
{
    System.Console.Write("Максимальное число: " + number3);
}
else
{
    System.Console.WriteLine("Числа равны");
}
