// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введи число");
int mum = Convert.ToInt32(Console.ReadLine());
int[] num = new int [mum];
int sam = 0;

for (int i = 0; i < num.Length; i++)
{   
    Console.WriteLine("Введи число");
    num[i] = Convert.ToInt32(Console.ReadLine());
    if (num[i]>0)
    {
        sam++;
    }
}
Console.WriteLine(sam);