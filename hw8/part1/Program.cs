

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();


Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.\n");

string qestion = "Y";
Random rnd = new Random();

while (qestion.ToLower() == "y")
{
    //---------[Начало решения]    
    int[,] myArray = generateIntArray(rnd.Next(1, 10), rnd.Next(1, 10));
    Console.WriteLine("UNSORTED");
    printAray(myArray);
    Console.WriteLine("\nSORTED");
    printAray(sortArrayFromMaxToMinB(myArray));
    //---------[Конец решения]            

    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion = Console.ReadLine();
    Console.Clear();
}


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.\n");

qestion = "Y";

while (qestion.ToLower() == "y")
{
    //---------[Начало решения]    
    int[,] myArray = generateIntArray(rnd.Next(1, 10), rnd.Next(1, 10));
    printAray(myArray);
    Console.WriteLine($"\n Строка с минимальной суммой - {findRowWhithMinSum(myArray)}");
    //---------[Конец решения]            

    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion = Console.ReadLine();
    Console.Clear();
}



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//
// 1) В мастрице должно совпадать число строк одной матрицы с числои столбцов другой матрицы
// 2)  a(l,m) b(m,n) c(l,n)=a(l,m)*b(m,n)
// c(i,j)=sum(a(i,r)*b(r,j)) где r от 1 до m , i от 1 до l, j от 1 до m

Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n");

qestion = "Y";

while (qestion.ToLower() == "y")
{
    //---------[Начало решения]    
    int l=rnd.Next(1,10);
    int m=rnd.Next(1,10);
    int n=rnd.Next(1,10);
    int[,] matrixA=generateIntArray(l,m);
    int[,] matrixB=generateIntArray(m,n);
    int[,] matrixC=new int[l,n];

    for(int i=0;i<matrixC.GetLongLength(0);i++){
        for(int j=0;j<matrixC.GetLongLength(1);j++){
            for(int r=0;r<matrixA.GetLength(1);r++){
                matrixC[i,j]+=matrixA[i,r]*matrixB[r,j];
            }
        }
    }
    Console.WriteLine("\nMatrixA");
    printAray(matrixA);
    Console.WriteLine("\nMatrixB");
    printAray(matrixB);
    Console.WriteLine("\nMatrixС");
    printAray(matrixC);
    //---------[Конец решения]            

    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion = Console.ReadLine();
    Console.Clear();
}


/**
* Возвращает массив целых чисел rows*cols от 10 до 99
*/
int[,] generateIntArray(int rows, int cols)
{
    Random myRnd = new Random();
    int[,] myArray = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            myArray[i, j] = myRnd.Next(10, 99);
        }
    }
    return myArray;
}

/**
* Печатает двумерный массив чисел
* array - - двумерный целочисленый массив
*/
void printAray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
            if (j != array.GetLength(1) - 1) Console.Write(";");
        }
        Console.WriteLine("]");
    }
}

/**
*Возвращает массив в котором каждая строка отсортирована на убыванию
* array - двумерный целочисленый массив
* return -  Отсортированый двумерный целочисленый массив
*/
int[,] sortArrayFromMaxToMinB(int[,] array)
{

    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            bool isSwap = false;
            for (int j = 0; j < array.GetLength(1) - 1 - i; j++)
            {
                if (array[row, j] < array[row, j + 1])
                {
                    int temp = array[row, j];
                    array[row, j] = array[row, j + 1];
                    array[row, j + 1] = temp;
                    isSwap = true;
                }
            }
            if (!isSwap) break;
        }
    }
    return array;
}

/**
*Возвращает номер строки с минимальной сыммой элементов
* array - двумерный массив с целочисленными числами
* return -  номер строки
*/


int findRowWhithMinSum(int[,] array)
{

    if (array.GetLength(0) == 1) return 0;

    int minSum = 0;
    int rowWithMinSum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) minSum = sum;
        else
        {
            if (minSum > sum)
            {
                minSum = sum;
                rowWithMinSum = i;

            }
        }
    }
    return rowWithMinSum;
}


