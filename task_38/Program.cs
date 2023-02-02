// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным
// элементами массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.Write("[ ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write($"{array[i]}, ");
}
int min = array[0];
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}
int result = max - min;
Console.Write("\b\b ");
Console.WriteLine("]");
Console.WriteLine($"разницу между максимальным и минимальным элементами массива = {result}");


