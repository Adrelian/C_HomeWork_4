// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void Logorifm()
// {
//     Console.Write("Введите число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите степень: ");
//     int degree = Convert.ToInt32(Console.ReadLine());

//     int result = 1;
//     int count = 1; 
//     while (count <= degree)
//     {
//         result = result*number;
//         count++;
//     }
//     Console.WriteLine($"{number}^{degree} = {result}");
// }
// Logorifm();



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

void findSumNumber()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    {
        // Дробив число справа на лево и складываем эти числа
        int sum = 0; //сумма цифр
        int newNumber = number; //начало отсчета
        while (number > 0)
        {
            int rightNumber = number % 10; //правое число (1234 -> 4)
            newNumber = number; // оставшееся число (123)
            number = number / 10; //Уменьшаем кол-во разрядов (1234 -> 123)
            sum = sum + rightNumber; //общая сумма (0 + 4)
        }
        Console.WriteLine($"Сумма цифр: {sum}");
    }
}

findSumNumber();




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]