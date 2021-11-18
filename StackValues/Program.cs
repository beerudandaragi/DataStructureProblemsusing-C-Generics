using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Stack<int> StackObjects = new Stack<int>();
        StackObjects.Push(56);
        StackObjects.Push(30);
        StackObjects.Push(70);


        foreach (int item in StackObjects)
            Console.WriteLine("Ouptut of storedvalues:" + item);
        Console.ReadLine();

    }

}