// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
//
//УСЛОЖНИМ -  Массив m - Строк n - Столбцов m от 2 до 20 , n от 2 до 20

Console.Clear();
Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив m на n.\n");

string qestion="Y";
Random rnd = new Random();
int[,] array= new  int[rnd.Next(2,21),rnd.Next(2,21)]; 
int leftBorder=0;
int rightBorder=array.GetLength(1)-1;
int upBorder=0;
int downBorder=array.GetLength(0)-1;
int value =1;

//шаг по счету
int step=0;

//Стартовая позиция {х,y} x - строка y - столбец
int[] pos={0,0};

while (qestion.ToLower() == "y"){

    while (leftBorder <= rightBorder && upBorder <= downBorder)
    {        
        step = makeStep(step);
    }
    printAray(array);

    Console.Write("Для ввода новых чисел введите - Y  ");
    qestion = Console.ReadLine();

    //Сбрасываем значения для нового решения
    array = new int[rnd.Next(2, 21), rnd.Next(2, 21)];
    leftBorder = 0;
    rightBorder = array.GetLength(1) - 1;
    upBorder = 0;
    downBorder = array.GetLength(0) - 1;
    value = 1;
    step = 0;
    pos[0] = 0;
    pos[1] = 0;

    Console.Clear();
}




/**
* Спирально заполняет массив числами начиная с позиции (0,0) и последовательно увеличивая число на 1
*
* Описание реализации
* 1) определяем границы заполнения массива левая/правая/верхняя/нижняя
* 2) двигаемся по замкнутому циклу делая один из шагов (ВПРАВО/ВНИЗ/ВЛЕВО/ВВЕРХ) 
* 3) последовательность шагов определена ВПРАВО->ВНИЗ->ВЛЕВО->ВВЕРХ
* 5) так как шагов 4 и они строго идут друг за другом для идентификации используем остаток от деления номера шага на 4
* 6) после каждого шага одна из границ сдвигается
* 7) После каждого шага проверяется условия что левая граница левее правой, а верхняя выше нижней, если условие нарушается цикл прерывается
* 
*/

int makeStep(int mover){
   
    if(mover%4==0){
        //Идем направо
        for(int i=pos[1];i<=rightBorder;i++){
            array[pos[0],i]=value;
            value++;
        }
        pos[0]++;
        pos[1]=rightBorder;
        upBorder++;
    }

    if(mover%4==1){
        //Идем вниз
        for(int i=pos[0];i<=downBorder;i++){
            array[i,pos[1]]=value;
            value++;
        }
        pos[0]=downBorder;
        pos[1]--;        
        rightBorder--;
    }

    if(mover%4==2){
        //Идем влево
        for(int i=pos[1];i>=leftBorder;i--){
            array[pos[0],i]=value;
            value++;
        }
        pos[0]--;
        pos[1]=leftBorder;
        downBorder--;
    }

        if(mover%4==3){
        //Идем вверх
        for(int i=pos[0];i>=upBorder;i--){
            array[i,pos[1]]=value;
            value++;
        
        }
        pos[0]=upBorder;
        pos[1]++;
        leftBorder++;
    }
    mover++;   

    return mover;    
}

/**
*Печатает двумерный массив чисел дополняя недостоющие знаки предществующими нулями
*/
void printAray(int[,] dArray){
    
    //Считаем кол-во знаков в числе
    int digsInMaxValue=Convert.ToString((dArray.GetLength(0)*dArray.GetLength(1))).Length;
    
    for(int i=0;i<dArray.GetLength(0);i++){
        Console.Write("[");
        for(int j=0;j<dArray.GetLength(1);j++){            

            //Допечатываем 0 внвчале чтобы вывод был форматированый
            for (int n=Convert.ToString(dArray[i,j]).Length;n<digsInMaxValue;n++) Console.Write("0");
            
            Console.Write($"{dArray[i,j]}");
            if(j!=dArray.GetLength(1)-1) Console.Write(";");
        }
        Console.WriteLine("]");
    }
}


        
    
