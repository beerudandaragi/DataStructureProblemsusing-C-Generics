using System;
using System.Collections.Generic;

public class QueueExample
{
    public static void Main(string[] args)
    {
        Queue<int> names = new Queue<int>();
        names.Enqueue(56);
        names.Enqueue(30);
        names.Enqueue(70);
        
        foreach (int name in names)
        {
            Console.WriteLine(name);
        }
        Console.ReadKey();
    }      }  