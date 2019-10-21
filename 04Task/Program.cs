//Напишете програма, която намира максимална редица от последо-
//вателни еднакви елементи в масив.Пример: {2, 1, 1, 2, 3, 3, 2, 2,
//2, 1} → {2, 2, 2}.
using System;

class Program
{
    static void Main()
    {
        int count = 1, tempCount = 1, number = 0;

        Console.Write("Enter array length: ");
        int length = Int32.Parse(Console.ReadLine());
        int[] arr = new int[length];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter {0} element: ", i);
            arr[i] = Int32.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1]) tempCount++;
            else tempCount = 1;

            if (tempCount > count)
            {
                count = tempCount;
                number = arr[i];
            }
        }

        for (int i = 0; i < count; i++) Console.Write("{0}, ", number);
    }
}
