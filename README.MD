<center>

# Итоговая проверочная работа первого блока

</center>

## <u>*1. Задача*</u>

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

[“hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → [] */

:point_right: [Перейти к решению](https://github.com/ANT050/Final_verification_work_23.11.2022/blob/main/Final_work/Program.cs "Открыть")

---

## <u>*2. Блок-Схема*</u>

<img src="Block diagram(Final verification work).jpg" height=200 width="200"/>

:point_right: [Открыть блок-схему](https://github.com/ANT050/Final_verification_work_23.11.2022/blob/main/Block%20diagram(Final%20verification%20work).jpg "Открыть")

---

## <u>*3. Описание решения*</u>

Изначально в консоли выводятся массивы, которые даны в условии задачи:

```

Console.WriteLine("\nМАССИВЫ:\n");
Console.WriteLine("1 массив: [“hello”, “2”, “world”, “:-)”]");
Console.WriteLine("2 массив: [“1234”, “1567”, “-2”, “computer science”]");
Console.WriteLine("3 массив: [“Russia”, “Denmark”, “Kazan”]");

```

- ### Функция ввода номера массива.

Функция указывает порядковый номер массива, который будет рассматриваться.

```
string ArrayNumbers(string message)
{
	Console.Write(message);
	return Console.ReadLine();
}
```

- ### Функция выбор массива

value - номер массива, получаем с помощью функции ввода номера массива.

Конструкция switch/case заменяет собой сразу несколько if. Оценивает некоторое выражение и сравнивает его значение с набором значений. Конструкция switch имеет три блок case и блок default.

После ключевого слова switch в скобках идет сравниваемое выражение arrayNumber. arrayNumber присваивается значение, которое вводится в функции ввода номера массива.

Значение arrayNumber последовательно сравнивается со значениями, помещенными после оператора сase. И если совпадение будет найдено, то будет выполняться определенный блок сase.

В конце каждого блока сase ставится оператор перехода break, при его применении другие блоки case выполняться не будут.

Если значение переменной arrayNumber не совпадает ни с каким значением после операторов case, то ни один из блоков case не выполняется. После этого выполняется блок default, в котором используется оператора throw, после которого указывается объект исключения, через конструктор которого передается сообщение об ошибке  в блок catch.

```
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
```

---