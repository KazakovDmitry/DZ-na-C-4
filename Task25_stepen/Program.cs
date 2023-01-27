/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели некорректное число. Повторите ввод");
        }
    }
    return result;
}

int Exponentiation (int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

int a = GetNumber("Введите число А: ");
int b = GetNumber("Введите число B: ");
int result = Exponentiation(a, b);
Console.WriteLine($"Число {a} в степени {b} = {result}");