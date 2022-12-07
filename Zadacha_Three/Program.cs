// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int FindDifMaxMin(int[] arr)
{
    int i = 0;
    int max = arr[i];
    int min = arr[i];
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    int result = max - min;
    return result;
}

Console.Clear();
int sizeArray = 5;
int[] array = new int[sizeArray];
array = FillArrayWithRandomNumbers(sizeArray, 1, 99);
Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");
int result = FindDifMaxMin(array);
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + result);

