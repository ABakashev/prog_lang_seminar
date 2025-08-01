/* Напишите метод, который на вход принимает два целых числа и проверяет,
делится ли первое число на второе. Если делится, выводите "делится", иначе
выводите "не делится".
Console.WriteLine("Провка делимости чисел без остатка");
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 == 0)
{
    Console.WriteLine("Нельзя делить на ноль");
}
else if (num1 % num2 == 0)
{
    Console.WriteLine("Делится");
}
else
{
    Console.WriteLine("Не делится");
}*/

/*Напишите метод, который принимает на вход три числа и возвращает 4 7 5
среднее из этих чисел (то есть не самое большое и не самое маленькое).*/

// Console.WriteLine("Enter 3 numbers.");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// int secondMax = int.MinValue;

// if ((num1 < num2 && num1 > num3) || (num1 > num2 && num1 < num3))
// {
//     secondMax = num1;
// }
// else if ((num2 < num1 && num2 > num3) || (num2 > num1 && num2 < num3))
// {
//     secondMax = num2;
// }
// else
//     secondMax = num3;
// Console.WriteLine("Average between 3 numbers is " + secondMax);

// Console.WriteLine("Enter 10 numbers");
// int max = int.MinValue;
// int secondMax = int.MinValue;

// for (int i = 0; i < 10; i++)
// {
//     int num = Convert.ToInt32(Console.ReadLine());

//     if (num > max)
//     {
//         secondMax = max;
//         max = num;
//     }
//     else if (num > secondMax && num < max)
//     {
//         secondMax = num;
//     }
// }

// if (secondMax == int.MinValue)
// {
//     Console.WriteLine("There is no second maximum number. Are all numbers equal?");
// }
// else
// {
//     Console.WriteLine("Second maximum number is " + secondMax);
// }
//Задание 3: Напишите метод, который на вход принимает число и выводит, является ли
// оно положительным (больше нуля), отрицательным (меньше нуля) или нулём.

// Console.WriteLine("Please, enter your number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 0)
// {
//     Console.WriteLine("Positive");
// }
// else if (num < 0)
// {
//     Console.WriteLine("Negative");
// }
// else
// {
//     Console.WriteLine("Equel to Zero");
// }

// Задача 4. Напишите метод, который на вход принимает число (number), а на выходе
// выводит все нечетные числа от 1 до number (включительно), после каждого числа
// должен быть знак пробела.

Console.WriteLine("Please, enter your number");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= num)
{
    Console.Write(i + " ");
    i = i + 2;
}