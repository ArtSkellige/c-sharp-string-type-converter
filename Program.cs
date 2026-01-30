/*
String Array Type Converter Challenge
Iterates through a string array containing mixed numeric and alphabetic values.
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
