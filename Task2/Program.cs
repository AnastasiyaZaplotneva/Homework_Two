// По двум заданным числам проверять, является ли одно квадратом другого.

Console.Clear();
Console.WriteLine("Введите первое число: " ?? "0");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: " ?? "0");
int numB = int.Parse(Console.ReadLine());
if(numA*numA == numB)
    Console.WriteLine($"Число {numB} является квадратом числа {numA}");
else
    if(numB*numB == numA)
        Console.WriteLine($"Число {numA} является квадратом числа {numB}");
    else
        Console.WriteLine("Ни одно из введенных чисел не является квадратом другого");

// Интереса ради проверила еще один вариант, принцип тот же, но с использованием логического оператора. В общем, оба варианта рабочие.
//
// if(numA*numA == numB || numB*numB == numA)
//     if(numA > numB)
//         Console.WriteLine($"Число {numA} является квадратом числа {numB}");
//     else
//         Console.WriteLine($"Число {numB} является квадратом числа {numA}"); 
// else
//     Console.WriteLine("Ни одно из введенных чисел не является квадратом другого");
