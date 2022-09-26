double a, b;
double c = 0;
Console.WriteLine("Выберите номер операции: ");
Console.WriteLine("\r\n1.Сложить 2 числа\r\n2.Вычесть первое из второго\r\n3.Перемножить два числа\r\n4.Разделить первое на второе\r\n5.Возвести в степень N первое число\r\n6.Найти квадратный корень из числа\r\n7.Найти 1 процент от числа\r\n8.Найти факториал из числа\r\n9.Выйти из программы\r\n");
do
{
    Console.WriteLine("Введите номер операции: ");
    int action = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите первое число: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    b = Convert.ToInt32(Console.ReadLine());
    switch (action)
    {
        case 1:
            c = a + b;
            break;
        case 2:
            c = a - b;
            break;
        case 3:
            c = a * b;
            break;
        case 4:
            c = a / b;
            break;
        default:
            break;
    }
    Console.WriteLine("Результат: " + c);
    Console.WriteLine();
}
while (true);