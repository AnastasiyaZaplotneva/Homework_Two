//Дано число, обозначающее день недели. Выяснить, является ли номер дня недели выходным.

Console.Clear();
Console.WriteLine("Введите номер дня недели (от 1 до 7): " ?? "0");
int number = int.Parse(Console.ReadLine());

if(number < 1 || number > 8)
    Console.WriteLine("Вы ввели неверное число");
else
    if(number > 0 && number < 6)
        Console.WriteLine("Это будний день");
    else
        Console.WriteLine("Это выходной");
