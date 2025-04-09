using System;

class Program
{
    static void Main()
    {
        // ------------------------------
// Title: Exercise 1 - Swapping Two Integers
// Owner: gd
// Created On: 2025-04-08
// Last Modified: 2025-04-08
// Purpose: Beginner program to swap two values entered by the user
// Usage Instructions: Run, enter two integers, and see them swapped.
// Access Dates: ___________________
// ------------------------------

#region Our very first algorithm

Console.WriteLine("\nFirst Algorithm:\n");

// Create an algorithm that swaps the values of two variables
// The user enters two numbers. The program switches them.

// Step-by-step:
// Ingredients – What we need
int number1;
int number2;
int temporary;

// Instructions
Console.Write("Enter the first number: ");
number1 = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
number2 = int.Parse(Console.ReadLine());

// Display before swap
Console.WriteLine($"\nBefore swap: number1 = {number1}, number2 = {number2}");

// Swap using a temporary variable
temporary = number1;
number1 = number2;
number2 = temporary;

// Display after swap
Console.WriteLine($"\nAfter swap: number1 = {number1}, number2 = {number2}");

#endregion1

    }
}