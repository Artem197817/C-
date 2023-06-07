//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

int [] arr = new int[Init()];
arr = Fill0(arr);
PrintArr(arr);
CountEven();

int Init (){
Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
return length;
}

int [] Fill0 (int [] ar){
    Console.WriteLine("Введите нижнюю границу чмсел массива");
    int l = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите верхнюю границу чисел массива");
    int k = Convert.ToInt32(Console.ReadLine());
    if (k < l) {
        Console.WriteLine("Ошибочно заданы границы. Возвращен нулевой массив");
        return ar;
    }
    Random rnd = new Random();
    for (int i = 0;i < ar.Length;i++)
        ar[i] = rnd.Next(l,k+1);
    return ar;
}
void CountEven (){
    int count = 0;
    foreach (int ar in arr)
       if (ar%2 == 0) count++;
    Console.WriteLine ("Количество четных чисел -> " + count);
}
void PrintArr<T>(T [] arr){
    Console.Write("Массив - [");
    foreach (T ar in arr)
        Console.Write (ar + " ");
      Console.Write("]"); 
      Console.WriteLine();  
}

//  Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int [] arr1 = new int[Init()];
arr1 = Fill0(arr1);
PrintArr(arr1);
Sum(arr1);

void Sum (int [] ar) {
    int sum = 0;
    for (int i = 0;i < ar.Length; i +=2)
        sum += ar[i];
    Console.WriteLine ("Сумма чисел с нечетным индексом -> " + sum);
}

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] arr2 = new double [Init()];
arr2 = Fill1(arr2);
PrintArr(arr2);
DiffMaxMin(arr2);

double [] Fill1 (double [] ar){
    Console.WriteLine("Введите нижнюю границу чмсел массива");
    int l = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите верхнюю границу чисел массива");
    int k = Convert.ToInt32(Console.ReadLine()); 
    if (k < l) {
        Console.WriteLine("Ошибочно заданы границы. Возвращен нулевой массив");
        return ar;
    }
    Random rnd = new Random();
    for (int i = 0;i < ar.Length;i++)
        ar[i] = Math.Round((k - l) * rnd.NextDouble() + l, 2);
    return ar;
}
void DiffMaxMin (double [] a) {
    double max = a[0];
    double min = a[0];
    for (int i = 1;i < a.Length; i++){
        if (a[i] > max) max = a[i];
        if (a[i] < min) min = a[i];
    }
    Console.WriteLine("Разность между максимальным и минимальным числом -> " + max + " - " + min + 
        " = " + (max - min));
} 


