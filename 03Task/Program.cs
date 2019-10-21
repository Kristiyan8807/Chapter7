//Да се напише програма, която сравнява два масива от тип char лек-
//сикографски(буква по буква) и проверява кой от двата е по-рано в
//лексикографската подредба.
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        bool isArray1First = true;
        Console.Write("Enter first array : ");
        int length = int.Parse(Console.ReadLine());
        char[] array1 = new char[length];

        for (int i = 0; i < array1.Length; i++)
        {
            length = char.Parse(Console.ReadLine());
        }

        Console.Write("Enter second array : ");
        length = int.Parse(Console.ReadLine());
        char[] array2 = new char[length];

        for (int i = 0; i < array2.Length; i++)
        {
            length = char.Parse(Console.ReadLine());
        }

        int shortLenght = Math.Min(array1.Length, array2.Length);

        for (int i = 0; i < shortLenght; i++)
        {
            if (array1[i] != array2[i])
            {
                if (array1[i] < array2[i])
                {
                    isArray1First = true;
                }
                else
                {
                    isArray1First = false;
                }
            }
        }
        Console.WriteLine("Array1First {0}", isArray1First);

    }

}
