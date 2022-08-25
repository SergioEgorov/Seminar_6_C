// Задача 39. Перевернуть одномерный массив.

int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(11);
}

Console.WriteLine($"Array: [{String.Join(",", array)}]");

int lastIndex = size - 1;
int[] resultArray = new int[size];
for (int i = 0; i < size; i++)
{
    resultArray[i] = array[lastIndex - i];
}

Console.WriteLine($"Reverse array: [{String.Join(",", resultArray)}]");
