// int rnd = new Random().Next(100, 1000);
// Console.WriteLine($"Your number is \n{rnd}");
// int num1 = rnd / 100;
// int num2 = rnd/10%10;
// int num3 = rnd % 10;
// int result = (int)Math.Pow(num2, num3);

// Console.WriteLine($"\nYour answer is \n{result}");

// int result2 = 1;
// for (int i = 0; i < num3; i++)
// {
//         result2 *= num2;
// }
// Console.WriteLine($"\nYour answer is \n{result2}");

// Console.WriteLine("Please enter two numbers");
// int num1 = int.Parse(Console.ReadLine());
// int num2 = int.Parse(Console.ReadLine());

// if (num2 == 0)
// {
//     Console.WriteLine("Devision by zero is not allowed");
// }

// else if (num1 % num2 == 0)
// {
//     Console.WriteLine("The first number is divisible by the second");
// }

// else
// {
//     Console.WriteLine($"The remainder of the division is {num1 % num2}");
// }

Console.WriteLine("Please enter your number");
int num = int.Parse(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("This number has less than three digits, it is not allowed");
}
else
{
    num = num / 100%10;
    Console.WriteLine(num);
}

