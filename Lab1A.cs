﻿using System;

// Program Lab1A.cs
// Demonstrate the difference between Write and WriteLine methods.
public class Lab1A
{
// Prints two lines of output representing a rocket countdown.
    public static void Main (string[] args)
    {
        Console.Write("Three... ");
        Console.Write("Two... ");
        Console.Write("One... "); 
        Console.Write("Zero... ");
        Console.WriteLine("Liftoff!"); // appears on first line
        Console.WriteLine("Houston, we have a problem.");
    }
}
