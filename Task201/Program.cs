// Задача № 1:
// Напишите программу,
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета.

// Проверка:
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num) // Создание метода (функции), которая проверяет введеное число
{
    if(num >= 100 && num < 1000) // Проверка числа на трехзначность
    {
        return true;
    }
    System.Console.WriteLine("Вы ввели не трехзначное положительное число.");
    return false;       
}

int number = Prompt("Введите любое положительное трехзначное число");

if(Validate(number))
{
    int secondNumber = (number / 10) % 10; // Нахождение последнего числа в цифре
    System.Console.WriteLine($"Вторая цифра числа {number} равна {secondNumber}.");
}