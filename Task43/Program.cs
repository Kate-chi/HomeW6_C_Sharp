/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int b1 = InputNum("Введите значение b1: ");
int k1 = InputNum("Введите значение k1: ");

int b2 = InputNum("Введите значение b2: ");
int k2 = InputNum("Введите значение k2: ");

double x = FindPoint(b1, k1, b2, k2);
double y = x;

Console.Write($"Точка пересечения указанных прямых = ({x}; {y})");

double FindPoint(int b1, int k1, int b2, int k2)
{
    double a = k1 - k2;
    double c = b2 - b1;
    return c / a;
}

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}