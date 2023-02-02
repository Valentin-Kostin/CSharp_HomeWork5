/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int CountingEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;        
    }
    return count;
}

int[] GetArray(int size, int start, int finish)
{
    int[] array = new int[size];
    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(start, finish + 1);
    }
    return array;
}

// Создаём массив 
int[] massiv = GetArray(4, 100, 999);

// Считаем четные числа
int evenNumbers = CountingEven(massiv);

// выводим результат
Console.Write("[" + string.Join(", ", massiv) + "] -> " + evenNumbers);