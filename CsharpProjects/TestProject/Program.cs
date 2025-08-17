//string value = "102";
//int result = 0;
//if (int.TryParse(value, out result))
//{
 //  Console.WriteLine($"Measurement: {result}");
//}
//else
//{
  // Console.WriteLine("Unable to report the measurement.");
//}
//Console.WriteLine($"Measurement (w/ offset): {50 + result}");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");