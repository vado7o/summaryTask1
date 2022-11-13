// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int size = 7;
string[] array = new string[size];
int index = 0;
string input = "";

Console.Write("\nВведите 7 (семь) элементов массива");

while (index < size)
{
    Console.Write("\nВведите следующий элемент массива: ");
    input = Console.ReadLine();
    if (input == "") 
    {
        Console.Write("\nНе допускается вводить пустые элементы!!!");
        continue;        
    }
    else array[index] = input;
    index++;
}

Console.WriteLine("\nРезультат : ");
Console.Write("[{0}]", string.Join(", ", array));

array = array.Where(val => val.Length < 4).ToArray();

Console.Write(" -> ");
Console.Write("[{0}]", string.Join(", ", array));