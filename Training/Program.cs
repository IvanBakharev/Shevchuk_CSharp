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
    Console.WriteLine("Введите элемент массива {0}:", i + 1);
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

/*
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
*/
#endregion



#region
/*
string armore = "BlueWolf";

int defense = 2500;

string resist = "stun";

Console.WriteLine($"Броня {armore} имеет защиту {defense} и резист к {resist}");
*/
#endregion

// ТЕРНАРНЫЙ ОПЕРАТОР

/*
 
int oneNumber = 12;

int twoNumber = 13;

int max;

max = (oneNumber > twoNumber) ? oneNumber : twoNumber;


int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

string quadrant = x == 0 ? y == 0 ? "В центре плоскости ординат" : "На оси X" : y == 0 ? "На оси Y" :
x > 0 ? y > 0 ? "I квадрант" : "IV квадрант" : y > 0 ? "II квадрант" : "III квадрант";

*/

// ЗУБЧАТЫЙ МАССИВ


/*

byte[] array0 = new byte[] { 1, 2, 3 };
byte[] array1 = new byte[] { 1, 2, 3, 4, 5};
byte[] array2 = new byte[] { 1, 2 };

byte[][] array = new byte[3][] { array0, array1, array2 };

for (int i = 0; i < array.Length; i++) // проходит по массивам
{
    for (int j = 0; j < array[i].Length; j++) // проходит по элементам массива
    {
        array[i][j] *= 2;
        Console.Write($"{array[i][j]}");
    }
    Console.WriteLine();
}
*/

// Вариант второй создания зубчатого массива

/*
byte[][] array = new byte[3][]
{
    new byte[] { 1, 2, 3 },
    new byte[] { 1, 2, 3, 4, 5 },
    new byte[] { 1, 2, }
};


for (int i = 0; i < array.Length; i++) // проходит по массивам
{
    for (int j = 0; j < array[i].Length; j++) // проходит по элементам массива
    {
        array[i][j] *= 2;
        Console.Write($"{array[i][j]}");
    }
    Console.WriteLine();
}
*/

// Третий вариант создания зубчатого массива

/*
byte[][] array3 =
{
    new byte[] { 1, 2, 3 },
    new byte[] { 1, 2, 3, 4, 5 },
    new byte[] { 1, 2, }
};


for (int i = 0; i < array3.Length; i++) // проходит по массивам
{
    for (int j = 0; j < array[i].Length; j++) // проходит по элементам массива
    {
        array[i][j] *= 2;
        Console.Write($"{array[i][j]}");
    }
    Console.WriteLine();
}
*/


//ЗУБЧАТЫЙ МАССИВ С ДВУМЕРНЫМИ МАССИВАМИ

/*
using System.Security.Cryptography;
using System.Xml.Serialization;

byte[,] array0 = { { 1, 2, 3 },
                   { 4, 5, 6 } };

byte[,] array1 = { { 1, 2, 3, 4, 5 },
                   { 6, 7, 8, 9, 0 } };

byte[,] array2 = { { 1,2},
                   { 3, 4 } };

byte[][,] array = new byte[3][,] {array0, array1, array2};

for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array[i].GetLength(0); j++)
    {
        for (int k = 0; k < array[i].GetLength(1); k++)
        {
            Console.Write($"{array[i][j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
*/

// МЕТОДЫ

// Процедуры - не возращают значений, Функции - возращают значения.

// Сигнатуоа метода - индификатор (имя метода)

/*
namespace Methods
{
    class Program
    {
        static byte Increment(byte argument)
        {
            argument += 1;
            return argument;
        }
        static void Main(string[] args)
        {
            byte variable = 1;
            byte result = Increment(variable);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
*/

    bool userAutorized = false;
{
    string[] loginList = { "Admin", "Ivanova", "Petrova", "Sergeeva", "Semenova", "Vasileva" };
    string[] passwordList = { "000", "111", "222", "333", "444", "555", "666" };

    int autorizedAtemptCouner = 0;
    const int ALLOWABLE_NUMBER_OF_AUTORIZATION_ATEMPT = 3;
    bool autorizationAtemptAvalible = autorizedAtemptCouner < ALLOWABLE_NUMBER_OF_AUTORIZATION_ATEMPT;

    while(autorizationAtemptAvalible)
    {
        string login, password;
        {
            Console.Write("Enter you login:\n");
            login = Console.ReadLine();

            Console.Write("Enter you password:\n");
            password = Console.ReadLine();

        }

        {
            int index = 0;

            while(index < loginList.Length && index < passwordList.Length)
            {
                bool loginMatched, passwordMatched;
                {
                    string loginByCurrentIndex = loginList[index];
                    loginMatched = loginByCurrentIndex == login;
                    string passwordByCurrentIndex = passwordList[index];
                    passwordMatched = passwordByCurrentIndex == password;
                }

                if(loginMatched && passwordMatched)
                {
                    userAutorized = true;
                    break;
                }
                else
                {
                    index++;
                }
            } 
        }

        if (userAutorized)
        {
            Console.WriteLine("Вы успешно авторизованы");
            break;
        }
        else
        {
            Console.WriteLine("Логин или пароль введены не верно");
            autorizationAtemptAvalible = ++autorizedAtemptCouner < ALLOWABLE_NUMBER_OF_AUTORIZATION_ATEMPT;

            if (autorizationAtemptAvalible)
            {
                continue;
            }
            else
            {
                Console.WriteLine("Вы исчерпали количество попыток авторизации. Обратитесь к администратору.");
                break;
            }
        }
    }
   
}

Console.ReadKey();
