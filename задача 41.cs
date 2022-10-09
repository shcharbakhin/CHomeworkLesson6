{
    Console.WriteLine("Введите количество чисел:");
    int razmer = Convert.ToInt32(Console.ReadLine());
    int[] massiv = new int[razmer];
    Console.WriteLine("Введите числа:");
    int i;
    int j = 0;
    for (i = 0; i < razmer; i++)
    {
        massiv[i] = Convert.ToInt32(Console.ReadLine());
        if (massiv[i] > 0)
        {
            j = j + 1;
        }
        else
        {
        }
    }
    Console.WriteLine("Количество чисел больше ноля:");
    Console.Write(j);
}