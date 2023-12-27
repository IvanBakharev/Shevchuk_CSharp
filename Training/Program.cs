using System.ComponentModel.DataAnnotations;

#region
/*
Здесь я учусь и постигаю лучший язык - С#

Replace подмени 

var SimpleString = "Привет"
var replaceString = SimpleString.Replace("вет", "страстие");


*/
#endregion

//Здесь будет массив строк, значения которого вводятся через пробел заполняем с клавиатуры

/*
Console.WriteLine("Введите значения разделенные пробелами:");
Console.WriteLine();    

string input = Console.ReadLine();
string[] values = input.Split(' ');
string[] myArray = new string[values.Length];

Console.WriteLine();
Console.WriteLine("Элементы массива:");
Console.WriteLine();

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = (values[i]);
}

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}
*/

// Заполнение массива с клавиатуры

#region
/*
Console.WriteLine("Введите колличество элементов массива:");
Console.WriteLine();

int size = int.Parse(Console.ReadLine());
Console.WriteLine();

int[] myArray = new int[size];

for (int i = 0; i < size; i++)
{
    Console.WriteLine("Введите элемент массива {0}:", i +1);
    myArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Элементы массива:");
Console.WriteLine();

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}
*/
#endregion

// ПИРАМИДКИ

#region
/*
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(" ");

    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    
}
*/


for (int i = 0; i < 11; i++)
{
    for (int j = 11; j > i; j--)
    {
        Console.Write(" ");
    }

    for (int k = 0; k < i; k++)
    {
          Console.Write("*");
    }
    Console.WriteLine();
}

#endregion

// ТЕРНАРНЫЙ ОПЕРАТОР

#region
/*
string armore = "BlueWolf";

int defense = 2500;

string resist = "stun";

Console.WriteLine($"Броня {armore} имеет защиту {defense} и резист к {resist}");
*/
#endregion


