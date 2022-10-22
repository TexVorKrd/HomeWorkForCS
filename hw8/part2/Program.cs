// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.WriteLine("Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.\n");

string qestion="Y";
Random rnd = new Random();

while (qestion.ToLower()=="y"){


//---------[Начало решения]    
    
    int x= rnd.Next(2,5);
    int y= rnd.Next(2,5);

    //Ескость трехмерного массива не должна быть больше 90
    int z=rnd.Next(2,(90/(x*y)));

    //тестовый массив для проверки повторения чисел
    bool[] digTest = new bool[100];

    int[,,] matrix = new int[x,y,z];

    
    //Заполняем и выводим массив
    Console.WriteLine($"массив[{z},{x},{y}] - {z} - плоскостей {x} - строк {y} - столбцов \n");
    for (int n=0;n<matrix.GetLength(2);n++){
        Console.WriteLine($"Плоскость {n}");
        for (int i=0;i<matrix.GetLength(0);i++){
            for (int j=0;j<matrix.GetLength(1);j++){
                int value = rnd.Next(10,99);
                while(digTest[value]){
                    value = rnd.Next(10,99);
                }
                matrix[i,j,n]=value;
                digTest[value]=true;
                Console.Write($"{value}({n},{i},{j})  ");                
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
//---------[Конец решения]            
        
    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion=Console.ReadLine();
    Console.Clear();
}