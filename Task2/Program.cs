/*Задача 36: Задайте одномерный массив, 
заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int CountingSumOdd(int[] arr)
{
    int oddNum = 0;
    for (int i = 1; i < arr.Length; i += 2) oddNum = arr[i] + oddNum;
    return oddNum;
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
int[] massiv = GetArray(4, -99, 99);

// Находим сумму элементов массива стоящих на нечетных позициях
int sumOdd = CountingSumOdd(massiv);

// выводим результат
Console.Write("[" + string.Join(", ", massiv) + "] -> " + sumOdd);
