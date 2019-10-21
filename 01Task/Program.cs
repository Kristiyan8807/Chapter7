//Да се напише програма, която създава масив с 20 елемента от цело-
//числен тип и инициализира всеки от елементите със стойност, равна
//на индекса на елемента умножен по 5. Елементите на масива да се
//изведат на конзолата.
using System;

class Program
{
    static void Main()
    {
        int[] intArray = new int[20];
        for (int i = 1; i < intArray.Length; i++)
        {
            intArray[i] = i * 5;
            Console.WriteLine(intArray[i]);
        }
    }
}

