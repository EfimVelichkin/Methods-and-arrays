int number = new Random().Next(100, 1000);
Console.WriteLine(number);
string new_number = "";
new_number += number % 100 / 10;
Console.WriteLine(new_number);
