static void distance(float x1, float y1,
                     float z1, float x2,
                     float y2, float z2)
{
    double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
    Console.WriteLine("Дистанция равна \n" + d);
    return;
}
{
    Console.Write("Введите число AX: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число AY: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число AZ: ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число BX: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число BY: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число BZ: ");
    int z2 = Convert.ToInt32(Console.ReadLine());
     
    // function call
    // for distance
    distance(x1, y1, z1,
             x2, y2, z2);
}