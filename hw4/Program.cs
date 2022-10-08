// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Clear();
Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.\n"+
"3, 5 -> 243 (3⁵)\n"+
"2, 4 -> 16\n");

string qestion="Y";
int a;
int st;
while (qestion.ToLower()=="y"){
    Console.WriteLine("Введите число ");
    a=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите степень числа, в которую возвести число {a} ");
    st=Convert.ToInt32(Console.ReadLine());

    // По уcловию задачи через цикл
    long a1=a;
    for (int i=2;i<=st;i++){
        a1*=a;
    }
    Console.WriteLine($"По условию задачи {a}^{st}={a1}");

    // Через самописный метод
    Console.WriteLine($"Через самописный метод {a}^{st}={myPow(a,st)}");

    // Через библиотеку Math
    Console.WriteLine($"Через самописный метод {a}^{st}={Math.Pow(a,st)}");

    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}

Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.\n"+
"452 -> 11\n"+
"82 -> 10\n"+
" 9012 -> 12\n");

qestion="Y";
int b;
while (qestion.ToLower()=="y"){
    Console.WriteLine("Введите число ");
    b=Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int sum=0;
    Console.Write($"В числе {b}");
    while(b>0){
        sum+=b%10;
        b/=10;
    }
    Console.WriteLine($" сумма цифр = {sum}");

    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}

Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.\n"+
"1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]\n"+
"6, 1, 33 -> [6, 1, 33]\n");

qestion="Y";
int[] myArray = new int[8];
int myArraySize;
while (qestion.ToLower()=="y"){
    myArraySize=0;    
    while(myArraySize<myArray.Length){
            Console.Write($"Введите {myArraySize+1 } число или (-1) для прекращения ввода - ");
            b=Convert.ToInt32(Console.ReadLine());
            if(b==-1){
                break;
            }
            myArray[myArraySize]=b;
            myArraySize++;
    }
    Console.Write("[");
    for (int i=0;i<myArraySize;i++){
        Console.Write($"{myArray[i]}");
        if (i<myArraySize-1){
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");

    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
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
