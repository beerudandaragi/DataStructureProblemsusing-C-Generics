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
        {
            Console.WriteLine("Ouptut of storedvalues:" + item);
        }
        {
            Console.WriteLine("Peak element:" + StackObjects.Peek());
            Console.WriteLine("pop of the storedvalues:" + StackObjects.Pop());
            Console.WriteLine("after the peek and pop  stored values:" + StackObjects.Count);
        }
        {
            Console.WriteLine("Peak element:" + StackObjects.Peek());
            Console.WriteLine("pop of the storedvalues:" + StackObjects.Pop());
            Console.WriteLine("after the peek and pop  stored values:" + StackObjects.Count);
        }
        {
            Console.WriteLine("Peak element:" + StackObjects.Peek());
            Console.WriteLine("pop of the storedvalues:" + StackObjects.Pop());
            Console.WriteLine("after the peek and pop  stored values:" + StackObjects.Count);

        }
        Console.ReadLine();

    }

}