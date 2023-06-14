// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
int num = 0;
int rows = Input ("Введите количество строк");
int colum = Input ("Введите количество столбцов");
int [,] array = new int [rows,colum];
array = FillArray(array);
PrintArray(array);
int [,] arraySort = ArraySort(array);
Console.WriteLine();
PrintArray(arraySort);


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
int [,] FillArray (int [,] ar){
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
int [,] ArraySort (int [,] arr){
    int [] temp = new int [arr.GetLength(0)];
    for (int i = 0;i < arr.GetLength(0);i++){
        for (int j = 0;j < arr.GetLength(1);j++){
            temp[j] = arr[i,j];
        }
        Array.Sort(temp, (x, y) => y.CompareTo(x));
    
        for (int j = 0;j < arr.GetLength(1);j++){
            arr[i,j] = temp[j];
        }
    }
    return arr;
}

void PrintArray <T> (T [,] ar){
     for (int i = 0;i < ar.GetLength(0);i++){
        for (int j = 0;j < ar.GetLength(1);j++){
           Console.Write(ar[i,j] + " ");
        }
        Console.WriteLine();
    }
}
