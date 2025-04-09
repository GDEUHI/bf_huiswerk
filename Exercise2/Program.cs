// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// ------------------------------
// Title: Exercise 2 - Calculate Total Price with VAT
// Owner: gd
// Created On: 2025-04-08
// Last Modified: 2025-04-08
// Purpose: Ask user for unit price and quantity of fries, calculate total + VAT
// Usage Instructions: Run, enter price in cents and quantity, get total + VAT.
// Access Dates: ___________________
// ------------------------------

#region Calculate total fries price

Console.WriteLine("\nExercise 2 – Total Price with VAT\n");

// Goal: Ask for the price of fries and quantity, then calculate total with VAT
// The user will enter a price in cents (e.g., 250 for €2.50) and a quantity
// We will calculate:
// 1. Total = price × quantity
// 2. VAT = 25% → totalWithVAT = total × 125 / 100

// Ingredients – What we need
int pricePerFries;
int quantity;
int totalPrice;
int totalWithVAT;

// Ask user for inputs
Console.Write("Enter the price of one small fries (in cents): ");
pricePerFries = int.Parse(Console.ReadLine());

Console.Write("Enter the number of small fries you want: ");
quantity = int.Parse(Console.ReadLine());

// Calculations
totalPrice = pricePerFries * quantity;
totalWithVAT = totalPrice * 125 / 100;

// Output
Console.WriteLine($"\nTotal price without VAT: {totalPrice} cents");
Console.WriteLine($"Total price with 25% VAT: {totalWithVAT} cents");

#endregion