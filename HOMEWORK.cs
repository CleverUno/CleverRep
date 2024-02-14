
using System;

class Program
{
    static void Main()
    {
        // Запросить у пользователя размер массива
        Console.WriteLine("Введите размер массива:");
        int size = int.Parse(Console.ReadLine());

        // Создать массив заданного размера
        char[] array = new char[size];

        // Заполнить массив значениями, введенными с клавиатуры
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Введите элемент массива №{i + 1}:");
            char inputChar = Console.ReadKey().KeyChar;
            array[i] = char.IsDigit(inputChar) ? '!' : inputChar;
        }

        // Вывести массив на экран для проверки
        Console.WriteLine("\nВы ввели следующий массив с заменой цифр на '*':");
        foreach (char item in array)
        {
            Console.Write(item + " ");
        }
        Console.ReadLine();
    }
}

using System;

class Program
{
    static void Main()
    {
        // Входной массив символов
        char[] symbols = { 'a', 'b', 'c', '1', '2', '3', '!', '!', '!', '!', 'x', 'y', 'z', '!' };

        // Переменная для хранения длины текущей серии символов
        int currentLength = 0;

        // Переменная для хранения длины максимальной серии символов
        int maxLength = 0;

        // Проходим по массиву символов
        for (int i = 0; i < symbols.Length; i++)
        {
            // Если текущий символ не является буквой, увеличиваем длину текущей серии
            if (!char.IsLetter(symbols[i]))
            {
                currentLength++;
            }
            // Если текущий символ является буквой или мы достигли конца массива,
            // проверяем, является ли текущая серия символов максимальной
            if (char.IsLetter(symbols[i]) || i == symbols.Length - 1)
            {
                maxLength = Math.Max(maxLength, currentLength);
                currentLength = 0;
            }
        }

        // Выводим на экран длину максимальной серии символов, отличных от букв
        Console.WriteLine($"Длина максимальной серии символов, отличных от букв: {maxLength}");
    }
}


using System;

class Program
{
    static void Main()
    {
        // Запросить у пользователя ввод массива символов
        Console.WriteLine("Введите массив символов из 23 элементов:");
        string input = Console.ReadLine();

        // Удаление пробелов из введенной строки
        input = input.Replace(" ", "");

        // Проверка на палиндром
        bool isPalindrome = true;
        int length = input.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (input[i] != input[length - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }

        // Вывод результата
        if (isPalindrome)
        {
            Console.WriteLine("Введенная строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Введенная строка не является палиндромом.");
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        // Запросить у пользователя ввод строки
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        // Проверка, что строка не пустая
        if (!string.IsNullOrEmpty(input))
        {
            // Изменить первый символ на пробел
            char[] charArray = input.ToCharArray();
            charArray[0] = ' ';

            // Изменить последний символ на точку
            int lastIndex = charArray.Length - 1;
            charArray[lastIndex] = '.';

            // Создать новую строку из измененного массива символов
            string modifiedString = new string(charArray);

            // Вывести измененную строку
            Console.WriteLine("Измененная строка:");
            Console.WriteLine(modifiedString);
        }
        else
        {
            Console.WriteLine("Введена пустая строка.");
        }
    }
}

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Запросить у пользователя ввод строки
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        // Заменить каждую русскую букву символом '*'
        string result = Regex.Replace(input, @"[А-Яа-я]", "*");

        // Вывести измененную строку
        Console.WriteLine("Измененная строка:");
        Console.WriteLine(result);
    }
}


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Заданные строки
        string firstString = "abcdef";
        string secondString = "cdegh";

        // Построение новой строки
        string result = new string(firstString.Except(secondString).ToArray());

        // Вывод результата
        Console.WriteLine("Новая строка:");
        Console.WriteLine(result);
    }
}