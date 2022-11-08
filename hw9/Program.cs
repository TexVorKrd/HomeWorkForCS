// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

      
    Console.Write("Введите M ");
    int m= Convert.ToInt32(Console.ReadLine());
    printIntDown(m);
          

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

       
    Console.Write("\nВведите M ");
     m= Convert.ToInt32(Console.ReadLine());     
     Console.Write("\nВведите N ");
     int n= Convert.ToInt32(Console.ReadLine());
    Console.Write($"\nСумма элементов от {m} до {n} равна {sumFromMtoN(m,n,0)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

    Console.Write("\nВведите N ");
     n= Convert.ToInt32(Console.ReadLine());     
     Console.Write("\nВведите M ");
     m= Convert.ToInt32(Console.ReadLine());
     Console.Write($"\nФункция Аккермана для M={m} до N={n} равна {akkerman(n,m)}");

     

void printIntDown(int x){
    if (x>0){
        Console.Write($"{x}");
        if (x!=1) Console.Write(",");
        printIntDown(x-1);
    }    
}

double sumFromMtoN(int m,int n, double sum){
    if (m>n){
       return  sumFromMtoN(n,m,sum);
    }
    if (m!=n){
        return sumFromMtoN(m+1,n,sum+m);
    }
    return sum+m;
}

int akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return akkerman(n - 1, 1);
    if (n > 0 && m > 0) return akkerman(n - 1, akkerman(n, m - 1));
    return akkerman(n, m);
}
