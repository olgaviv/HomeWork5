// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    
        array[i] = new Random().Next(minValue, maxValue +1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindEvenNumbers(int[]array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    
        if(array[i] % 2 ==0)
         count++;
    return count;
    
}
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(n,100,999);
ShowArray(myArray);
int evenNumbers = FindEvenNumbers(myArray);
Console.WriteLine("Количество четных элементов в массиве: "+ evenNumbers);
*/

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];// инициализация массива

    for (int i = 0; i < size; i++)
    
        array[i] = new Random().Next(minValue, maxValue +1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindSum(int[]array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i=i+2)
    
         sum+=array[i];
    return sum;
    
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(n,min,max);
ShowArray(myArray);
 int res = FindSum(myArray);
 Console.WriteLine("Сумма элементов на нечётных позициях равна:"+ res);

 */

 //  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] CreateRandomArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().NextDouble();
    return array;
}


void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 3) + " ");
    Console.WriteLine();
}


double FindMin(double[]array)
{   double min = array[0];    
    for (int i = 0; i<array.Length-1; i++)
        if(array[i]>array[i+1]) min = array[i+1];
            
    return min;
}
    
    double FindMax(double[]array)
{   double max = array[0];
    
    for (int i = 0; i<array.Length-1; i++)
   
           if(array[i]<array[i+1]) max = array[i+1];
                    
    return max;
   
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(n);
ShowArray(myArray);

CreateRandomArray(n);
double min = FindMin(myArray);
double max = FindMax(myArray);
double res = max-min;

//Console.Write(Math.Round(array[i], 2) + " ");
Console.WriteLine($" Min = {Math.Round(min, 3)}");
Console.WriteLine($" Max = {Math.Round(max, 3)}");
Console.WriteLine($" Разница между {Math.Round(res, 3)}");
