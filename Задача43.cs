//напишите программу пересечения двух прямых, заданных уравнениями y=k1*x+b1; y = k2*x+b2
{
    Console.WriteLine("Имеются 2 прямых линии заданных уравнениями:");
    Console.WriteLine("y=k1*x+b1; y = k2*x+b2");
    Console.WriteLine("значения b1,k1,b2,k2 вводятся пользователем.");
    Console.WriteLine("Введите значения b1:");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значения k1:");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значения b2:");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значения k2:");
    int k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Учитывая что в точке пересечения линий координаты X и Y равны для двух прямых");
    //k1*x+b1=k2*x+b2; k1*x-k2*x=b2-b1; x= (b2-b1)/(k1-k2);
    int xp = (b2 - b1) / (k1 - k2);
    int yp = k1 * xp + b1;
    Console.WriteLine("точка пересечения прямых находится по следующим координатам:");
    Console.WriteLine($"x = {xp}, y = {yp}");
}

