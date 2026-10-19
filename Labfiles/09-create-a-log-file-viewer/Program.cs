using System;

// Log a new event
using StreamWriter logFile = new StreamWriter("log.txt", append: true);
logFile.WriteLine($"[{DateTime.Now}] Application started.");

// Read back every logged event
int loggedEventCount = 0;
using StreamReader logFileReader = new StreamReader("log.txt");
string stringline; 

while ((stringline = logFileReader.ReadLine()) != null)
{
  Console.WriteLine(stringline);
  loggedEventCount++;
}

// Count the logged events
Console.WriteLine($"Total logged events: {loggedEventCount}");