// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр 
// в числе.

int number = ReadInt("Введите число: ");
int numLen = NumberLen(number);
SumNumbers(number, numLen);


int ReadInt(string text) // функция ввода
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int NumberLen(int a) // функция подсчета цифр в числе
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}


void SumNumbers(int n, int numLen) // функция вывода суммы цифр в числе
{
    int sum = 0;
    for (int i = 1; i <= numLen; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
