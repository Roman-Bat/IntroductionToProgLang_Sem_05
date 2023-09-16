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
int[] Proizved(int[] array)
{
    int[] result = new int [array.Length];
    int start = 0;
    int end = array.Length - 1;
    while (start <= end)
    {
        if(start >= end) result[start] = array[end];
        else result[start] = array[start] * array[end];
        start ++;
        end --;
    }
    int[] allResult = new int [start];
    for (int i = 0; i <= start-1; i++)
    {
        allResult[i] = result[i];
    }
    return allResult;
}
int size = GetNumber("Введите длину массива");
int min = GetNumber("Введите минимальный диапазон для массива");
int max = GetNumber("Введите максимальный диапазон для массива");
int [] array = Getarray(size, min, max);
PrintArray(array);
Console.WriteLine();
int[] newarray = Proizved(array);
PrintArray(newarray);
