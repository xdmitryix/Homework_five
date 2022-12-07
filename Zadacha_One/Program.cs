// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int evenNumbers(int[] arr)
{
  int res = 0;
 for (int i = 0; i < arr.Length; i++)
 {
  if (arr[i] % 2 == 0) res++;
 }
 return res;
}

Console.Clear();
int sizeArray = 4;
int[] array = new int[sizeArray];
array = FillArrayWithRandomNumbers(sizeArray, 100, 999);
Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");
int result = evenNumbers(array);
Console.WriteLine("колличество четных чисел в массиве: " + result);
