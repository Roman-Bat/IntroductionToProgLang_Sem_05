/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
            result[i] = rand.Next(0, 1000);
        }
        return result;
}
int findNoEven(int[] massiveTo)
{
    int NoevenNum = 0;
    for (int i = 0; i < massiveTo.Length; i++)
    {
        if (i % 2 != 0) NoevenNum = NoevenNum + massiveTo[i];
    }
    return NoevenNum;
}


// основная программа
int size = GetLength("Введите количество элементов массива"); // запрашиваем у пользователя количество элементов массива
int[] massive = RandMass(size); // вызываем метод для получения рандомного массиво длинной, которую запросил пользователь
PrintArray(massive); // выводим массив в консоль для визуализации данных
int noevenNum = findNoEven(massive); // вызываем метод проверки элементов массива на нечётность
Console.WriteLine($"Сумма нечётных элементов массива равна {noevenNum}"); // выводим в консоль сумму элементов стоящих на нечётных позициях