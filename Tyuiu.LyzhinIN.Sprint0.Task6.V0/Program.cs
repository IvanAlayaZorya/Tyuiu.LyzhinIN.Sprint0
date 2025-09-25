// See https://aka.ms/new-console-template for more information
using Tyuiu.LyzhinIN.Sprint0.Task6.V0.Lib;
int[] nums = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine("Сумма элементов массива = "+ DataService.AddArr(nums));
Console.WriteLine("Разность элементов массива = "+ DataService.SubArr(nums));
Console.WriteLine("Произведение элементов массива = "+ DataService.MultArr(nums));

Console.ReadKey();
