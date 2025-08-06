//Task 1.

// Console.WriteLine("Please, enter your number");
// int num = int.Parse(Console.ReadLine());

// if (num % 7 == 0 && num % 23 == 0)
// {
//     Console.WriteLine("Your number divides evenly by 7 and 23");
// }
// else
// {
//     Console.WriteLine("Your number does'nt divide evenly by 7 and 23");
// }

// //Task 2.
// Console.WriteLine("Please, enter coordinate X");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Please, enter enter coordinate Y");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x==0 || y ==0)
// {
//     Console.WriteLine("Your point lies on an axis");
// }

// else if (x > 0 && y > 0)
// {
//     Console.WriteLine("First zone");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Second zone");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Third zone");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Fourth zone");
// }

//Task 3.

// Console.WriteLine("Please, enter your number between and including 10 to 99");
// int num = Convert.ToInt32(Console.ReadLine());
// int digit1 = num / 10;
// int digit2 = num % 10;

// if (num >= 10 && num <= 99)

// {
//     if (digit1 == digit2)
//     {
//         Console.WriteLine($"Both digits are equal and equal to {digit1}");
//     }
//     else if (digit1 > digit2)
//     {
//         Console.WriteLine($"The biggest digit of this number is {digit1}");
//     }
//     else
//     {
//         Console.WriteLine($"The biggest digit of this number is {digit2}");
//     }
// }
// else
// {
//     Console.WriteLine("Your number is out of range");
// }

Console.WriteLine("Please, enter your number");
int num = Convert.ToInt32(Console.ReadLine());
int reversed = 0;

Console.WriteLine("Digits of this number are:");
while (num != 0)
{
    int digit = num % 10;
    reversed = reversed * 10 + digit;
    num /= 10;
}
while (reversed != 0)
{
    if (reversed / 10 != 0)
    {
        int digit2 = reversed % 10;
        Console.Write($"{digit2},");
        reversed /= 10;
    }
    else
    {
        int digit2 = reversed % 10;
        Console.Write($"{digit2}.");
        reversed /= 10;
    }
}