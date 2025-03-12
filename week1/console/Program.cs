// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

int year = DateTime.Now.Year;
var christmasDate = new DateTime(year, 12, 25);
var today = DateTime.Now;
double daysUntilChristmas = christmasDate.Subtract(DateTime.Today).TotalDays;

Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is "+today);
Console.WriteLine($"There are {daysUntilChristmas} days until next Christmas");