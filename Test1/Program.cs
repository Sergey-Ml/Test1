
//////////////////////////////////////////////////////////
// Задача 1
//Console.WriteLine("Введите число от 1 до 100 : ");
//int chislo = Convert.ToInt32 (Console.ReadLine());
//if ((chislo <1)||(chislo >100))
//{
//    Console.WriteLine("ERROR! Ошибка ввода");
//}
//else
//{
//    if (chislo % 3 == 0)
//        Console.Write("Fizz ");
//    if (chislo % 5 == 0)
//        Console.Write("Buzz");
//    if ((chislo % 3 != 0) && (chislo % 5 != 0))
//        Console.WriteLine(chislo);
//}

/////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////
//Задача 2
//Console.WriteLine("Введите значение: ");
//int chislo = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите процент: ");
//int proc = Convert.ToInt32(Console.ReadLine());
//double rez = (chislo*proc)/100;
//Console.WriteLine($"Результат: {rez}");
/////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////
//Задача 3
//Console.WriteLine("Введите первое число: ");
//int chislo_1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int chislo_2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите третье число: ");
//int chislo_3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите четвертое число: ");
//int chislo_4 = Convert.ToInt32(Console.ReadLine());
//int rez = chislo_1 * 1000 + chislo_2 * 100 + chislo_3 * 10 + chislo_4;
//Console.WriteLine(rez);

//////////////////////////////////////////////////////////
//Задача 4
//Console.WriteLine("Введите шестизначное число: ");
//string chislo= Console.ReadLine();
//char[] chars = chislo.ToCharArray();
//int ch = Convert.ToInt32(chislo);
//if (ch > 999999 || ch < 100000)
//    Console.WriteLine("ERROR! Ошибка ввода");

//else
//{
//    Console.WriteLine("Введите номер первого разряда для обмена: ");
//    int razr_1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Введите номер второго разряда для обмена: ");
//    int razr_2 = Convert.ToInt32(Console.ReadLine());
//    char test = chars[razr_1 - 1];
//    chars[razr_1 - 1] = chars[razr_2-1];
//    chars[razr_2 - 1] = test;
//    chislo = new string(chars);
//    Console.WriteLine (chislo);

//}

//////////////////////////////////////////////////////////
//Задача 5
//Console.WriteLine("Введите Дату: ");
//string date = Console.ReadLine();
//DateTime date1 = Convert.ToDateTime(date);
//Console.WriteLine(date1.DayOfWeek);
//string month = date1.Month.ToString();

//switch (month)
//{
//    case "1":
//    case "2":
//    case "12":
//        Console.WriteLine("Winter");
//        break;
//    case "3":
//    case "4":
//    case "5":
//        Console.WriteLine("Spring");
//        break;
//    case "6":
//    case "7":
//    case "8":
//        Console.WriteLine("Summer");
//        break;
//    case "9":
//    case "10":
//    case "11":
//        Console.WriteLine("Autumn");
//        break;

//}


//////////////////////////////////////////////////////////
//Задача 6
//Console.WriteLine("Введите показание температуры: ");
//double temp  = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Эта температура в градусах C или F ?");
//string grad = Console.ReadLine();
//switch(grad)
//{ 
//    case "F":
//        double F = (5/9.0) * (temp - 32);
//        Console.WriteLine($"Температура в градусах С = {F}");
//        break;
//    case "C":
//        double C = (9/5.0)* temp + 32;
//        Console.WriteLine($"Температура в градусаx F = {C}");
//        break;
//    default:
//        Console.WriteLine("ERROR! Ошибка ввода");
//        break;

//}

///////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////
//Задача 7
Console.WriteLine("Введите первое число: ");
int pervoe = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int vtoroe = Convert.ToInt32(Console.ReadLine());

if (pervoe > vtoroe)
{
   int temp = pervoe;
    pervoe = vtoroe;
    vtoroe = temp;
}

while (pervoe < vtoroe)
{
    pervoe = (pervoe + 2) - pervoe % 2;
    Console.WriteLine(pervoe);
}
