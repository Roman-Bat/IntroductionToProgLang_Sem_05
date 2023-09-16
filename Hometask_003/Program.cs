/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int GetLength(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]+ " ");
}
}
double[] RandMass (int lengthmass)
{
    double[] result = new double[lengthmass];
    Random rand = new Random();
    
        for (int i = 0; i < lengthmass; i++)
        {
            result[i] = Math.Round(rand.NextDouble(), 2);
        }
        return result;
}
double findMin(double[] massiveTo)
{
    double min  = massiveTo[0];
    for (int i = 0; i < massiveTo.Length; i++)
    {
        if (min > massiveTo[i]) min = massiveTo[i];
    }
    return min;
}
double findMax(double[] massiveTo)
{
    double max  = massiveTo[0];
    for (int i = 0; i < massiveTo.Length; i++)
    {
        if (max < massiveTo[i]) max = massiveTo[i];
    }
    return max;
}

// основная программа
int size = GetLength("Введите количество элементов массива"); // запрашиваем у пользователя количество элементов массива
double[] massive = RandMass(size); // вызываем метод для получения рандомного массиво длинной, которую запросил пользователь
PrintArray(massive); // выводим массив в консоль для визуализации данных
double min = findMin(massive); // находим минимальный элемент массива
double max = findMax(massive); // находим максимальный элемент массива
double different = max - min; // находим разницу между максимальным и минимальным элементом
Console.WriteLine($"Максимальный элемент массива {max}, минимальный элемент {min}, разница между ними {different}"); // выводим в консоль сумму элементов стоящих на нечётных позициях