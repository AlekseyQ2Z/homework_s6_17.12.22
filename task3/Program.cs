// Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.
// 1, 3, 8, 3, 2 -> 11
// 8, 3, 4, 2 -> 28

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
}

int SumProductsPairsNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0, j = arr.GetLength(0) - 1 ; i < arr.GetLength(0) / 2; i++, j-- )
    {
        sum = sum + arr[i] * arr[j];
    }
    return sum;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write(arr[i] + " ");
    }
}

Console.WriteLine("Введите длинну одномерного массива: ");
int arraylength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraylength];
FillArray(array);
PrintArray(array);
Console.Write(" сумма произведений пар чисел -> " + SumProductsPairsNumbers(array));

