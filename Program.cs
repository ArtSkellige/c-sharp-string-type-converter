/*
String Array Type Converter Challenge
Iterates through a string array containing mixed numeric and alphabetic values.
Concatenates alphabetic strings into a message and sums numeric values into a total.
Demonstrates type checking with char.IsLetter() and type conversion with decimal.TryParse().
 */

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = "";
decimal total = 0;
decimal numericValue = 0;

foreach (string value in values)
{
    if (char.IsLetter(value[0]))
    {
        message += value;
    }

    if (decimal.TryParse(value, out numericValue))
    {
        total += numericValue;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total  : {total}");