int days = new Random().Next(1, 8);
Console.Write(days);
if (days >= 6) {
    Console.Write(" - Да");
}
else {
    Console.Write(" - Нет");
}