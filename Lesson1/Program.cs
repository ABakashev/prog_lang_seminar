/*Это команда выводит текст
Console.WriteLine("Hello World!");
Console.WriteLine("Lets check if 1st number is square of 2nd number.");
Console.WriteLine("Please, write 1st number.");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, write 2nd number.");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine("It is true");
}
else
{
    Console.WriteLine("It is false");
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int negNum = -num;

while (negNum <= num)
{
    Console.Write(negNum + " ");
    negNum++;
}*/

//Программа принимает на вход трех значное число и на выходе показывает сумму первой и третьей цифры этого числа
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 || num < 1000)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    Console.WriteLine("Сумма первой и третьей цифры числа: " + (firstDigit + lastDigit));
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
