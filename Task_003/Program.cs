/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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
void FindNumber(int[] array, int number)
{
    int numberCy = number;
    string answer = "нет";
    foreach (int element in array)
        {
            if (element == numberCy) answer = "да"; break;
        }
        Console.WriteLine(answer);
}
int size = GetNumber("Введите длину массива");
int min = GetNumber("Введите минимальный диапазон для массива");
int max = GetNumber("Введите максимальный диапазон для массива");
int number = GetNumber("Введите число для сравнения");
int [] array = Getarray(size, min, max);
PrintArray(array);
FindNumber(array, number);
