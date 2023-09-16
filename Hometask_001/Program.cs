/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
*/
int GetLength(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]+ " ");
}
}
int[] RandMass (int lengthmass)
{
    int[] result = new int[lengthmass];
    Random rand = new Random();
    
        for (int i = 0; i < lengthmass; i++)
        {
            result[i] = rand.Next(100, 1000);
        }
        return result;
}
int findEven(int[] massiveTo)
{
    int evenNum = 0;
    for (int i = 0; i < massiveTo.Length; i++)
    {
        if (massiveTo[i] % 2 == 0) evenNum ++;
    }
    return evenNum;
}


// основная программа
int size = GetLength("Введите количество элементов массива"); // запрашиваем у пользователя количество элементов массива
int[] massive = RandMass(size); // вызываем метод для получения рандомного массиво длинной, которую запросил пользователь
PrintArray(massive); // выводим массив в консоль для визуализации данных
int evenNum = findEven(massive); // вызываем метод проверки элементов массива на чётность
Console.WriteLine($"Количество чётных элементов массива равно {evenNum}"); // выводим в консоль подсчитанное число четных элементов массива