// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Enter numbers: ");
var arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

int CountPosNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }

    }
    return count;
}

int res = CountPosNum(arr);
System.Console.WriteLine(res);