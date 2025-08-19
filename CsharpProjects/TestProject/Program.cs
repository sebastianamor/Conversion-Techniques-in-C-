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

//string[] values = { "12.3", "45", "ABC", "11", "DEF" };

//decimal total = 0m;
//string message = "";

//foreach (var value in values)
//{
  //  decimal number; // stores the TryParse "out" value
  //  if (decimal.TryParse(value, out number))
  //  {
  //      total += number;
  //  } else
  //  {
  //      message += value;
   // }
//}

//Console.WriteLine($"Message: {message}");
//Console.WriteLine($"Total: {total}");

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// 1. Dividir value1 por value2 y redondear al entero más cercano
int result1 = (int)Math.Round(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// 2. Dividir value2 por value3 y mostrar como decimal
decimal result2 = value2 + (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// 3. Dividir value3 por value1 y mostrar como float
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
