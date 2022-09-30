/**
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.Clear();
Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.\n"+
"456 -> 5\n"+
"782 -> 8\n"+
"918 -> 1\n");

string qestion="Y";
long a;
while (qestion.ToLower()=="y"){
    Console.Write("Введите трехзначное число ");
    a=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Вторая цифра числа \"{a}\" равна\"{(a/10)%10}\"");
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}


Console.Clear();
Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.\n"+
"645 -> 5\n"+
"78 -> третьей цифры нет\n"+
"32679 -> 6");

//Число цифр в числе
Int64 d =0;
// 10 в степени (dig-3)
Int64 st =1;
qestion="Y";
while (qestion.ToLower()=="y"){
    Console.Write("Введите число ");
    a=Convert.ToInt64(Console.ReadLine());
    if(a<100){
        Console.WriteLine($"В числе \"{a}\" нет третьей цифры");
    }else{
        // Третья цифра с конца
         Console.Write($"Третья цифра с конца числа \"{a}\" равна \"{(a/100)%10}\" "); 
         long a1=a;
         while(a1>0){
            d++;
            a1=a1/10;
         }
         // Накопление степени 10
         for(int i=1;i<=d-3;i++){
            st=st*10;

         }         
         Console.WriteLine($", с начала равна \"{(a/st)%10}\" ");         
    } 
    
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}

Console.Clear();
Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.\n"+
"6 -> да\n"+
"7 -> да\n"+
"1 -> нет");

qestion="Y";
while (qestion.ToLower()=="y"){
    Console.Write("Введите день недели ");
    a=Convert.ToInt32(Console.ReadLine());
    if(a<1||a>7){
        Console.WriteLine($"Нет дня недели с номером \"{a}\" "); 
    }else{
        if (a>5){
            Console.WriteLine("Выходной день");
        }else{
            Console.WriteLine("Рабочий день");
        }
    }
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}

//Реализация через Массив
string[] day =new string[7];
for (int i=0;i<day.Length;i++){
    if(i<6){
        day[i]="Рабочий";
    }else{
        day[i]="Выходной";
    }
}
qestion="Y";
while (qestion.ToLower()=="y"){
    Console.Write("Введите день недели ");
    a=Convert.ToInt32(Console.ReadLine());
    if(a<1||a>7){
        Console.WriteLine($"Нет дня недели с номером \"{a}\" "); 
    }else{      
            Console.WriteLine(day[a]);
    }    
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}


