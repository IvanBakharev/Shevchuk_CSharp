
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.CompilerServices;

//   Конспектирую Шевчука. 
#region Conspect

// Сдесь буду конспектировать отдельные моменты по урокам.

/*
 Арифмитические действия:

 1) певое слогаемое + второе слогаемое = сумма

  augent + addend = sum

 2) уменьшаемое - вычетаемое = разность

  minuend - subtrahend = difference

 3) множимое х множитель = произведение

    multiplicand x multiplier = product

 4) делимое / делитель = частное (остаток)

    dividend / divisor = quotient (remainder)

У типов: byte, sbyte, short, ushort не имеют своих арифметических операторов!

float T_avg = (3f + (-2f) + (-5f) + 3f +1f + 4f + (-3f)) / 7f   // Так получаем точное число с остатком.

НАХОЖДЕНИЕ СТЕПЕНИ: C = Math.Pow(6, 2);

НАХОЖДЕНИЕ ОСНОВАНИЯ СТЕПЕНИ: a = Math.Sqrt(36);

НАХОЖДЕНИЕ ПОКАЗАТЕЛЯ СТЕПЕНИ: b = Math.Log(36, 6);

 */

// ЛОГИЧЕСКИЕ ОПЕРАТОРЫ

/*
& - конюнкция, && - кроткосрочная конюнкция. И
| - дизъюнкция, || - кроткосрочная дизъюнкция. ИЛИ
^ - исключающая или. (циркумфлекс - крышка)

    true ^ true = false

    true ^ false = true

    false ^ true = true

    false ^ false = false
*/

/*
int x = 2, y = 3;

bool isEqual = x == y;
Console.WriteLine($"{x} == {y} = {isEqual}");

bool isNotEqual = x != y;
Console.WriteLine($"{x} ! = {y} = {isNotEqual}");

bool isLess = x < y;
Console.WriteLine($"{x} < {y} = {isLess}");

bool isGreater = x > y;
Console.WriteLine($"{x} > {y} = {isGreater}");

double w = double.NaN, z = double.NaN;

bool intern = w == z;
Console.WriteLine($"{w} == {z} = {intern}");
*/

/*

int salary = 500, minimumWage = 1000;

bool salaryNotLessMinimumWage = !(salary < minimumWage);        // Лучше не использовать

Console.WriteLine($"Зарплата {salary} не меньше минимальной {salaryNotLessMinimumWage}");

bool salaryLessMinimumWage = (salary > minimumWage);  

Console.WriteLine($"Зарплата {salary} не меньше минимальной {salaryLessMinimumWage}");

bool salaryGreaterMinimumWage = (salary < minimumWage);

Console.WriteLine($"Зарплата {salary} не больше минимальной {salaryGreaterMinimumWage}");
*/

/*
Console.WriteLine("Возраст клиента:");
int clienAge = int.Parse(Console.ReadLine());

Console.WriteLine("Зарплата клиента:");
int clientSalary = int.Parse(Console.ReadLine());

Console.WriteLine("Наличие поручителя:");
bool hasGuarantor = Console.ReadLine().Contains("да");

Console.WriteLine("Наличие закладного имущества:");
bool hasCollateral = Console.ReadLine().Contains("да");

int minSalary = 1500, minAge = 18, maxAge = 55;

bool bankLoadAllowed = clienAge >= minAge & clienAge <= maxAge & clientSalary >= minSalary | hasGuarantor | hasCollateral;

Console.WriteLine($"Кредитование доступно: {bankLoadAllowed}");
*/

/*
Console.WriteLine("Фамилия запросившего субсидию:");
string name = Console.ReadLine();

Console.WriteLine($"{name} является пенсионером? :");
bool isPensioner = Console.ReadLine().Contains("да");

Console.WriteLine($"{name}Состоит ли на бирже труда? :");
bool isUnemployed = Console.ReadLine().Contains("да");

Console.WriteLine($"{name} имеет ли доход? :");
bool isEmployment = Console.ReadLine().Contains("да");

//bool subsidyAllowed = !isEmployment && (isPensioner ^ (!isPensioner & isUnemployed));
//bool subsidyAllowed = (isPensioner | isUnemployed) & !isEmployment;
bool subsidyAllowed = !isEmployment && (isPensioner || isUnemployed);

Console.WriteLine($"{name} имеет право на субсидию: {subsidyAllowed}");
*/

