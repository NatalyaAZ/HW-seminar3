// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.
Random random = new Random();
// Создание массива из 10 элементов
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 900); // заполняем числами
}
    for(int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i] + " "}");
}
int count = 0;
for (int i = 0; i < array.Length; i++) 
{
if (array[i] % 2 == 0) count++; 
}
Console.WriteLine();
Console.WriteLine("Количество чётных чисел в массиве: " + count);