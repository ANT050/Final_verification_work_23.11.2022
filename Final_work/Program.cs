/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
[“hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

// Функция ввода номера массива
string ArrayNumbers(string message)
{
	Console.Write(message);
	return Console.ReadLine();
}

Console.WriteLine("\nМАССИВЫ:\n");
Console.WriteLine("1 массив: [“hello”, “2”, “world”, “:-)”]");
Console.WriteLine("2 массив: [“1234”, “1567”, “-2”, “computer science”]");
Console.WriteLine("3 массив: [“Russia”, “Denmark”, “Kazan”]");

string value = ArrayNumbers("\nУкажите номер массива: ");