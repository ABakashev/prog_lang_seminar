// Console.WriteLine("Enter number you looking for in array");
// int serchNum = Convert.ToInt32(Console.ReadLine());
// int rnd = new Random().Next(5, 10);
// int[] array = new int[rnd];

// Console.WriteLine("Your generated array is");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 20);
//     Console.Write(array[i] + " ");
// }
// int match = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == serchNum)
//     {
//         match = match + 1;
//     }

// }

// if (match > 1)
// {
//     Console.WriteLine($"\nFound {match} matches");
// }
// else if (match == 1)
// {
//     Console.WriteLine($"\nFound 1 match");
// }
// else
// {
//     Console.WriteLine($"\nNo match has been found");
// }

// int[] arr = new int[10];
// Console.WriteLine("Your array is");
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(-10, 11);
//     Console.Write(arr[i] + "\t");
// }
// Console.WriteLine("\nYour reverse array is");
// foreach (int e in arr)
// {
//     Console.Write(-e +"\t");
// }

// Console.WriteLine("Enter your array's lenght");
// int lng = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[lng];
// int[] arrProd = new int[lng / 2];

// Console.WriteLine("Your arra is");
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(1, 11);
//     Console.Write(arr[i] + "  ");
// }

// Console.WriteLine("\nProduct of firsts and lasts numbers of array:");
// for (int i = 0; i < arr.Length/2+1; i++)
// {
//     int j = arr.Length - 1 - i;
//     if (i == j)
//     {
//         Console.WriteLine($"\nElement {arr[i]} doesn't have match");
//     }
//     else
//     {
//         arrProd[i] = arr[i] * arr[j];
//         Console.Write(arrProd[i] + "\t");
//     }

// }

// Console.WriteLine("Enter your array's length:");
// int lng = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[lng];

// Console.WriteLine("Your array is:");
// Random rnd = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = rnd.Next(1, 11);
//     Console.Write(arr[i] + "  ");
// }

// Console.WriteLine("\nProduct of first and last numbers:");
// for (int i = 0; i < (arr.Length + 1) / 2; i++)
// {
//     int j = arr.Length - 1 - i;

//     if (i == j) // середина массива при нечётной длине
//     {
//         Console.WriteLine($"Element {arr[i]} doesn't have match");
//     }
//     else
//     {
//         int prod = arr[i] * arr[j];
//         Console.Write(prod + "  ");
//     }
// }

// Console.WriteLine("Enter your number");
// int num = Convert.ToInt32(Console.ReadLine());
// int leng = num;
// int count = 0;
// while (leng > 0)
// {
//     leng = leng / 10;
//     count++;
// }
// Console.WriteLine($"{count} digit/s");

// int[] arr = new int[count];
// for (int i = 0; i < arr.Length; i++, num/=10)
// {
//     arr[arr.Length - 1 - i] = num % 10;
// }
// int arrMax = arr[0];
// int arrMin = arr[0];
// int maxIndex = 0;
// int minIndex = 0;
// for (int i=1; i < arr.Length; i++)
// {
//     if (arrMax<arr[i])
//     {
//         arrMax = arr[i];
//         maxIndex = i;
//     }
//     else if (arrMin>arr[i])
//     {
//         arrMin = arr[i];
//         minIndex = i;
//     }
// }
// Console.WriteLine($"Max Element {arrMax} (index {maxIndex}); Min Element {arrMin} (index {minIndex})");

// int temp = arr[0];
// arr[0] = arrMin;
// arr[minIndex] = temp;

// if (maxIndex == 0) maxIndex = minIndex;

// temp = arr[arr.Length - 1];
// arr[arr.Length - 1] = arrMax;
// arr[maxIndex] = temp;

// Console.Write("Your modefied array:");
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i]+"\t"); 
// } 

// Console.WriteLine("Enter your number");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] arr = new int[3];
// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = num % 10;
//     Console.WriteLine(arr[i] + "\t");
//     count = count + 1;
// }