/*
Console.WriteLine("Введите свой стаж работы что бы получить премию!");
int lengthOfService = Convert.ToInt32(Console.ReadLine());

int x = 0;
bool result = lengthOfService < 5 && (x += 10) == 10 ||
lengthOfService >= 5 && lengthOfService < 10 && (x += 15) == 15 ||
lengthOfService >= 10 && lengthOfService < 15 && (x += 25) == 25 ||
lengthOfService >= 15 && lengthOfService < 20 && (x += 35) == 35 ||
lengthOfService >= 20 && lengthOfService < 25 && (x += 45) == 45 ||
lengthOfService >= 25 && (x += 50) == 50;

Console.WriteLine($"выдать премию в размере {x}% от заработной платы : \nЗа выслугу лет: {lengthOfService} лет");
*/

//   Константы

/*
const int myConst = 256;
byte variable = unchecked((byte)myConst);
Console.WriteLine(variable);               // Преобразования константы из значения большего типа в меньшее.


int x = 5;
const int y = x;
const int z = --y;
Console.WriteLine(z);
Console.WriteLine(x+z);
*/


// МНОЖЕСТВЕННОЕ ВЕТВЛЕНИЕ

/*
string countryCode;

string COUNTRY_CODES =
    "Азербайджан (994) | Киргизия (996) | Таджикистан (992)\n" +
    "Армения     (374) | Латвия   (371) | Туркмения   (993)\n" +
    "Беларусь    (375) | Литва    (370) | Узбекистан  (998)\n" +
    "Грузия      (995) | Молдова  (373) | Украина     (380)\n" +
    "Казахстан   (007) | Россия   (007) | Эстония     (372)\n" +
    "------------------------------------------------------";

Console.WriteLine(COUNTRY_CODES);

Console.WriteLine("Телефонный код страны");

countryCode = Console.ReadLine();


Console.WriteLine("Количество плитки");
int quantityTiles = int.Parse(Console.ReadLine());

Console.WriteLine("Стоимость плитки");
decimal priceTiles = decimal.Parse(Console.ReadLine());

decimal rate;
{
    const string AZERBAIJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375", GEORGIA_CODE = "995", KAZAKHTAN_CODE = "007", KYRGYZSTAN_CODE = "996", LATVIA_CODE = "371", LITHUANIA_CODE = "370",
                 MOLDOVA_CODE = "373", RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992", TURKMENISTAN_CODE = "993", UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

    if (countryCode == AZERBAIJAN_CODE)
    {
        const decimal AZERBAIJAN_RATE = 1.07m;
        rate = AZERBAIJAN_RATE;
    }
    else if (countryCode == ARMENIA_CODE)
    {
        const decimal ARMENIA_RATE = .95m;
        rate = ARMENIA_RATE;
    }
    else if (countryCode == BELARUS_CODE)
    {
        const decimal BELARUS_RATE = 1m;
        rate = BELARUS_RATE;
    }
    else if (countryCode == GEORGIA_CODE)
    {
        const decimal GEORGIA_RATE = .94m;
        rate = GEORGIA_RATE;
    }
    else if (countryCode == KAZAKHTAN_CODE)
    {
        const decimal KAZAKHTAN_RATE = .79m;
        rate = KAZAKHTAN_RATE;
    }
    else if (countryCode == KYRGYZSTAN_CODE)
    {
        const decimal KYRGUZSTAN_RATE = .83m;
        rate = KYRGUZSTAN_RATE;
    }
    else if (countryCode == LATVIA_CODE)
    {
        const decimal LATVIA_RATE = 1.12m;
        rate = LATVIA_RATE;
    }
    else if (countryCode == LITHUANIA_CODE)
    {
        const decimal LITHUANIA_RATE = 1.12m;
        rate = LITHUANIA_RATE;
    }
    else if (countryCode == MOLDOVA_CODE)
    {
        const decimal MOLDOVA_RATE = .97m;
        rate = MOLDOVA_RATE;
    }
    else if (countryCode == RUSSIA_CODE)
    {
        const decimal RUSSIA_RATE = 1m;
        rate = RUSSIA_RATE;
    }
    else if (countryCode == TAJIKISTAN_CODE)
    {
        const decimal TAJIKISTAN_RATE = .76m;
        rate = TAJIKISTAN_RATE;
    }
    else if (countryCode == TURKMENISTAN_CODE)
    {
        const decimal TURKMENISTAN_RATE = .81m;
        rate = TURKMENISTAN_RATE;
    }
    else if (countryCode == UZBEKISTAN_CODE)
    {
        const decimal UZBEKISTAN_RATE = .98m;
        rate = UZBEKISTAN_RATE;
    }
    else if (countryCode == UKRAINE_CODE)
    {
        const decimal UKRAINE_RATE = 1m;
        rate = UKRAINE_RATE;
    }
    else if (countryCode == ESTONIA_CODE)
    {
        const decimal ESTONIA_RATE = 1.12m;
        rate = ESTONIA_RATE;
    }
    else
    {
       rate = 0;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Вы ввели не существующий код {countryCode}!");
       
    }
}

decimal tilePriceWithRate = priceTiles * rate;
decimal totalPriceTiles = quantityTiles * tilePriceWithRate;

decimal discount = 0;

decimal discountPersentage;

bool discount20PctAvailable, discount50PctAvailable;

const decimal MIN_TILES_QTY_FOR_DISCOUNT_20_PCT = 500,
              MIN_TILES_QTY_FOR_DISCOUNT_50_PCT = 1000;

discount20PctAvailable = quantityTiles >= MIN_TILES_QTY_FOR_DISCOUNT_20_PCT && quantityTiles < MIN_TILES_QTY_FOR_DISCOUNT_50_PCT;

discount50PctAvailable = quantityTiles >= MIN_TILES_QTY_FOR_DISCOUNT_50_PCT;

if (discount20PctAvailable)
{
    discountPersentage = 20;
}
else if (discount50PctAvailable)
{
    discountPersentage = 50;
}
else
{
    discountPersentage = 0;
}
   

discount = totalPriceTiles / 100 * discountPersentage;

decimal discountedPrice = totalPriceTiles - discount;

Console.WriteLine($"Цена плитки с учетом коэфициента {tilePriceWithRate}");
Console.WriteLine($"Общая стоимость плитки {totalPriceTiles}");
Console.WriteLine($"Сумма скидки {discount}");
Console.WriteLine($"Цена со скидкой {discountedPrice}");
*/

