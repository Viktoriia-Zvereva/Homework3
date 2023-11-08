void Task19()
{
    // Напишите программу, которая принимает на вход пятизначное число 
    // и проверяет, является ли оно палидромом
    Console.WriteLine("Задача 19");
    
    Console.WriteLine("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int tens_of_thousands = number / 10000;
    int thousands = number / 1000 % 10;
    int tens = number / 10 % 10;
    int ones = number % 10;
    if (tens_of_thousands == ones && thousands == tens)
    {
        Console.WriteLine($"Данное число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Данное число {number} не является палиндромом");
    } 
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task21()
{
    // Напишите программу, которая принимает на вход координаты двух точек и
    // находит расстояние между ними в 3D пространстве.
    Console.WriteLine("Задача 21");

    int x1 = Input("Введите A_x: ");
    int y1 = Input("Введите A_y: ");
    int z1 = Input("Введите A_z: ");
    int x2 = Input("Введите B_x: ");
    int y2 = Input("Введите B_y: ");
    int z2 = Input("Введите B_z: ");

    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + 
                              Math.Pow(y2 - y1, 2) + 
                              Math.Pow(z2 - z1, 2)); 
    result = Math.Round(result, 2);
    Console.WriteLine($"Расстояние равно {result}");
}

void Task23()
{
    // Напишите программу, которая принимает на вход число (N) и выдает таблицу
    // кубов чисел от 1 до N
    Console.WriteLine("Задача 23");

    int number = Input("Введите число: ");

    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
    }
}

Console.Clear();
Console.WriteLine("19 - Задача 19\n21 - Задача 21\n23 - Задача 23");
int TaskNumber = Input("Введите номер задачи: ");

switch(TaskNumber)
{
    case 19:
        Task19();
        break;
    case 21:
        Task21();
        break;
    case 23:
        Task23();
        break;
    default:
        Console.WriteLine("Введен неверный номер задачи");
        break;
}