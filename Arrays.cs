//// Level 1 - Fundamentals (Indexing & Loops)
//int[] arr1 = { 3, -10, 2, 7, -1, -5, 6, -6, 2, 1, 9, -5, 7, 4 };

//// Print Elements
//// Given an integer array, print all elements in order.
//for (int i = 0; i < arr1.Length; i++)
//{
//    Console.WriteLine(arr1[i]);
//}

//// Reverse Print
//// Print all elements of an array in reverse order without creating a new array.
//for (int i = arr1.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(arr1[i]);
//}

//// Sum of Elements
//// Compute the sum of all elements.
//int sum = 0;
//for (int i = 0; i < arr1.Length; i++)
//{
//    sum += arr1[i];
//}
//Console.WriteLine(sum);

//// Average Value
//// Find the average of elements (handle empty array safely).
//int sum = 0;
//for (int i = 0; i < arr1.Length; i++)
//{
//    sum += arr1[i];
//}
//double avg = (double) sum / arr1.Length;
//Console.WriteLine(avg);

//// Count Even and Odd
//// Count how many elements are even and how many are odd.
//int even = 0; // juft
//int odd = 0; // toq
//for (int i = 0; i < arr1.Length; i++)
//{
//    if (arr1[i] % 2 == 0)
//        even++;
//    else
//        odd++;
//}
//Console.WriteLine(even);
//Console.WriteLine(odd);

//// Find Maximum and Minimum
//// Find the largest and smallest values without using LINQ.
//int max = arr1[0];
//int maxE = 0;
//int min = arr1[0];
//int minE = 0;
//for (int i = 0; i < arr1.Length; i++)
//{
//    if (arr1[i] > max)
//    {
//        max = arr1[i];
//        maxE = i;
//    }

//    if (arr1[i] < min)
//    {
//        min = arr1[i];
//        minE = i;
//    }
//}
//Console.WriteLine($"arr1[{maxE}]=" + max);
//Console.WriteLine($"arr1[{minE}]=" + min);

//// Max of Even Numbers
//// Find the maximum value among even numbers only.
//int maxEven = arr1[0];
//for (int i = 0; i < arr1.Length; i++)
//{
//    if (arr1[i] > maxEven && arr1[i] % 2 == 0)
//    {
//        maxEven = arr1[i];
//    }
//}
//Console.WriteLine(maxEven);

//// Min of Positive Numbers
//// Find the smallest positive number.
//int minPos = arr1[0];
//for (int i = 0; i < arr1.Length; i++)
//{
//    if (arr1[i] < minPos && arr1[i] > 0)
//    {
//        minPos = arr1[i];
//    }
//}
//Console.WriteLine(minPos);

////Max Below Threshold
//// Find the largest number less than a given value X.
//int x = 5;
//int maxBelow = int.MinValue;
//for (int i = 0; i < arr1.Length; i++)
//{
//    if (arr1[i] < x)
//    {
//        if (arr1[i] > maxBelow)
//        {
//            maxBelow = arr1[i];
//        }
//    }
//}
//Console.WriteLine(maxBelow);

//// Min Above Threshold
//// Find the smallest number greater than a given value X.
//int x = 5;
//int minAbove = int.MaxValue;
//for (int i = 0; i < arr1.Length; i++)
//{
//    if (arr1[i] > x)
//    {
//        if (arr1[i] < minAbove)
//        {
//            minAbove = arr1[i];
//        }
//    }
//}
//Console.WriteLine(minAbove);

//// Second Maximum
//// Find the second largest distinct value.
//int largest = int.MinValue;
//int secondLargest = int.MinValue;
//for (int i = 0; i < arr1.Length; i++)
//{
//    if (arr1[i] > largest)
//    {
//        secondLargest = largest;
//        largest = arr1[i];
//    }
//    else if (arr1[i] > secondLargest && arr1[i] < largest)
//    {
//        secondLargest = arr1[i];
//    }
//}
//Console.WriteLine(secondLargest);

//// Second Minimum
//// Find the second smallest distinct value.
//int smallest = int.MaxValue;
//int secondSmallest = int.MaxValue;
//for (int i = 0; i < arr1.Length; i++)
//{
//    if (arr1[i] < smallest)
//    {
//        secondSmallest = smallest;
//        smallest = arr1[i];
//    }
//    else if (arr1[i] < secondSmallest && arr1[i] > smallest)
//    {
//        secondSmallest = arr1[i];
//    }
//}
//Console.WriteLine(secondSmallest);

//// Max Difference
//// Find the difference between max and min.
//int difference = 0;
//int max = arr1[0];
//int min = arr1[0];
//for (int i = 0; i < arr1.Length; i++)
//{
//    if (arr1[i] > max)
//        max = arr1[i];

//    if (arr1[i] < min)
//        min = arr1[i];
//}
//difference = max - min;
//Console.WriteLine(difference);

//// Closest to Zero
//// Find the number closest to 0.
//// If two values are equally close, choose the positive one.
//int min = int.MaxValue;
//int max = int.MinValue;
//for (int i = 0; i < arr1.Length; i++)
//{
//    if (arr1[i] < 0 && arr1[i] > max)
//    {
//       max = arr1[i];
//    }
//    else if (arr1[i] >= 0 && arr1[i] < min)
//    { 
//       min = arr1[i];
//    }
//}
//Console.WriteLine(
//    Math.Abs(max) >= Math.Abs(min) ? min : max
//);