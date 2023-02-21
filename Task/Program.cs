// Задача :
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

// Примеры: 
// ["Hello", "2", "world", ":-)"] → [“2”, “:-)”] 
// ["1234", "1567", "-2", "computer science"] → [“-2”] 
// ["Russia", "Denmark", "Kazan"] → []

string[] arrString = new string[] {"Russia", "Denmark", "Kazan"};  // "Hello", "2", "world", ":-)"
                                                                   // "1234", "1567", "-2", "computer science"
                                                                   // "Russia", "Denmark", "Kazan"

for (int i = 0; i < arrString.Length; i++)
{
    Console.WriteLine("{1} ", i, arrString[i]);
}

string[] array2 = new string[arrString.Length];

void SecondArray(string[] arrString, string[] array2)
{
    int count = 0;
    for (int i = 0; i < arrString.Length; i++)
    {
    if(arrString[i].Length <= 3)
        {
        array2[count] = arrString[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SecondArray(arrString, array2);
Console.WriteLine();
PrintArray(array2);