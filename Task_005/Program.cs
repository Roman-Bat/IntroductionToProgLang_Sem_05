/*
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 12 10
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
void Proizved(int[] array)
{
    int 
        foreach (int element in array)
        {
            if (element > 0) PositiveSum += element;
            else NegativeSum += element;
        }
        Console.WriteLine($"Сумма положительных элементов массива {PositiveSum}, сумма отрицательных элементов массива {NegativeSum}");
}
int size = GetNumber("Введите длину массива");
int min = GetNumber("Введите минимальный диапазон для массива");
int max = GetNumber("Введите максимальный диапазон для массива");
int [] array = Getarray(size, min, max);
PrintArray(array);