/*
string countryCode;

string COUNTRY_CODES =
    "Азербайджан (994) | Киргизия (996) | Таджикистан (992)\n" +
    "Армения     (374) | Латвия   (371) | Туркмения   (993)\n" +
    "Беларусь    (375) | Литва    (370) | Узбекистан  (998)\n" +
    "Грузия      (995) | Молдова  (373) | Украина     (380)\n" +
    "Казахстан   (007K) | Россия   (007) | Эстония     (372)\n" +
    "------------------------------------------------------";

Console.WriteLine(COUNTRY_CODES);

Console.WriteLine("Телефонный код страны");

countryCode = Console.ReadLine();


Console.WriteLine("Количество плитки");
int quantityTiles = int.Parse(Console.ReadLine());

Console.WriteLine("Стоимость плитки");
decimal priceTiles = decimal.Parse(Console.ReadLine());

decimal rate;
{
    const string AZERBAIJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375", GEORGIA_CODE = "995", KAZAKHTAN_CODE = "007K", KYRGYZSTAN_CODE = "996", LATVIA_CODE = "371", LITHUANIA_CODE = "370",
                 MOLDOVA_CODE = "373", RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992", TURKMENISTAN_CODE = "993", UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

    switch (countryCode)  // Выражение селектор 
    {
        case AZERBAIJAN_CODE:    //Постоянное выражение
        {
            const decimal AZERBAIJAN_RATE = 1.07m;
            rate = AZERBAIJAN_RATE;
            break;
        }
        case ARMENIA_CODE:
        {
            const decimal ARMENIA_RATE = .95m;
            rate = ARMENIA_RATE;
            break;
        }
        case BELARUS_CODE:
        {
            const decimal BELARUS_RATE = 1m;
            rate = BELARUS_RATE;
                break;
        }
        case GEORGIA_CODE:
        {
            const decimal GEORGIA_RATE = .94m;
            rate = GEORGIA_RATE;
            break;  
        }
        case KAZAKHTAN_CODE:
        {
            const decimal KAZAKHTAN_RATE = .79m;
            rate = KAZAKHTAN_RATE;
            break;
        }
        case KYRGYZSTAN_CODE:
        {
            const decimal KYRGUZSTAN_RATE = .83m;
            rate = KYRGUZSTAN_RATE;
            break;
        }
        case LATVIA_CODE:
        {
            const decimal LATVIA_RATE = 1.12m;
            rate = LATVIA_RATE;
            break;
        }
        case LITHUANIA_CODE:
        {
            const decimal LITHUANIA_RATE = 1.12m;
            rate = LITHUANIA_RATE;
            break;
        }
        case MOLDOVA_CODE:
        {
            const decimal MOLDOVA_RATE = .97m;
            rate = MOLDOVA_RATE;
            break;
        }
        case RUSSIA_CODE:
        {
            const decimal RUSSIA_RATE = 1m;
            rate = RUSSIA_RATE;
            break;
        }
        case TAJIKISTAN_CODE:
        {
            const decimal TAJIKISTAN_RATE = .76m;
            rate = TAJIKISTAN_RATE;
            break;
        }
        case TURKMENISTAN_CODE:
        {
            const decimal TURKMENISTAN_RATE = .81m;
            rate = TURKMENISTAN_RATE;
            break;
        }
        case UZBEKISTAN_CODE:
        {
            const decimal UZBEKISTAN_RATE = .98m;
            rate = UZBEKISTAN_RATE;
            break;
        }
        case UKRAINE_CODE:
        {
            const decimal UKRAINE_RATE = 1m;
            rate = UKRAINE_RATE;
            break;
        }
        case ESTONIA_CODE:
        {
            const decimal ESTONIA_RATE = 1.12m;
            rate = ESTONIA_RATE;
            break;
        }
        default:
        {
            rate = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Вы ввели не существующий код {countryCode}!");
            break;

        }
    }
}

decimal tilePriceWithRate = priceTiles * rate;
decimal totalPriceTiles = quantityTiles * tilePriceWithRate;

decimal discount = 0;

decimal discountPersentage;

bool discount20PctAvailable, discount50PctAvailable;

const decimal MIN_TILES_QTY_FOR_DISCOUNT_20_PCT = 500,
              MIN_TILES_QTY_FOR_DISCOUNT_50_PCT = 1000;

discount20PctAvailable = quantityTiles >= MIN_TILES_QTY_FOR_DISCOUNT_20_PCT && quantityTiles < MIN_TILES_QTY_FOR_DISCOUNT_50_PCT;

discount50PctAvailable = quantityTiles >= MIN_TILES_QTY_FOR_DISCOUNT_50_PCT;

if (discount20PctAvailable)
{
    discountPersentage = 20;
}
else if (discount50PctAvailable)
{
    discountPersentage = 50;
}
else
{
    discountPersentage = 0;
}


discount = totalPriceTiles / 100 * discountPersentage;

decimal discountedPrice = totalPriceTiles - discount;

Console.WriteLine($"Цена плитки с учетом коэфициента {tilePriceWithRate}");
Console.WriteLine($"Общая стоимость плитки {totalPriceTiles}");
Console.WriteLine($"Сумма скидки {discount}");
Console.WriteLine($"Цена со скидкой {discountedPrice}");

*/

