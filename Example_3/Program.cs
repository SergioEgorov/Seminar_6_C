// // Задача 40: Напишите программу, 
// которая принимает на вход три числа 
// и проверяет, может ли существовать 
// треугольник с сторонами такой длины.

Console.WriteLine("Введите длину отрезка ");
Console.Write("Введите первую сторону: ");
int FirstLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую сторону: ");
int SecondtLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью сторону: ");
int ThirdLine = Convert.ToInt32(Console.ReadLine());

if (FirstLine < SecondtLine + ThirdLine &
    SecondtLine < FirstLine + ThirdLine &
    ThirdLine < FirstLine + SecondtLine) Console.WriteLine("Треугольник возможен");
else Console.WriteLine("Треугольник не возможен");

 
