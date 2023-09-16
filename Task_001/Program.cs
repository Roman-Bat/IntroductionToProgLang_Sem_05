/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.
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
void GetPosNegSum(int[] array)
{
    int PositiveSum = 0;
    int NegativeSum = 0;
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
GetPosNegSum(array);



