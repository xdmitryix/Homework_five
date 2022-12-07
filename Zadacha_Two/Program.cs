// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int findSum (int [] arr)
{
 int sum = 0;
 for (int i = 1; i < arr.Length; i = i + 2)
 {
  sum += arr[i];
 }
 return sum;
}

Console.Clear();
int sizeArray = 4;
int[] array = new int[sizeArray];
array = FillArrayWithRandomNumbers(sizeArray, -99, 99);
Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");
int sum = findSum(array);
Console.WriteLine("сумма элементов на нечетных позициях: " + sum);