//Task 1.
// Console.WriteLine("Enter number which represents length of an array");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[length];
// int count = 0;
// var rnd = new Random();
// Console.WriteLine("Your array is:");
// for (int i = 0; i < length; i++)
// {
//     arr[i] = rnd.Next(1, 101);
//     Console.Write(arr[i] + "\t");
//     if (arr[i] >= 20 && arr[i] <= 90)
//     {
//         count = count + 1;
//     }
// }
// Console.WriteLine($"\nThe number of integers between 20 and 90 inclusive is:\n {count}");

//Task 2.

// using System.ComponentModel.DataAnnotations;

// Console.WriteLine("Enter the length of an array");
// if (!int.TryParse(Console.ReadLine(), out int length) || length <= 0)
// {
//     Console.WriteLine("Invalid length. Please enter a positive integer");
//     return;
// }

// int[] arr = new int[length];
// int countEven = 0;
// int countOdd = 0;
// var rnd = new Random();
// Console.WriteLine("Your array is:");
// for (int i = 0; i < length; i++)
// {
//     arr[i] = rnd.Next(1, 101);
//     Console.Write(arr[i] + "\t");
//     if (arr[i] % 2 == 0)
//     {
//         countEven = countEven + 1;
//     }
//     else
//     {
//         countOdd = countOdd + 1;
//     }
// }

// Console.WriteLine($"\nValue of even numbers are:\n {countEven};\nValue of odd numbers are:\n {countOdd};");


// Task 3. 

// Console.WriteLine("Enter the length of an array");
// if (!int.TryParse(Console.ReadLine(), out int length) || length <= 0)
// {
//     Console.WriteLine("Invalid length. Please enter a positive integer");
//     return;
// }

// double[] arr = new double[length];
// var rnd = new Random();
// Console.WriteLine("Your array is:");
// for (int i = 0; i < length; i++)
// {
//     arr[i] = rnd.Next(1, 101) + Math.Max(0.01, rnd.NextDouble());
//     Console.Write($"{arr[i]:F2}\t");
// }
// double min = arr[0];
// double max = arr[0];
// for (int i = 0; i < length; i++)
// {
//     if (min > arr[i])
//     {   
//         min = arr[i];
//     }
//     else if (max < arr[i])
//     {
//         max = arr[i];
//     }
// }
// Console.WriteLine($"\nMaximum element of array is {max:F2};\nMinimum element of array is {min:F2}");
// Console.WriteLine($"Difference between Max and Min is {(max - min):F2}");

//Task 4.

Console.WriteLine("Do you want to generate any number between 1 and 100 000? Please type (1) to continue are (0) to return.");
if (!int.TryParse(Console.ReadLine(), out int consent) || consent != 1 && consent != 0)
{
    Console.WriteLine("Invalid command. Please enter (1) or (0)");
    return;
}
else if (consent == 0)
{
    return;
}
int rndNum = new Random().Next(1, 100001);
Console.WriteLine($"Your number is {rndNum}");
int length = rndNum;
int count = 0;
while (length > 0)
{
    length /= 10;
    count++;
}
int[] arr = new int[count];
for (int i = 0; i < arr.Length; i++ , rndNum/=10)
{
    arr[arr.Length - 1 - i] = rndNum % 10;
}
int arrMax = arr[0];
int arrMin = arr[0];
int indMax = 0;
int indMin = 0;
Console.WriteLine("Your array is:");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + "\t");
    if (arrMax < arr[i])
    {
        arrMax = arr[i];
        indMax = i;
    }
    else if (arrMin > arr[i])
    {
        arrMin = arr[i];
        indMin = i;
    }
}
Console.WriteLine($"\nMax Element {arrMax} (index {indMax}); Min Element {arrMin} (index {indMin});");

int temp = 0;

temp = arr[0];
arr[0] = arrMin;
arr[indMin] = temp;

if (indMax == 0) indMax = indMin;

temp = arr[arr.Length - 1];
arr[arr.Length - 1] = arrMax;
arr[indMax] = temp;

Console.WriteLine("Your modefied array is:");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + "\t");
}