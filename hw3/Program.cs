
// //Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125




Console.Clear();
Console.WriteLine("Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.\n"+
"14212 -> нет\n"+
"12821 -> да\n"+
"23432 -> да\n");

string qestion="Y";
long a;
while (qestion.ToLower()=="y"){
    Console.WriteLine("Введите пятизначное число, хотя можно и любое ");
    a=Convert.ToInt64(Console.ReadLine());
    Console.WriteLine($"Число {a} - {isPolindrom(a)} ");
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}

Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.\n"+
"A (3,6,8); B (2,1,-7), -> 15.84\n"+
"A (7,-5, 0); B (1,-1,9) -> 11.53\n");


qestion="Y";
while (qestion.ToLower()=="y"){
    int[,] coord = new int[2,3];    
    Console.WriteLine("Введите трехмерные координаты точки А");
    Console.WriteLine("x1=");
    coord[0,0]=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y1=");
    coord[0,1]=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("z1=");
    coord[0,2]=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите трехмерные координаты точки А");
    Console.WriteLine("x2=");
    coord[1,0]=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y2=");
    coord[1,1]=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("z2=");
    coord[1,2]=Convert.ToInt32(Console.ReadLine());

    double rangeAB= Math.Sqrt(Math.Pow((coord[0,0]-coord[1,0]),2)+Math.Pow((coord[0,1]-coord[1,1]),2)+Math.Pow((coord[0,2]-coord[1,2]),2));
    Console.Write($"Растояние между точками А({coord[0,0]},{coord[0,1]},{coord[0,2]}) и В({coord[1,0]},{coord[1,1]},{coord[1,2]}) равно");
    Console.WriteLine($" {Convert.ToInt32(rangeAB*100)/100}.{Convert.ToInt32(rangeAB*100)%100}");
    Console.Write("Для ввода новых чисел введите - Y  ");
    
    qestion=Console.ReadLine();
    Console.Clear();
}


Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N..\n"+
"3 -> 1, 8, 27\n"+
"5 -> 1, 8, 27, 64, 125\n");

qestion="Y";
while (qestion.ToLower()=="y"){
    Console.WriteLine("Число А");
    a=Convert.ToInt64(Console.ReadLine());
    for (int i=0;i<=a;i++){
        Console.Write($"({Math.Pow(i,3)}),");
    }
    Console.WriteLine("");
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}

/**
*Метод проверяющий является ли число полиндромом или нет
*a - число
*return - сообщение
*/
string isPolindrom(long a){
    //Считае колличество цифр
    int dig=0;
    long a1=a;
    long[] digits;    

     //Считае колличество цифр
    while(a1>0){
        dig++;
        a1=a1/10;
    }
    a1=a;
    digits = new long[dig];
     //Заполняем массив цифрами числа в обратном порядке
    for (int i=0;i<digits.Length;i++){
        digits[i]=a1%10;
        a1=a1/10;
    }
    //Проверяем условие на полиндром
    for (int i=0;i<digits.Length/2;i++){       
        if(digits[i]!=digits[digits.Length-1-i]){
            return "Не полиндром";
        }
    }
    return "Полиндром";
}

/**
*Возведение в степень
*a - число
*st-степень
*return - Число a в степени st
*/
long myPow(int x,int st){
    long deg=x;
    for (int i=1;i<st;i++){
        deg=deg*x;
    }
    return deg;

}
