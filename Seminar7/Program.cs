//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int num = 0;
int rows = Input ("Введите количество строк");
int colum = Input ("Введите количество столбцов");
double [,] array = new double [rows,colum];
array = Fill(array);
PrintArray(array);

int Input (string message){
    Console.WriteLine(message);
    string text = Console.ReadLine();
    Check(text);
    return num;
}

void Check (string t){
    if (Int32.TryParse(t,out num))  {
        if (num > 0) {}
            else {
        Console.WriteLine("Введено некорректное значение");
        Input("Повторите ввод");
    }
    } else {
        Console.WriteLine("Введено некорректное значение");
        Input("Повторите ввод");
    }
}

double [,] Fill (double [,] ar){
    Console.WriteLine("Введите нижнюю границу чмсел массива");
    int l = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите верхнюю границу чисел массива");
    int k = Convert.ToInt32(Console.ReadLine()); 
    if (k < l) {
        Console.WriteLine("Ошибочно заданы границы. Возвращен нулевой массив");
        return ar;
    }
    Random rnd = new Random();
    for (int i = 0;i < ar.GetLength(0);i++){
        for (int j = 0;j < ar.GetLength(1);j++){
            ar[i,j] = Math.Round(rnd.Next(l,k) + rnd.NextDouble(), 2);
        }
    }
    return ar;
}

void PrintArray <T> (T [,] ar){
     for (int i = 0;i < ar.GetLength(0);i++){
        for (int j = 0;j < ar.GetLength(1);j++){
           Console.Write(ar[i,j] + " ");
        }
        Console.WriteLine();
    }
}

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int m = Input ("Введите строку");
int n = Input ("Введите столбец");

// используем массив из первого задания

if (CheckIndex()) 
    Console.WriteLine("Заданный элемент массива А[" + m + "," + n + "] -> " + array[m-1,n-1]);
else
    Console.WriteLine("Заданный элемент массива не существует");

bool CheckIndex (){
    if (m <= array.GetLength(0) && n <= array.GetLength(1))
        return true;
    else
        return false;
}
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int row = Input ("Введите количество строк");
int col = Input ("Введите количество столбцов");
int [,] arr = new int [row,col];
arr = Fill1(arr);
PrintArray(arr);
Average(arr);


int [,] Fill1 (int [,] ar){
    Console.WriteLine("Введите нижнюю границу чмсел массива");
    int l = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите верхнюю границу чисел массива");
    int k = Convert.ToInt32(Console.ReadLine()); 
    if (k < l) {
        Console.WriteLine("Ошибочно заданы границы. Возвращен нулевой массив");
        return ar;
    }
    Random rnd = new Random();
    for (int i = 0;i < ar.GetLength(0);i++){
        for (int j = 0;j < ar.GetLength(1);j++){
            ar[i,j] = rnd.Next(l,k);
        }
    }
    return ar;
}

void Average (int [,] ar){
    int sum = 0;
    double average = 0;
  for (int j = 0;j < ar.GetLength(1);j++){
        for (int i = 0;i < ar.GetLength(0);i++){
           sum += ar[i,j]; 
        }
        average = Math.Round((double) sum / ar.GetLength(0),2);
        Console.WriteLine("Среднее арифметическое столбца " + (j+1) + " -> " + average);
        sum = 0;
    }
}