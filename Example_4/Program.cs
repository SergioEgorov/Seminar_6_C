// // Задача 41: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int countFibonacci = 3;
if(countFibonacci < 3)
{
    return;
}
int FirstElement = 0;
int SecondtElement = 1;

Console.WriteLine(FirstElement);
Console.WriteLine(SecondtElement);

for (int i = 3; i <= countFibonacci; i++)
{
    int NextElement = FirstElement + SecondtElement;
    Console.WriteLine(NextElement);
    FirstElement = SecondtElement;
    SecondtElement = NextElement;
}

// Console.Write("Введите разряд числа Фибоначчи: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[size];
// array[0] = 0;
// array[1] = 1;

// for (int i = 2; i < size; i++)
// {

// }
