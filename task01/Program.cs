void task01()
{
    Console.Write(" Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    //int sqr = number * number;
    Console.Write($" Квадрат числа: {number}  Равен:  {number * number}");
}
//task01();

void task02()
{
    Console.Write("Введите первое число: ");
    int numFirst = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int numSecond = Convert.ToInt32(Console.ReadLine());
    if (numFirst == numSecond * numSecond)
    {
        Console.Write($"Число {numFirst} является квадратом {numSecond}");
    }
    else
        Console.Write($"Число {numFirst} не является квадратом {numSecond}");
}
//task02();

void task2()
{
    int a = -9;
    int b = -3;
    int max = 0;
    if (a < b) max = b;
    Console.Write($"Максимальное число: {max}");

}
task2();

