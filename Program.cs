/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] 
*/

string[] array = new string[5] { "Russia", "YES", "May", "1254", "Kazan" }; // требование к размеру массива отсутствует, ограничилась 5 элементами
string[] SortedArray = new string[array.Length]; //  задан новый массив для сортировки элементов.

void ArraySorting(string[] array, string[] SortedArray) // метод сортировки массива
{
    int count = 0; // счетчик элементов массива
    for (int i = 0; i < array.Length; i++) // поиск элементов длиной =<3 символов
    {
        if (array[i].Length <= 3)
        {
            SortedArray[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array) // вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
ArraySorting(array, SortedArray);
PrintArray(SortedArray);