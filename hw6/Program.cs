// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3   - ОШИБКА В УСЛОВИИ ЗАДАЧИ

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();
Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь..\n"+
" 0, 7, 8, -2, -2 -> 2\n"+
"1, -7, 567, 89, 223-> 3\n");

string qestion="Y";


while (qestion.ToLower() == "y"){

 //---------[Начало решения] 
    int countPositive =0;
    int totalCount =0;
    string inputFromConsole;


    Console.Write("Вводите 1 число, для завершения ввода введите любое значение кроме числа - ");
    inputFromConsole = Console.ReadLine();
    while (digsTest(inputFromConsole)){
        totalCount++;
        if (Convert.ToInt32(inputFromConsole) > 0) countPositive++;
        Console.Write($"Вводите {totalCount+1} число, для завершения ввода введите любое значение кроме числа - ");
        inputFromConsole = Console.ReadLine();
    }
    Console.WriteLine($"\nВведено {totalCount} чисел, из них {countPositive} больше 0 ");
//---------[Конец решения]

    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}


Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.\n"+
"b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)\n");

qestion="Y";

while (qestion.ToLower() == "y"){

//Пусть коэффициенты будут целыми числами
double a1;
double a2;
double b1;
double b2;

//Ввод с консоли
string inputFromConsole;

    //---------[Начало решения]

    Console.WriteLine("введите коэфициенты первой прямой y=a1x+b1");
    Console.Write("введите a1 ");
    a1 = getFromConsole();
    Console.Write("введите b1 ");
    b1 = getFromConsole();
    Console.Clear();

    Console.WriteLine("введите коэфициенты первой прямой y=a2x+b2");
    Console.Write("введите a2 ");
    a2 = getFromConsole();
    Console.Write("введите b2 ");
    b2 = getFromConsole();

    twoLinesCross(a1,a2,b1,b2);
    
//---------[Конец решения]

    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}


/**
* Проверяем является ли строка целым числом
* str строка
* return bool: true - если строка может быть конвертирована в число, false - если не может 
*/
bool digsTest(string str){
    
     //Проверяем что строка существует       
    if (str==null) return false;

    // Убираем пробелы
    str=str.Trim();
    
    //Проверяем что что-то ввели
    if (str.Length<1) return false;

    //Если первый символ "-" то длинна должна быть больше 1
    if (str[0].Equals("-"[0])&&str.Length<2) return false;

    //Проверяем что первый символ "-" или любая цифра
    if (!((str[0].Equals("-"[0]))||(char.IsDigit(str[0])))){    
        return false;
    }

    //Если длинна строки больше 1 проверяем все оставшиеся символы являются ли они цифрами
    if(str.Length>1){
        for(int i=1;i<str.Length;i++){
           if(!char.IsDigit(str[i])){
                return false;
            }
        } 
    }

    return true;        
}

/**
** Возвращает информацию о точке пересечения двух прямых
*/
void twoLinesCross(double a1,double a2,double b1,double b2){
    Console.Write($"прямые y={a1}x+{b1} и y={a2}x+{b2} ");
    if (a1==a2){
        if(b1==b2){
            Console.WriteLine("совпадают");
        }else{
            Console.WriteLine("параллельны, точек пересечения нет");
        }
    }else{
        double x=(b2-b1)/(a1-a2);
        double y=a1*x+b1;
        Console.WriteLine($"пересекаются в точке ({x},{y})");
    }
}

/**
*Возвращает целое число с консоли или просит ввести звново
*/
double getFromConsole(){
     string inputFromConsole=Console.ReadLine();
     while(!digsTest(inputFromConsole)){
        Console.WriteLine("Введите целое число а не какую-то хрень");
        inputFromConsole=Console.ReadLine();
        }
 return Convert.ToDouble(inputFromConsole);
}
