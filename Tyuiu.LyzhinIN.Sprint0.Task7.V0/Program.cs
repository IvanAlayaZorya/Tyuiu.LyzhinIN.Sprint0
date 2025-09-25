// See https://aka.ms/new-console-template for more information
using Tyuiu.LyzhinIN.Sprint0.Task7.V0.Lib;
Console.Title = "Спринт #0 | Выполнил: Лыжин И. Н. | НТм-24-1";
Console.WriteLine("****************************************************");
Console.WriteLine("*Спринт #0                                         *");
Console.WriteLine("*Тема: Создание итогового решения по спринту       *");
Console.WriteLine("*Задание                                           *");
Console.WriteLine("*Вариант                                           *");
Console.WriteLine("*Выполнил: Лыжин И. Н. | НТм-24-1                  *");
Console.WriteLine("****************************************************");
Console.WriteLine("*УСЛОВИЕ:                                          *");
Console.WriteLine("*Написать консольную программу, которая суммиурет  *");
Console.WriteLine("*значения двух одинаковых массивов по длинне.      *");
Console.WriteLine("*                                                  *");
Console.WriteLine("****************************************************");
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:                                   *");
Console.WriteLine("****************************************************");

int[] ArrayNums1 = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine("Значение элементов массива №1");
for (int i = 0; i < ArrayNums1.Length; i++)
{
    Console.WriteLine(ArrayNums1[i] + ", ");
}

int[] ArrayNums2 = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine("Значение элементов массива №1");
for (int i = 0; i < ArrayNums2.Length; i++)
{
    Console.WriteLine(ArrayNums2[i] + ", ");
}

Console.WriteLine();
Console.WriteLine("****************************************************");
Console.WriteLine("РЕЗУЛЬТАТ:                                         *");
Console.WriteLine("****************************************************");

if(ArrayNums1.Length ==ArrayNums2.Length)
{
    int[] resultArray = DataService.AddArrs(ArrayNums1, ArrayNums2);

    Console.WriteLine("Сумма элементов массива равна: ");
    for (int i = 0; i < resultArray.Length; i++)
    {
        Console.WriteLine(resultArray[i] + ", ");
    }
}
else
{
    Console.WriteLine("Ошибка! Массивы имеют разное количество элементов");
}
Console.ReadKey();