//  ТЕРНАРНЫЙ ОПЕРАТОР

//int x = 10, y = 5;

//string quadrant = x > 0  ?  y > 0 ? " 1 квандрант " : " 4 квандрант" : y > 0 ? "2 квандрант" : "3 квандрант";   // проверяем первое условие, если Х больше нуля остаемся в этом блоке и проверяем Y если и он больше нуля то
//  левая часть срабатывает ( 1 квандрант), если Х больше, но Y меньше правая часть срабатывает ( 4 квандрант)
// если Х меньше нуля то false  и сразу улетаем в правую часть условия где третий тернарный оператор
// там если Y больше нуля то true работает левая часть (2 квандрант) если Y меньше нуля то false работает правая
// часть условия (3 квандрант)




//string quadrant = x == 0 ? y == 0 ? "В центре плоскости координат" : "На оси X" : y == 0 ? "На оси Y" :
//x > 0 ? y > 0 ? "I квадрант" : "IV квадрант" : y > 0 ? "II квадрант" : "III квадрант";

/*
if (x > 0 && y > 0)
{
    quadrant = "1 квадрант";
}
else if (x < 0 && y < 0)
{
    quadrant = "3 двандрант";
}
else if (y > 0 && x < 0)
{
    quadrant = "2 квандрант";
}
else if (x > 0 && y < 0) 
{
    quadrant = "4 квандрант";
 
}
else if (x == 0 || y == 0)
{
    quadrant = "Error";
}
else
{
    quadrant = "0";
}
*/

