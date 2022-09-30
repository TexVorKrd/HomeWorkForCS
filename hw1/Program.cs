/**
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Clear();
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.\n"+
"a = 5; b = 7 -> max = 7\n"+
"a = 2 b = 10 -> max = 10\n"+
"a = -9 b = -3 -> max = -3\n");

string qestion="Y";
int a;
int b;
while (qestion.ToLower()=="y"){
    Console.Write("Введите a ");
    a=Convert.ToInt16(Console.ReadLine());
    Console.Write("Введите b ");
    b=Convert.ToInt16(Console.ReadLine());
    if(a>b){
        Console.WriteLine($"MAX={a}");
    }else{
        Console.WriteLine($"MAX={b}");
    }
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();

}
Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.\n"+
"2, 3, 7 -> 7\n"+
"a = 2 b = 10 -> max = 10\n"+
"44 5 78 -> 78\n");

qestion="Y";
int c;
while (qestion.ToLower()=="y"){
    Console.Write("Введите a ");
    a=Convert.ToInt16(Console.ReadLine());
    Console.Write("Введите b ");
    b=Convert.ToInt16(Console.ReadLine());
    Console.Write("Введите c ");
    c=Convert.ToInt16(Console.ReadLine());
    if(a>b){
        if(a>c){
            Console.WriteLine($"MAX={a}");
        }else{
            Console.WriteLine($"MAX={c}");            
        }        
    }else{
        if(b>c){
            Console.WriteLine($"MAX={b}");
        }else{
            Console.WriteLine($"MAX={c}");
        }        
    }
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}

Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).\n"+
"4 -> да\n"+
"-3 -> нет\n"+
"7 -> нет\n");
qestion="Y";

while (qestion.ToLower()=="y"){
    Console.Write("Введите a ");
    a=Convert.ToInt16(Console.ReadLine());
    if(a%2==0){
        Console.WriteLine($"Число {a} четное");
    }else{
        Console.WriteLine($"Число {a}  не четное");
    }
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}

Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.\n"+
"5 -> 2, 4\n"+
"8 -> 2, 4, 6, 8\n");
qestion="Y";

while (qestion.ToLower()=="y"){
    Console.Write("Введите a ");
    a=Convert.ToInt16(Console.ReadLine());
    
    for(int i=2;i<=a;i=i+2){
        Console.Write($"{i} ");
    }
    Console.WriteLine();

    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}