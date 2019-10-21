//Да се напише програма, която чете два масива от конзолата и прове-
//рява дали са еднакви(два масива са еднакви, когато имат еднаква
//дължина и елементите им, записани под едни и същи индекси, са
//еднакви).
using System;

class Program
{
    static void Main()
    {
        bool isArrayEqual = true;
        Console.Write("Enter lenght of first array: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter element {0}:  ", i);
            array[i] = int.Parse(Console.ReadLine());
        }


        Console.Write("Enter lenght of second array: ");

        if (length != int.Parse(Console.ReadLine())) Console.WriteLine("The Arrays have difrent lenghts");
        else
        {
            int[] array1 = new int[length];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("Enter element {0}:  ", i);
                array1[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != array1[i])
                {

                    Console.WriteLine("The Arrays have diffrent elements");
                    isArrayEqual = false;
                    break;
                }
            }
            if (isArrayEqual) Console.WriteLine("The arrays are equal");
        } 

    }
}
