/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76*/

float SubtractionMaxMin(float[] arr)
{
    float max = arr[1];
    float min = arr[1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];        
    }
    float subtraction = max - min;
    return subtraction;
}

float[] GetArray(int size, int start, int finish)
{
    float[] array = new float[size];
    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(start, finish + 1);
    }
    return array;
}

// Создаём массив 
float[] massiv = GetArray(5, 0, 99);

// Находим разницу между максимальным и минимальным элементом массива
float sub = SubtractionMaxMin(massiv);

// выводим результат
Console.Write("[" + string.Join(", ", massiv) + "] -> " + sub);