/*
var weight = 70;
var height = 195;

var body = weight > 90 ? height < 190  ? "толстый" : "худой" : height > 190 ? "bed" : "good";


Console.WriteLine(body);
Console.WriteLine(quadrant);

int a = 1, b = 2, max = 0, min = 0;

var score = (a > b ? ref max : ref min) = 33; 

Console.WriteLine($"max = {max}, min = {min}");

*/

#endregion


//МАССИВЫ

static void RunOutputUserInterface(decimal tilePriceWithRate, decimal totalPriceTiles, decimal discount, decimal discountedPrice)
{
    Console.WriteLine($"Цена плитки с учетом коэфициента: {tilePriceWithRate}");
    Console.WriteLine($"Общая стоимость плитки: {totalPriceTiles}");
    Console.WriteLine($"Сумма скидки: {discount}");
    Console.WriteLine($"Цена со скидкой: {discountedPrice}");
}
static (string userLogin, string userPassword ) InputLoginAndPassword()
{
    Console.Write("Enter you login:\n");
   string login = Console.ReadLine();
    Console.Write("Enter you password:\n");
   string password = Console.ReadLine();

    return (login, password);
}
/// <summary>
/// авторизует пользователя в системе. Принимает логин и пароль от пользователя.
/// </summary>
/// <returns> true - успешная авторизация. false - неуспешная авторизация </returns>

