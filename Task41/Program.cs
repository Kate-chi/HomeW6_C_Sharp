/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

Console.Write("Введите числа через зяпятую: ");
string? numbers = Console.ReadLine();

int size = FindSize(numbers, ',');
int[] arr = new int[size];

ConvertStr(numbers, ',', arr);
PrintArr(arr);
Console.WriteLine();

Console.Write($"Вы ввели {FindPositivNum(arr)} чисел больше 0");

int FindPositivNum(int[] arr)
{
    int posNum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            posNum++;
        }
    }
    return posNum;
}

void ConvertStr(string num, char separator, int[] arr)
{
    string creationNum = "";
    int index = 0;
    for(int i = 0; i < num.Length; i++)
    {
        if(num[i] != separator)
        {
            creationNum += num[i];
        }
        else
        {
            arr[index] = Convert.ToInt32(creationNum);
            creationNum = "";
            index++;
        }
    }
    arr[index] = Convert.ToInt32(creationNum);
}

int FindSize(string num, char separator)
{
    int numberOfSigns = 1;

    if(num.Length == 0)
    {
        return 0;
    }
    for(int i = 0; i < num.Length; i++)
    {
        if(num[i] == separator)
        {
            numberOfSigns++;
        }
    }
    return numberOfSigns;
}

void PrintArr(int[] arr)
{
    Console.Write("[");

    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);

        if(i < arr.Length - 1)
        {
            Console.Write(", ");
        }
    }

    Console.Write("]");
}
