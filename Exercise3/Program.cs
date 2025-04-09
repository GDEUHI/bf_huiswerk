// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// ------------------------------
// Title: Exercise 3 - Swap Without Temporary Variable
// Owner: gd
// Created On: 2025-04-08
// Last Modified: 2025-04-08
// Purpose: Swap values of two integers without using a third variable
// Usage Instructions: Run, enter two integers, and see them swapped
// Access Dates: ___________________
// ------------------------------

#region Swap without a temporary variable

Console.WriteLine("\nExercise 3 – Swap Without Temporary\n");

// Goal: Swap two numbers without using a third temporary variable
// We'll use addition and subtraction

// Ingredients
int a;
int b;

// Ask for inputs
Console.Write("Enter the first number: ");
a = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
b = int.Parse(Console.ReadLine());

// Display before swap
Console.WriteLine($"\nBefore swap: a = {a}, b = {b}");

// Swap without a temp variable
a = a + b;
b = a - b;
a = a - b;

// Output
Console.WriteLine($"\nAfter swap: a = {a}, b = {b}");

#endregion