static bool AuthorizeUser() 
{
    bool userAuthorized = false; 

        string[] loginList = { "Admin", "Ivanova", "Petrova", "Sergeeva", "Semenova", "Vasileva" };
        string[] passwordList = { "000", "111", "222", "333", "444", "555", "666" };

        int authorizationAttemptCounter = 0;
        const int ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS = 3;
        bool authorizationAttemptAvailable = authorizationAttemptCounter < ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS;

        while (authorizationAttemptAvailable)
        {
            (string userLogin, string userPassword) input = InputLoginAndPassword();
            string login = input.userLogin, password = input.userPassword;


        // authorizzed = TryAouthorizedUser(login, password)
        {
                for (int i = 0; i < loginList.Length && i < passwordList.Length; i++)
                {
                    bool loginMatched, passwordMatched; // Сопоставить логин и пароль
                    {
                        string loginByCurrentIndex = loginList[i];
                        loginMatched = loginByCurrentIndex == login;
                        string passwordByCurrentIndex = passwordList[i];
                        passwordMatched = passwordByCurrentIndex == password;
                    }

                    if (loginMatched && passwordMatched)
                    {
                        userAuthorized = true;
                        break;
                    }
                }
            }

            if (userAuthorized)
            {
                Console.WriteLine("Вы успешно авторизованы");
                break;
            }
            else
            {
                Console.WriteLine("Логин или пароль введены не верно");
                authorizationAttemptAvailable = ++authorizationAttemptCounter < ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS;

                if (authorizationAttemptAvailable)
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

    return userAuthorized;
}

bool userAutorized = AuthorizeUser();                                                                                                                   // Цикл  WHILE


while (true)
{
    string countryCode;
    decimal quantityTiles, priceTiles;
    // countryCode, priceTiles = RunInputUserInterface ()


    Console.WriteLine("Нажмите Enter, для обслуживания нового клиента.");
    Console.ReadKey();


    const string COUNTRY_CODES =
        "======================================================\n" +
        "Азербайджан (994) | Киргизия (996) | Таджикистан (992)\n" +
        "Армения     (374) | Латвия   (371) | Туркмения   (993)\n" +
        "Беларусь    (375) | Литва    (370) | Узбекистан  (998)\n" +
        "Грузия      (995) | Молдова  (373) | Украина     (380)\n" +
        "Казахстан   (007K) | Россия   (007) | Эстония     (372)\n" +
        "------------------------------------------------------";

    Console.WriteLine(COUNTRY_CODES);

    // countryCode = ProcessCounryCode (countryCode)
    {
        bool countryCodeIsCorrect;

        do
        {
            Console.WriteLine("Телефонный код страны");

            countryCode = Console.ReadLine();

            // countryCode = DetectKazakhstanCode (countryCode)
            {
                const string KAZAKHSTAN_CODE = "007";
                const string /*UPPERCASE_ENGLISH_LETTER_K = "K",*/ LOWERCASE_ENGLISH_LETTER_K = "k",
                             UPPERCASE_RUSSIAN_LETTER_K = "К", LOWERCASE_RUSSIAN_LETTER_K = "к";

                bool countryCodeIsKazakhstanCodeAndAnyLetterK =
                    //countryCode == (KAZAKHSTAN_CODE + UPPERCASE_ENGLISH_LETTER_K) ||
                    countryCode == (KAZAKHSTAN_CODE + LOWERCASE_ENGLISH_LETTER_K) ||
                    countryCode == (KAZAKHSTAN_CODE + UPPERCASE_RUSSIAN_LETTER_K) ||
                    countryCode == (KAZAKHSTAN_CODE + LOWERCASE_RUSSIAN_LETTER_K);

                if (countryCodeIsKazakhstanCodeAndAnyLetterK)
                {
                    const string UPPERCASE_ENGLISH_LETTER_K = "K";
                    countryCode = KAZAKHSTAN_CODE + UPPERCASE_ENGLISH_LETTER_K;
                }
            }



            // countryCodeIsCorrect = CheckCountryCode (counteyCode)

            {
                const string UPPERCASE_ENGLISH_LETTER_K = "K";
                const string AZERBAIJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375", GEORGIA_CODE = "995", KAZAKHTAN_CODE = "007" + UPPERCASE_ENGLISH_LETTER_K, KYRGYZSTAN_CODE = "996", LATVIA_CODE = "371", LITHUANIA_CODE = "370",
                             MOLDOVA_CODE = "373", RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992", TURKMENISTAN_CODE = "993", UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

                switch (countryCode)
                {
                    case AZERBAIJAN_CODE:
                    case ARMENIA_CODE:
                    case BELARUS_CODE:
                    case GEORGIA_CODE:
                    case KAZAKHTAN_CODE:
                    case KYRGYZSTAN_CODE:
                    case LATVIA_CODE:
                    case MOLDOVA_CODE:
                    case RUSSIA_CODE:
                    case TAJIKISTAN_CODE:
                    case TURKMENISTAN_CODE:
                    case LITHUANIA_CODE:
                    case UZBEKISTAN_CODE:
                    case UKRAINE_CODE:
                    case ESTONIA_CODE:
                        {
                            countryCodeIsCorrect = true;
                            break;
                        }
                    default:
                        {
                            countryCodeIsCorrect = false;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Вы ввели не существующий код {countryCode}!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        }



                }

            }
        }
        while (countryCodeIsCorrect == false);

    }
    Console.WriteLine("Количество плитки");
    quantityTiles = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Стоимость плитки");
    priceTiles = decimal.Parse(Console.ReadLine());

    decimal rate;
    // rate = CalculatePricaRate (countryCode)
    {
        const string UPPERCASE_ENGLISH_LETTER_K = "K";
        const string AZERBAIJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375", GEORGIA_CODE = "995", KAZAKHTAN_CODE = "007" + UPPERCASE_ENGLISH_LETTER_K, KYRGYZSTAN_CODE = "996", LATVIA_CODE = "371", LITHUANIA_CODE = "370",
                     MOLDOVA_CODE = "373", RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992", TURKMENISTAN_CODE = "993", UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

        switch (countryCode)  // Выражение селектор 
        {
            case AZERBAIJAN_CODE:    //Постоянное выражение
                {
                    const decimal AZERBAIJAN_RATE = 1.07m;
                    rate = AZERBAIJAN_RATE;
                    break;
                }
            case ARMENIA_CODE:
                {
                    const decimal ARMENIA_RATE = .95m;
                    rate = ARMENIA_RATE;
                    break;
                }
            case BELARUS_CODE:
                {
                    const decimal BELARUS_RATE = 1m;
                    rate = BELARUS_RATE;
                    break;
                }
            case GEORGIA_CODE:
                {
                    const decimal GEORGIA_RATE = .94m;
                    rate = GEORGIA_RATE;
                    break;
                }
            case KAZAKHTAN_CODE:
                {
                    const decimal KAZAKHTAN_RATE = .79m;
                    rate = KAZAKHTAN_RATE;
                    break;
                }
            case KYRGYZSTAN_CODE:
                {
                    const decimal KYRGUZSTAN_RATE = .83m;
                    rate = KYRGUZSTAN_RATE;
                    break;
                }
            case LATVIA_CODE:
                {
                    const decimal LATVIA_RATE = 1.12m;
                    rate = LATVIA_RATE;
                    break;
                }
            case LITHUANIA_CODE:
                {
                    const decimal LITHUANIA_RATE = 1.12m;
                    rate = LITHUANIA_RATE;
                    break;
                }
            case MOLDOVA_CODE:
                {
                    const decimal MOLDOVA_RATE = .97m;
                    rate = MOLDOVA_RATE;
                    break;
                }
            case RUSSIA_CODE:
                {
                    const decimal RUSSIA_RATE = 1m;
                    rate = RUSSIA_RATE;
                    break;
                }
            case TAJIKISTAN_CODE:
                {
                    const decimal TAJIKISTAN_RATE = .76m;
                    rate = TAJIKISTAN_RATE;
                    break;
                }
            case TURKMENISTAN_CODE:
                {
                    const decimal TURKMENISTAN_RATE = .81m;
                    rate = TURKMENISTAN_RATE;
                    break;
                }
            case UZBEKISTAN_CODE:
                {
                    const decimal UZBEKISTAN_RATE = .98m;
                    rate = UZBEKISTAN_RATE;
                    break;
                }
            case UKRAINE_CODE:
                {
                    const decimal UKRAINE_RATE = 1m;
                    rate = UKRAINE_RATE;
                    break;
                }
            case ESTONIA_CODE:
                {
                    const decimal ESTONIA_RATE = 1.12m;
                    rate = ESTONIA_RATE;
                    break;
                }
            default:
                {
                    rate = 0;
                    break;

                }
        }
    }

    decimal tilePriceWithRate = priceTiles * rate;
    decimal totalPriceTiles = quantityTiles * tilePriceWithRate;

    decimal discount;

    decimal discountPersentage;

    bool discount20PctAvailable, discount50PctAvailable;

    const decimal MIN_TILES_QTY_FOR_DISCOUNT_20_PCT = 500,
                  MIN_TILES_QTY_FOR_DISCOUNT_50_PCT = 1000;

    discount20PctAvailable = quantityTiles >= MIN_TILES_QTY_FOR_DISCOUNT_20_PCT && quantityTiles < MIN_TILES_QTY_FOR_DISCOUNT_50_PCT;

    discount50PctAvailable = quantityTiles >= MIN_TILES_QTY_FOR_DISCOUNT_50_PCT;

    if (discount20PctAvailable)
    {
        discountPersentage = 20;
    }
    else if (discount50PctAvailable)
    {
        discountPersentage = 50;
    }
    else
    {
        discountPersentage = 0;
    }


    discount = totalPriceTiles / 100 * discountPersentage;

    decimal discountedPrice = totalPriceTiles - discount;

    RunOutputUserInterface(tilePriceWithRate, totalPriceTiles, discount, discountedPrice);
}








