// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.\n");

string qestion="Y";
Random rnd = new Random();

while (qestion.ToLower()=="y"){


//---------[Начало решения]    
    printAray(generateDoubleArray(rnd.Next(1,10),rnd.Next(1,10)));
//---------[Конец решения]            
        
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}

Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.\n");

qestion="Y";

while (qestion.ToLower()=="y"){

//---------[Начало решения]    
    int[,] myArray = generateIntArray(rnd.Next(1,10),rnd.Next(1,10));
    printIntAray(myArray);

    Console.Write("введите номер строки ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите номер столбца ");
    int col = Convert.ToInt32(Console.ReadLine());    

    if(row>(myArray.GetLength(0)-1)||row>(myArray.GetLength(1)-1)){
        Console.WriteLine("Нет такого элемента");
    }else{
        Console.WriteLine($"Элемент массива [{row},{col}]={myArray[row,col]}");
    }    
//---------[Конец решения]            
        
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}

qestion="Y";

while (qestion.ToLower()=="y"){

//---------[Начало решения]    
    int[,] myArray = generateIntArray(rnd.Next(1,10),rnd.Next(1,10));
    printIntAray(myArray);
    printMidByCol(myArray);
//---------[Конец решения]            
        
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}

//----------------------
//Методы

/**
* Возвращает массив вещественных чисел rows*cols
*/
double[,] generateDoubleArray(int rows, int cols){
    Random myRnd=new Random();
    double[,] myArray = new double[rows,cols];
    for (int i=0;i<rows;i++){
        for(int j=0;j<cols;j++){
            myArray[i,j]=myRnd.NextDouble()*100;
        }
    }
    return myArray;
}

/**
* Возвращает массив целых чисел rows*cols от -100 до 100
*/
int[,] generateIntArray(int rows, int cols){
    Random myRnd=new Random();
    int[,] myArray = new int[rows,cols];
    for (int i=0;i<rows;i++){
        for(int j=0;j<cols;j++){
            myArray[i,j]=myRnd.Next(-100,100);
        }
    }
    return myArray;
}

/**
*Печатает двумерный массив вещественных чисел со всеми знаками после запятой
*/
void printAray(double[,] dArray){
    for(int i=0;i<dArray.GetLength(0);i++){
        Console.Write("[");
        for(int j=0;j<dArray.GetLength(1);j++){
            Console.Write($"{dArray[i,j]}");
            if(j!=dArray.GetLength(1)-1) Console.Write(";");
        }
        Console.WriteLine("]");
    }
}

/**
*Печатает двумерный массив вещественных чисел со всеми знаками после запятой
*/
void printIntAray(int[,] dArray){
    for(int i=0;i<dArray.GetLength(0);i++){
        Console.Write("[");
        for(int j=0;j<dArray.GetLength(1);j++){
            Console.Write($"{dArray[i,j]}");
            if(j!=dArray.GetLength(1)-1) Console.Write(";");
        }
        Console.WriteLine("]");
    }
}


void printMidByCol(int[,] myArray){
    double[,] sumCols= new double[1,myArray.GetLength(1)];
    for (int j=0;j<myArray.GetLength(1);j++){        
        for (int i=0;i<myArray.GetLength(0);i++){
            sumCols[0,j]+=myArray[i,j];
        }
        sumCols[0,j]=(sumCols[0,j]/myArray.GetLength(1));

    }
    Console.WriteLine("--------------------");
    printAray(sumCols);
}
