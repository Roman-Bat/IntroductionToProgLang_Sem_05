/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[] Getarray(int length, int min, int max)
{
    int[] result = new int[length];
    Random rand = new Random();
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = rand.Next(min, max + 1);
        }
        return result;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]+ " ");
}

}
void Compare(int[] array)
{
    int temp = 0;
    foreach (int element in array)
        {
            if (element >= 10 && element <= 99) temp ++;
        }
        Console.WriteLine($"В массиве {temp} элементов которые лежат на отрезке [10, 99]");
}
int size = GetNumber("Введите длину массива");
int min = GetNumber("Введите минимальный диапазон для массива");
int max = GetNumber("Введите максимальный диапазон для массива");
int [] array = Getarray(size, min, max);
PrintArray(array);
Compare(array);