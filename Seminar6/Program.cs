// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
string result = "";
string output = "";
int count = 0;

while (true) {
    Input();
    Console.WriteLine("Завершить ввод? (Y/N)");
    output = Console.ReadLine();
    if (output.ToLower().Equals("y"))
        break;
}
int [] arr = Fill();
PrintArr(arr);
Console.Write(Count());
Console.WriteLine();


void Input (){
    Console.WriteLine("Введите число");
    string text = Console.ReadLine();
    Check(text);
}

void Check (string t){
    int num = 0;
    if (Int32.TryParse(t,out num))  {
         result += t + " ";
    } else {
        Input();
    }
}
int [] Fill () {
string[] sarr = result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int [] arr = new int[sarr.Length];
for (int i = 0; i < arr.Length; i++)
    arr[i] = Convert.ToInt32(sarr[i]);
return arr;
}
int Count (){
    foreach (int a in arr)
        if (a > 0) count++;
    return count;
}
void PrintArr<T>(T [] arrr){
    Console.Write("Количество чисел больше 0 - [");
    foreach (T ar in arrr)
        Console.Write (ar + " ");
      Console.Write("] -> ");   
}

// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());
if (k2 != k1) {
    double x = Math.Round(((b2-b1) / (k1 - k2)),2);
    double y1 = Math.Round((k1*x + b1),2);
    Console.WriteLine("Точка пересечения двух прямых " + x + "," + y1);
} else {
    Console.WriteLine("Точки пересчения нет");
}