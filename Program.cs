int number = new Random().Next(10, 1000);
Console.WriteLine(number);
int number1 = number % 10 / 1;
if (number > 100) {
    Console.WriteLine(number1);
}
else {
    Console.WriteLine("Нет третьей цифры");
}