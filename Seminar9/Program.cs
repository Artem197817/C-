//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

int num = 0;
int N = Input ("Введите N > 0");
Console.Write(N + " -> ");
Print(N);
Console.WriteLine();

int Input (string message){
    Console.WriteLine(message);
    string text = Console.ReadLine();
    Check(text);
    return num;
}

void Check (string t){
    if (Int32.TryParse(t,out num))  {
         if (num >= 0) {}
            else {
        Console.WriteLine("Введено некорректное значение");
        Input("Повторите ввод");
    }
    }
    else {
        Console.WriteLine("Введено некорректное значение");
        Input("Повторите ввод");
    }
}
int Print (int n){
    if (n < 1) return 1;
    Console.Write(n + " ");
    return Print (--n);
}

// Задача 66: Задайте значения A и B. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от A до B.

int A = Input ("Введите A");
int B = Input ("Введите B > A");
int sumtemp = 0;
int sum = Sum(A , B);
Console.WriteLine(sum != -1 ? "Сумма чисел от " + A + " до " + B + " -> " + sum : "Ошибка");

int Sum (int a , int b){
    if (a > b) {
        Console.WriteLine("Неверный диапазон А > B");
        return -1;
    }
    sumtemp += a;
    if (a == b) return sumtemp;
    return Sum((a+1), b);
}

 //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
 //Даны два неотрицательных числа m и n.

int m = Input("Введите m");
int n = Input("Введите n");
Console.WriteLine("m = " + m + " , n = " + n + " A(m,n) -> " + Akkerman(m,n));

int Akkerman(int m, int n) {
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
  }