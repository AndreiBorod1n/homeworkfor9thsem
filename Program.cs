// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите натуральное число больше 1:");
int num = int.Parse(Console.ReadLine());

///Метод вывода натуральных чисел от N до 1:
void NumberCounter (int num)
{
    if (num < 0) Console.Write($"{num} не натуральное число");
    if (num == 0) return;
    Console.Write("{0,4}", num);
    NumberCounter (num - 1);
}

NumberCounter(num);
