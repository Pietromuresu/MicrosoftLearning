// Bring in the Billing namespace
using Billing;

// Set up the order
decimal subtotal = 100.00m;
decimal taxRate = 0.08m; // 8% tax rate

// Calculate tax and total
decimal tax = Calculator.CalculateTax(subtotal, taxRate);
decimal total = Calculator.CalculateTotal(subtotal, tax);

// Print the receipt
Console.WriteLine("Subtotal: {0:C}", subtotal);
Console.WriteLine("Tax: {0:C}", tax);
Console.WriteLine("Total: {0:C}", total);
