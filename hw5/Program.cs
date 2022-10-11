// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("З4: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.\n"+
"[345, 897, 568, 234] -> 2\n");


string qestion="Y";
Random rnd = new Random();

while (qestion.ToLower()=="y"){
 //   int count=0; 

 //---------[Начало решения]    
    Console.WriteLine($"\nКоличество четных чисел равно {countEven(genRandomArray(1,1000))}");
//---------[Конец решения]            
        
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}


Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.\n"+
"[3, 7, 23, 12] -> 19\n"+
"[-4, -6, 89, 6] -> 0");

qestion="Y";
while (qestion.ToLower()=="y"){

//---------[Начало решения]    
    Console.WriteLine($"\nСумма элементов на нечетных местах {sumElementsOnEvenPosition(genRandomArray(1,1000))}");
//---------[Конец решения]            
        
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}

Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.\n"+
"[3 7 22 2 78] -> 76");

qestion="Y";
while (qestion.ToLower()=="y"){

 //---------[Начало решения]    
    int[] mm=minMax(genRandomArray(1,1000));
    Console.WriteLine($"\n Сумма между максимальным{mm[1]} и минимальным{mm[0]} элементами равна {mm[1]-mm[0]}");
//---------[Конец решения]            
        
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}



int[] genRandomArray(int from,int to){
        Random rnd = new Random();
        int[] myArray = new int[rnd.Next(1,50)];
        for (int i=0;i<myArray.Length;i++){
        myArray[i]=rnd.Next(-1000,1000);
        Console.Write($"{myArray[i]} ");        
    }
    return myArray;
}

 int countEven(int[] array){
    int count=0;
    for (int i=0;i<array.Length;i++){
        if (array[i]%2==0) count++;
    }
    return count;
 }

  int[] minMax(int[] array){
    int[] minmax = new int[2];
    //Минимум
    minmax[0]=array[0];
    //Максимум
    minmax[1]=array[0];
    for (int i=1;i<array.Length;i++){
        if (minmax[0]>array[i]) minmax[0]=array[i];
        if (minmax[1]<array[i]) minmax[1]=array[i];

    }
    return minmax;
 }

int sumElementsOnEvenPosition(int[] array){
    int sum=0;
    for(int i=1;i<array.Length;i=i+2){
        sum+=array[i];
    }
    return sum;
}
 