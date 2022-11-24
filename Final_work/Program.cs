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

//Выбор массива
string[] ArraySelection(string value)
{
	string[] myArray = new string[] { };
	string arrayNumber = value;
	switch (arrayNumber)
	{
		case "1":
			myArray = new string[] { "hello", "2", "world", ":-)" };
			break;
		case "2":
			myArray = new string[] { "1234", "1567", "-2", "computer science" };
			break;
		case "3":
			myArray = new string[] { "Russia", "Denmark", "Kazan" };
			break;
		default:
			throw new Exception($"\nМассив отсутствует!!!");
	}
	return myArray;
}

//Вывод выбранного массива в консоли
void PrintArray(string[] myArray)
{
	Console.Write("[");
	for (int i = 0; i < myArray.Length; i++)
	{
		Console.Write($"“{myArray[i]}”");
		if (i != myArray.Length - 1)
			Console.Write(", ");
	}
	Console.Write("]");
}

//Определение размера итогового массива, где элементы массива меньше, либо равны 3 символам
int ArraySize(string[] myArray)
{
	int size = 0;
	for (int i = 0; i < myArray.Length; i++)
	{
		if (myArray[i].Length <= 3) size++;
	}
	return size;
}

Console.WriteLine("\nМАССИВЫ:\n");
Console.WriteLine("1 массив: [“hello”, “2”, “world”, “:-)”]");
Console.WriteLine("2 массив: [“1234”, “1567”, “-2”, “computer science”]");
Console.WriteLine("3 массив: [“Russia”, “Denmark”, “Kazan”]");

try
{
	string value = ArrayNumbers("\nУкажите номер массива: ");
	string[] myArray = ArraySelection(value);
	int sizeArray = ArraySize(myArray);
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}