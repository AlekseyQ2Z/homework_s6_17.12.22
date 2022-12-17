// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Не использовать массив.
// M=5 ; 0, 7, 8, -2, -2 -> 2
// M=5 ; -1, -7, 567, 89, 223 -> 3

Console.Write("Введите количество чисел: ");
int mountofnumbers = Convert.ToInt32(Console.ReadLine());
int numbers = 0;
int positivenumbers = 0;
for (int i = 1; i < mountofnumbers+1; i++)
{
    Console.Write("Введите " + i + " число: ");
    numbers = Convert.ToInt32(Console.ReadLine());
    if (numbers > 0)
    {
        positivenumbers++;
    }
}
Console.Write("Положительных числа/-ел -> " + positivenumbers);