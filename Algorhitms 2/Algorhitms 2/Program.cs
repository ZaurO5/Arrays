//task 1

//int[] numbers = { 1, 2, 3, 4, 5, };
//for (int i = 0; i < numbers.Length; i++)

//    Console.WriteLine(numbers[i]);


//task 2

//int[] numbers = { 1, 2, 3, 4, 5 };
//int sum =0;
//for (int i = 0; i < numbers.Length; i++)
//    sum += numbers[i];

//Console.WriteLine(sum);



//task 3

//int[] numbers = { 1, 2, 3, 4, 5 };
//for (int i = numbers.Length-1; i >=0; i--)
//{ 
//    Console.WriteLine(numbers[i]);
//}

//task 4

////reverse

//int[] numbers = new int[5];

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine($"enter the number {i + 1}");
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//for (int j = 0; j < numbers.Length / 2; j++)
//{
//    int temp = numbers[j];
//    numbers[j] = numbers[numbers.Length - 1 - j];
//    numbers[numbers.Length - 1 - j] = temp;
//}

//for (int k = 0; k < numbers.Length; k++)
//{
//    Console.WriteLine(numbers[k] + " ");
//}

//task 5

//int[] numbers = { 5, 2, 1, 4, 3 };
//int max = 0;
//int a;
//for (int i = 0 ; i < numbers.Length; i++)
//{
//    a = numbers[i];
//   // max = Math.Max(max, a);
//    if (a > max)
//    {
//        max = a;
//    }
//}
//Console.WriteLine(max );

//task 6

//int[] numbers = { 1, 2, 3, 4, 5, };
//int count = 0;
//for (int i = 0; i < numbers.Length; i++)

//    count++;

//Console.WriteLine(count);

//task 7

//// Optimized C# implementation of Bubble sort
//using System;

//class GFG
//{
//    // An optimized version of Bubble Sort
//    static void bubbleSort(int[] arr, int n)
//    {
//        int i, j, temp;
//        bool swapped;
//        for (i = 0; i < n - 1; i++)
//        {
//            swapped = false;
//            for (j = 0; j < n - i - 1; j++)
//            {
//                if (arr[j] > arr[j + 1])
//                {

//                    // Swap arr[j] and arr[j+1]
//                    temp = arr[j];
//                    arr[j] = arr[j + 1];
//                    arr[j + 1] = temp;
//                    swapped = true;
//                }
//            }

//            // If no two elements were
//            // swapped by inner loop, then break
//            if (swapped == false)
//                break;
//        }
//    }

//    // Function to print an array
//    static void printArray(int[] arr, int size)
//    {
//        int i;
//        for (i = 0; i < size; i++)
//            Console.Write(arr[i] + " ");
//        Console.WriteLine();
//    }

//    // Driver method
//    public static void Main()
//    {
//        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
//        int n = arr.Length;
//        bubbleSort(arr, n);
//        Console.WriteLine("Sorted array:");
//        printArray(arr, n);
//    }
//}


//task 8

//int[] numbers = {0, 1, 2, 3, 4, 5 };
//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"{count} defe 0 istifade olunub");

//task 9


//int[] numbers = { 0, 1, -2, 3, 4, -5 };
//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] < 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"{count} defe menfi eded istifade olunub");

//task 10

//int[] numbers = { 0, 1, -2, 3, 4, -5 };
//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"{count} defe musbet eded istifade olunub");

//task 11

//using System.Globalization;

//int[] Numbers = { 10, 20, 30 };
//for (int i = 0; i < Numbers.Length; i++)
//{
//    int temp = Numbers[i] * Numbers[i];
//    Numbers[i] = temp;
//}
//for (int c = 0; c < Numbers.Length; c++)
//{
//    Console.WriteLine(Numbers[c]);
//}

//task 12

//// C# program sort an array 
//// in decreasing order using 
//// iterative way
//using System;

//class GFG
//{

//    // Main Method
//    public static void Main()
//    {
//        // declaring and initializing the array
//        int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

//        int temp;

//        // traverse 0 to array length
//        for (int i = 0; i < arr.Length - 1; i++)

//            // traverse i+1 to array length
//            for (int j = i + 1; j < arr.Length; j++)

//                // compare array element with 
//                // all next element
//                if (arr[i] < arr[j])
//                {

//                    temp = arr[i];
//                    arr[i] = arr[j];
//                    arr[j] = temp;
//                }

//        // print all element of array
//        foreach (int value in arr)
//        {
//            Console.Write(value + " ");
//        }
//    }
//}
