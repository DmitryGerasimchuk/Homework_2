﻿//  Задача № 3: 
//  Напишите программу,
//  которая принимает на вход цифру,
//  обозначающую день недели, 
//  и проверяет, является ли этот день выходным.

//  Проверка:
// 6 -> да 
// 7 -> да 
// 1 -> нет

int Prompt(string message) // Создание метода (функции), которая позволяет перевести введенню строку в цифру
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
bool ValidateDay(int weekDay) // Создание метода (функции), которая проверяет введеное число на соответствие условию
{
    if(weekDay == 1 || weekDay == 2 || weekDay == 3 || weekDay == 4 || weekDay == 5) // Описание будней
    {
        return true;
    }
    if(weekDay == 6 || weekDay == 7) // Описание выходных
    System.Console.WriteLine("Сегодня выходной: отдыхай!");
    return false;       
}
int day = Prompt("Введите цифрой день недели (помни: в неделе 7 дней)");

if(ValidateDay(day)) // Обращение к методу, который позволяет определить день недели
{
    System.Console.WriteLine("Сегодня не выходной: иди работай!");
}
if(day >= 8 || day <= 0) // Условие проверки для устранения неправильного ввода числа
{
   System.Console.WriteLine("Ой! Ты ввел число, не соответсвующее условию задачи. Попробуй еще раз."); 
}