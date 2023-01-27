/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
От преподавателя: давайте сделаем через один ввод
то есть readline будет один.
считываете в переменную. а потом ее разбивайте через метод Split()
*/

void ArrayOfString (string text)
{
    char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

    string[] words = text.Split(delimiterChars);
    Console.Write("[");

//    foreach (var word in words)
    for (int i = 0; i < words.Length - 1; i++)
    {
        Console.Write($"{words[i]}, ");
    }
    Console.Write($"{words[words.Length - 1]}]");
}

Console.WriteLine("Введите числа для создания массива: ");
string text = Console.ReadLine();
ArrayOfString(text);