/*
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

int GetNumber(string message)   // прием чисел от пользователя, с выводом произвольного сообщения
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Getarray(int length, int min, int max) //метод получения массива любой длинны в различных диапазонах
{
    int[] result = new int[length];         // создаем массив длинны которую задал пользователь
    Random rand = new Random();             // создаем объект метода рандом
        for (int i = 0; i < result.Length; i++)     // в цикле присваиваем элементам массива рандомные значения
        {
            result[i] = rand.Next(min, max + 1);  //рандомные значения из диапазона
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
int[] Convertor(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = array[index] * (-1);
        index ++; 
    }
        return array;
    
}


int size = GetNumber("Введите длину массива");
int min = GetNumber("Введите минимальный диапазон для массива");
int max = GetNumber("Введите максимальный диапазон для массива");
int [] array = Getarray(size, min, max);
PrintArray(array);
int[] arrayEnd = Convertor(array);
Console.WriteLine();
PrintArray(arrayEnd);
