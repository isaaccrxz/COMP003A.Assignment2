/*
 * Author: Isaac Cruz
 * Course: COMP003A
 * Purpose: Math problems, programming basics
 */

// String Section */

Console.Title = "COMP-003A - Assignment 2";
Console.BackgroundColor =
ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Hello, What is your first name?");
string firstName = Console.ReadLine();

Console.WriteLine("What is your middle name?");
string middleName = Console.ReadLine();

Console.WriteLine("What is your last name?");
string lastName = Console.ReadLine();

Console.WriteLine("Age in 2023?");
string inputAge = Console.ReadLine();
int yearBorn = 2023 - Convert.ToInt32(inputAge);

Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

// Math Section */

Console.WriteLine("Enter an integer: ");
string integer1 = Console.ReadLine();
Console.WriteLine("Enter an integer: ");
string integer2 = Console.ReadLine();


Console.WriteLine($"{integer1} + {integer2} = {integer1} + {integer2}");
Console.WriteLine($"{integer1} - {integer2} = {integer1} - {integer2}");
Console.WriteLine($"{integer1} * {integer2} = {integer1} * {integer2}");
Console.WriteLine($"{integer1} / {integer2} = {integer1} / {integer2}");
Console.WriteLine($"{integer1} % {integer2} = {integer1} % {integer2}");

double radius = Convert.ToDouble(Console.ReadLine());
double area = Math.PI * Math.Pow(radius, 2);
double circumference = 2 * Math.PI * radius;
